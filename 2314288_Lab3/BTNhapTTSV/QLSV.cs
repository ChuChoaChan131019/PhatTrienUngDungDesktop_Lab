using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTNhapTTSV
{
    public class QLSV
    {
        public delegate int SoSanh(object sv1, object sv2);
        public List<SinhVien> dssv;
        public QLSV()
        {
            dssv = new List<SinhVien>();
        }
        public SinhVien this[int index]
        {
            get { return this.dssv[index]; }
            set { dssv[index] = value; }
        }
        //KT MSSV
        private string LayNamTuLop(string lop)
        {
            if (lop.StartsWith("CTK47")) return "23";
            if (lop.StartsWith("CTK48")) return "24";
            if (lop.StartsWith("CTK49")) return "25";
            return "00";
        }
        public bool KiemTraMSSV(string mssv, string lop)
        {

            string nam = LayNamTuLop(lop);

            if (mssv.Substring(0, 2) != nam)
            {
                MessageBox.Show($"2 số đầu MSSV phải là {nam} (năm nhập học 20{nam}).", "Thông báo");
                return false;
            }

            if (mssv.Substring(2, 2) != "10")
            {
                MessageBox.Show("MSSV phải có AABBCCC với BB = 10.", "Thông báo");
                return false;
            }
            return true;
        }
        public void Them(SinhVien sv)
        { 
            this.dssv.Add(sv);
        }
        public SinhVien Tim(object o, SoSanh ss)
        {
            SinhVien kq = null;
            foreach(SinhVien sv in dssv)
                if(ss(o,sv)==0)
                {
                    kq = sv;
                    break;
                }
            return kq;
        }
        public bool Sua(SinhVien svSua, object o, SoSanh ss)
        {
            int i, count;
            bool kq = false;
            count = this.dssv.Count - 1;
            for (i = 0; i < count; i++)
                if (ss(o, this[i]) == 0)
                {
                    this[i] = svSua;
                    kq = true;
                    break;
                }
            return kq;
        }
        public void Xoa(object o, SoSanh ss)
        {
            int i = dssv.Count - 1;
            for (; i >= 0; i--)
                if (ss(o, this[i]) == 0)
                    this.dssv.RemoveAt(i);
        }

        public List<SinhVien> TimNhieuDieuKien(string mssv, string ten, string lop,
                                        bool timMSSV, bool timTen, bool timLop)
        {
            var q = dssv.AsEnumerable();

            if (timMSSV && !string.IsNullOrWhiteSpace(mssv))
            {
                var key = mssv.Trim().ToLower();
                q = q.Where(sv => (sv.MSSV ?? "").Trim().ToLower().Contains(key));
            }

            if (timTen && !string.IsNullOrWhiteSpace(ten))
            {
                var key = ten.Trim().ToLower();
                q = q.Where(sv =>
                {
                    var hoLot = (sv.HoTenLot ?? "").Trim();
                    var tenSV = (sv.Ten ?? "").Trim();
                    var full = (hoLot + " " + tenSV).Trim().ToLower();
                    return full.Contains(key);
                });
            }

            if (timLop && !string.IsNullOrWhiteSpace(lop))
            {
                var key = lop.Trim().ToLower();
                q = q.Where(sv => (sv.Lop ?? "").Trim().ToLower().Contains(key));
            }

            return q.ToList();
        }

    }
}
