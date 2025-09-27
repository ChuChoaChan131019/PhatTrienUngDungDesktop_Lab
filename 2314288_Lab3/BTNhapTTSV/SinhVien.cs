using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTNhapTTSV
{
    public class SinhVien
    {
        public string MSSV {  get; set; }
        public string HoTenLot { get; set; }
        public string Ten {  get; set; }
        public DateTime NgaySinh { get; set; }
        public bool GioiTinh { get; set; }
        public string Lop {  get; set; }
        public string CMND { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public List<string> DSMonHoc { get; set; }
        public SinhVien() 
        {
            DSMonHoc = new List<string>();
        }
        public SinhVien(string mssv, string hoTenLot, string ten, DateTime ngaySinh,bool gioiTinh, string lop, string cmnd, string sDT, string diaChi, List<string> dSMonHoc)
        {
            this.MSSV = mssv;
            this.HoTenLot = hoTenLot;
            this.Ten = ten;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = GioiTinh;
            this.Lop = lop;
            this.CMND = cmnd;
            this.SDT = sDT;
            this.DiaChi = diaChi;
            this.DSMonHoc = dSMonHoc ?? new List<string>();
        }
    }
}
