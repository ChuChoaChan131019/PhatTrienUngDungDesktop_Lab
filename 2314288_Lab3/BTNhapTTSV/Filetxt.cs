using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Xml.Serialization;

namespace BTNhapTTSV
{
    public class Filetxt:IStudentStorage
    {
        public QLSV QlSinhVien;
        public List<SinhVien> Load(string filename)
        {
            var list = new List<SinhVien>();
            if (!File.Exists(filename)) return list;

            var formats = new[] { "dd/MM/yyyy" };
            foreach (var line in File.ReadAllLines(filename))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var s = line.Split('\t');
                if (s.Length < 10) continue;

                var sv = new SinhVien
                {
                    MSSV = s[0],
                    HoTenLot = s[1],
                    Ten = s[2],
                    NgaySinh = DateTime.TryParseExact(s[3], formats,
                        CultureInfo.InvariantCulture, DateTimeStyles.None, out var ngay)
                        ? ngay : DateTime.MinValue,
                    GioiTinh = string.Equals(s[4], "True", StringComparison.OrdinalIgnoreCase) || s[4] == "1",
                    Lop = s[5],
                    CMND = s[6],
                    SDT = s[7],
                    DiaChi = s[8],
                    DSMonHoc = s[9].Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                   .Select(x => x.Trim()).ToList()
                };

                list.Add(sv);
            }
            return list;
        }



        public void Save(string filename, List<SinhVien> data)
        {
            using (StreamWriter sw = new StreamWriter(filename, false, Encoding.UTF8))
            {
                foreach (var sv in data)
                {
                    string monhoc = string.Join(",", sv.DSMonHoc);
                    sw.WriteLine($"{sv.MSSV}\t{sv.HoTenLot}\t{sv.Ten}\t{sv.NgaySinh:dd/MM/yyyy}\t{sv.GioiTinh}\t{sv.Lop}\t{sv.CMND}\t{sv.SDT}\t{sv.DiaChi}\t{monhoc}");
                }
            }
        }
    }
}
