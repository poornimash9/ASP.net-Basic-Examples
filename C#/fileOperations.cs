using System;
using System.IO;

namespace fileOpExample{
	public class fileOp{
		public static void Main(String[] args){
			FileStream filestream=new FileStream("1.txt",FileMode.Create,FileAccess.ReadWrite,FileShare.ReadWrite);
			filestream.WriteByte(1);
			filestream.WriteByte(2);
			filestream.WriteByte(3);
			filestream.WriteByte(5);
			filestream.WriteByte(6);
			
			for(int i=0;i<filestream.Length;i++){
				Console.WriteLine("from file {0}",filestream.ReadByte());
			}
		}
	}
}