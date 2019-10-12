using System;
using System.Text.RegularExpressions;

namespace regExExample{
	public class regEx{
		public static void Main(String[] args){
			String a=Console.ReadLine();
			String b=Console.ReadLine();
			string pattern = "\\s+";
			Regex regex=new Regex(pattern);
			Console.WriteLine("before {0} {1}",a,b);
			String res=regex.Replace(b,a);
			Console.WriteLine("after {0}",res);
		}
	}
}