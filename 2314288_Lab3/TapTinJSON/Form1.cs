using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapTinJSON
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnReadJSON_Click(object sender, EventArgs e)
		{
			string Str = "";
			string Path = "../../students.json";
			List<StudentInfo> List = LoadJSON(Path);

			for (int i = 0; i < List.Count; i++) 
			{
				StudentInfo info = List[i];
				Str += string.Format("Sinh viên {0} có MSSV: {1}, tên: {2}, \n" +
									 "điểm TB: {3}\n\n", i + 1, info.MSSV, info.Hoten, info.Diem);
			}

			MessageBox.Show(Str);
		}

		
		private List<StudentInfo> LoadJSON(string Path)
		{
			List<StudentInfo> list = new List<StudentInfo>();

			StreamReader r = new StreamReader(Path);
			string json = r.ReadToEnd();
			var array = (JObject)JsonConvert.DeserializeObject(json);

			var students = array["Sinh vien"].Children();
			foreach (var item in students) 
			{
				string mssv = item["MSSV"].Value<string>();
				string hoten = item["hoten"].Value<string>();
				int tuoi = item["tuoi"].Value<int>();
				double diem = item["diem"].Value<double>();
				bool tongiao = item["tongiao"].Value<bool>();

				StudentInfo sv = new StudentInfo(mssv, hoten, tuoi, diem, tongiao);

				list.Add(sv);
			}

			return list;
		}

	}
}
