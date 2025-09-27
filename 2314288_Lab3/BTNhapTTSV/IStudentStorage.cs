using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNhapTTSV
{
    public interface IStudentStorage
    {
        List<SinhVien> Load(string filename);
        void Save(string filename, List<SinhVien> data);
    }
 }
