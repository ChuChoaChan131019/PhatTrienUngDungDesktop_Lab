using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaptinVB
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string filename = "test.txt"; // tên file, file này sẽ được tạo cùng thư mục chạy chương trình
			string[] text = { "1" };
			
			WriteReadText(filename,
				 text);
			Console.WriteLine("\nNhấn Enter để thoát...");
			Console.ReadLine();
		}

		private static void WriteReadText(string filename, string []text)
		{
			File.AppendAllLines(filename, text);
			foreach (string s in File.ReadAllLines(filename))
				Console.WriteLine(s);
		}
	}
}
