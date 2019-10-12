using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HelloWorld
{
    public partial class DemoForm : System.Web.UI.Page
    {
        String connectionString;
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;

        protected void Page_Load(object sender, EventArgs e)
        {
            
            connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=UserForm;Integrated Security=True;Pooling=False";

            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            Response.Write("Connection done");

        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            String firstName = firstNameInput.Text.Trim();
            String lastName = LastNameInput.Text.Trim();
            int gender = 0;
            String role = DropDownList1.SelectedValue;
            if(firstName.Length==0 && lastName.Length == 0)
            {
                firstNameLabel.Text = "No Input";
            }
            else
            {
                //Session["firstName"] = firstNameInput.Text;
                String query = "INSERT INTO users(firstName,lastName,gender,role) VALUES('"+firstName+"','"+lastName+"','"+gender+"','"+role+"');";
                sqlCommand = new SqlCommand(query,sqlConnection);
                sqlCommand.ExecuteNonQuery();
                firstNameLabel.Text = firstName + " " + lastName + " " + DropDownList1.SelectedValue + " " + Male.Checked + " " + Female.Checked + " " + accept.Checked;
                    //+" "+Session["firstName"];
            }
           
        }

        protected void show_Click(object sender, EventArgs e)
        {
            SqlDataReader sqlDataReader;
            //String firstnames="", lastnames="";
            String query = "SELECT * from users;";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlDataReader = sqlCommand.ExecuteReader();
            GridView1.DataSource = sqlDataReader;
            GridView1.DataBind();

            //while (sqlDataReader.Read())
            //{
            //    firstnames =firstnames+ sqlDataReader.GetValue(1).ToString()+"<br>";
            //    lastnames=lastnames+ sqlDataReader.GetValue(2).ToString() + "<br>";
            //    //Response.Write(sqlDataReader.GetValue(0));
            //}
            //firstname.Text = firstnames;
            //lastname.Text = lastnames;

        }

        protected void GridView1_rowdeleting(object sender, GridViewDeleteEventArgs e)
        {
            GridViewRow gridViewRow = GridView1.Rows[e.RowIndex];
            Response.Write(gridViewRow.Cells[0].Text);
            String query = "DELETE from users where id="+ gridViewRow.Cells[0].Text + ";";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
        }

        protected void deleteInfo_Click(object sender, EventArgs e)
        {
            String query = "DELETE from users where id=3;";
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();

        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            Response.Write("hello2");
            //GridViewRow gridViewRow = GridView1.Rows[e.NewEditIndex];
            //firstNameInput.Text = gridViewRow.Cells[1].Text;
            //LastNameInput.Text = gridViewRow.Cells[2].Text;
            //Male.Checked = true;
            //DropDownList1.SelectedValue = gridViewRow.Cells[4].Text;
        }



        //protected void clicking(object sender, EventArgs e)
        //{
        //    Response.Write("hiiiiiiiiii");
        //}
    }
}