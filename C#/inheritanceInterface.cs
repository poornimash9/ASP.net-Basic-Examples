using System;

namespace intheritancExample{
	public class parentClass{
		public void parentDisplay(){
			Console.WriteLine("parent");
		}
	}
	
	public interface parent1interface{
		void displayParent();
	}
	
	public interface parent2interface{
		void displayParent2();
	}
	
	public class childClass:parentClass,parent1interface,parent2interface{
		public void displayParent(){
			Console.WriteLine("displayParent");
		}
		public void displayParent2(){
			Console.WriteLine("displayParent2");
		}
		public void childDisplay(){
			Console.WriteLine("child");
		}
	}
	
	public class mainClass{
		public static void Main(String[] args){
			childClass child=new childClass();
			child.parentDisplay();
			child.displayParent();
			child.displayParent2();
			child.childDisplay();
		}
	}
}