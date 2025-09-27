using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using System.IO;

namespace BTNhapTTSV
{
    internal class FileJSON : IStudentStorage
    {
        public List<SinhVien> Load(string filename)
        {
            if (!File.Exists(filename)) return new List<SinhVien>();
            var json = File.ReadAllText(filename);
            return JsonConvert.DeserializeObject<List<SinhVien>>(json) ?? new List<SinhVien>();
        }

        public void Save(string filename, List<SinhVien> data)
        {
            var json = JsonConvert.SerializeObject(data ?? new List<SinhVien>(), Formatting.Indented);
            File.WriteAllText(filename, json);
        }
    }
}
