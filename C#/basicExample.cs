using System;
					
namespace helloWorldApp{
	public class Rect{
		public int a,c;
		public double b;
		public String name;
		public void display(){
			a=10;
			b=100.32;
			c=(int)b;
			Console.WriteLine(a is{0},a);
			Console.WriteLine(size of int is {0} {1},sizeof(int),sizeof(double));
			Console.WriteLine(b and c {0} {1},b,c);
			name=Console.ReadLine();
			Console.WriteLine(name is {0},name);
			for( int i=0;i10;i++){
				Console.WriteLine(num is {0},i);
			}
		}
	}
	public class helloworld{
		public static void Main(String[] args){
			Console.WriteLine(Hello world);
			Rect r=new Rect();
			r.display();
		}
	}
}