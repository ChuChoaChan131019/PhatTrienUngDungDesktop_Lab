using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BTNhapTTSV
{
    public class FileXML: IStudentStorage
    {
        public List<SinhVien> Load(string filename)
        {
            if (!File.Exists(filename)) return new List<SinhVien>();
            var ser = new XmlSerializer(typeof(List<SinhVien>));
            using (var fs = new FileStream(filename, FileMode.Open))
                return (List<SinhVien>)ser.Deserialize(fs);
        }

        public void Save(string filename, List<SinhVien> data)
        {
            var ser = new XmlSerializer(typeof(List<SinhVien>));
            using (var fs = new FileStream(filename, FileMode.Create))
                ser.Serialize(fs, data ?? new List<SinhVien>());
        }
    }
}
