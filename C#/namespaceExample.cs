using System;

namespace namespace1{
	public class parentClass{
		public void parentDisplay(){
			Console.WriteLine("parent");
		}
	}
}
namespace namespace2{
	public class parentClass{
		public void parentDisplay(){
			Console.WriteLine("parent2");
		}
	}
}	
	
public class mainClass{
	public static void Main(String[] args){
		namespace1.parentClass parent=new namespace1.parentClass();
		parent.parentDisplay();
		
		namespace2.parentClass parent2=new namespace2.parentClass();
		parent2.parentDisplay();
	}
}
