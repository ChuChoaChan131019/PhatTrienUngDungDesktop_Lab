using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TapTinXML
{
	internal class Program
	{
		static void Main(string[] args)
		{
			var  xmlDoc = new XmlDocument();
			xmlDoc.Load("..\\..\\books.xml");

			var nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/book");
            foreach (XmlNode node in nodeList)
            {
				var isbn = node.Attributes["ISBN"].Value;
				var title = node.SelectSingleNode("title").InnerText;
				var price = node.SelectSingleNode("price").InnerText;
				var fullname = node.SelectSingleNode("author/first-name").InnerText;
				var lastname = node.SelectSingleNode("author/last-name").InnerText;
				Console.WriteLine("{0,-15}{1,-50}{2,-15}{3,-15}{4,6}", isbn, title, fullname, lastname, price);

			}
			Console.ReadLine();
		}
	}
}
