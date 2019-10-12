<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DemoForm.aspx.cs" Inherits="HelloWorld.DemoForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>First Program</title>
    <link rel="stylesheet" href="DemFormStyle.css" />
    <script src="DemoFormScript.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label1" runat="server" Text="First Name:"></asp:Label>
            <asp:TextBox ID="firstNameInput" runat="server"></asp:TextBox>           
        </div>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Last Name:"></asp:Label>
            <asp:TextBox ID="LastNameInput" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:RadioButton ID="Male" runat="server" GroupName="gender" Text="Male" />
            <asp:RadioButton ID="Female" runat="server" GroupName="gender" Text="Female" />
        </p>

        <%--<div>
            <input type="radio" name="gender" value="Male"  />
             <input type="radio" name="gender" value="FeMale" />
        </div>
        --%>

        <p>
            <asp:DropDownList ID="DropDownList1" runat="server" Width="200px">
                <asp:ListItem>SE</asp:ListItem>
                <asp:ListItem>SD</asp:ListItem>
                <asp:ListItem>Test</asp:ListItem>
            </asp:DropDownList>
        </p>
        <p>
            <asp:CheckBox ID="accept" runat="server" Text="Accept" />
        </p>
        <p>
            <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" Text="Submit" />
        </p>
        <p>
            <asp:Button ID="show" runat="server" OnClick="show_Click" Text="SHOW" />
            <asp:Button ID="deleteInfo" runat="server" Text="Delete" OnClick="deleteInfo_Click" />
        </p>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AutoGenerateEditButton="false" AutoGenerateSelectButton="false"
                OnRowDeleting="GridView1_rowdeleting" OnRowEditing="GridView1_RowEditing">
                <Columns>
                    <asp:BoundField HeaderText="SL NO" DataField="id" />
                    <asp:BoundField HeaderText="First Name" DataField="firstName" />
                    <asp:BoundField HeaderText="Last Name" DataField="lastName" />
                    <asp:BoundField HeaderText="Gender" DataField="gender" />
                    <asp:BoundField HeaderText="Role" DataField="role" />
                    <%--<asp:ButtonField ButtonType="Button" Text="Edit" HeaderText="Edit" />
                    <asp:ButtonField ButtonType="Button" Text="Delete" HeaderText="Delete" />--%>
                    <asp:CommandField ShowEditButton="true" />
                    <asp:CommandField ShowDeleteButton="true" />
                </Columns>
            </asp:GridView>
        </p>



        <p>
            <asp:Label runat="server" Text="First Name is:"></asp:Label>
            <asp:Label ID="firstNameLabel" runat="server"></asp:Label>
        </p>
        <p style="display:flex;justify-content:space-between">
            <asp:Label ID="firstNameLabel0" runat="server">First Name</asp:Label>
            <asp:Label ID="firstNameLabel1" runat="server">Last Name</asp:Label>
            <asp:Label ID="firstNameLabel2" runat="server">Gender</asp:Label>
            <asp:Label ID="firstNameLabel3" runat="server">Role</asp:Label>
        </p>
        <p style="display:flex;justify-content:space-between">
            <asp:Label ID="firstname" runat="server"></asp:Label>
            <asp:Label ID="lastname" runat="server"></asp:Label>
            <asp:Label ID="genderlabel" runat="server"></asp:Label>
            <asp:Label ID="role" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>

        <%--<button id="btn" runat="server" onclick="clicking()">click</button>--%>
    </form>

    <%--<span>outside</span>
    <button id="new2" onclick="newClick()">hbjhbhjb</button>
    <input type="text" runat="server" id="age" />--%>

</body>

   <%-- <script>
        function newClick() {
            alert("hello")
        }
    </script>--%>
</html>
