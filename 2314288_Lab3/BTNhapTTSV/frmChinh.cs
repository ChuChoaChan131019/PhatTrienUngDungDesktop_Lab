using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BTNhapTTSV
{
    public partial class frmChinh : Form
    {
        private string _dataPath = @"../../DSSV.txt";
        private QLSV qlsv = new QLSV();
        private Filetxt txt = new Filetxt();
        public frmChinh()
        {
            InitializeComponent();
        }

        //them thong tin len listview
        public void ThemSV(SinhVien sv)
        {
            ListViewItem lvitem = new ListViewItem(sv.MSSV);
            lvitem.SubItems.Add(sv.HoTenLot);
            lvitem.SubItems.Add(sv.Ten);
            lvitem.SubItems.Add(sv.NgaySinh.ToShortDateString());
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lvitem.SubItems.Add(gt);
            lvitem.SubItems.Add(sv.Lop);
            lvitem.SubItems.Add(sv.CMND);
            lvitem.SubItems.Add(sv.SDT);
            lvitem.SubItems.Add(sv.DiaChi);
            string mon = "";
            foreach (string s in sv.DSMonHoc)
                mon += s + ",";
            mon = mon.Substring(0, mon.Length - 1);
            lvitem.SubItems.Add(mon);
            this.lvDSSV.Items.Add(lvitem);

        }
        //Hiển thị sinh viên lên lisiview
        private void LoadLV()
        {
            this.lvDSSV.Items.Clear();
            foreach (SinhVien sv in qlsv.dssv)
                ThemSV(sv);
        }
        //Lấy thông tin nhập từ control
        private SinhVien GetSV()
        {
            SinhVien sv = new SinhVien();
            bool gt = true;
            List<string> mon = new List<string>();
            sv.MSSV = this.mtxtMSSV.Text;
            sv.HoTenLot = this.txtHoTenLot.Text;
            sv.Ten = this.txtTen.Text;
            sv.NgaySinh = this.dtpNgaySinh.Value;
            sv.Lop = this.cbLop.SelectedItem.ToString();
            sv.DiaChi = this.txtDiaChi.Text;
            sv.CMND = this.mtxtCMND.Text;
            sv.SDT = this.mtxtSDT.Text;
            if (rdNu.Checked)
                gt = false;
            sv.GioiTinh = gt;
            for (int i = 0; i < this.clbMonHocDangKy.Items.Count; i++)
                if (clbMonHocDangKy.GetItemChecked(i))
                    mon.Add(clbMonHocDangKy.Items[i].ToString());
            sv.DSMonHoc = mon;
            return sv;

        }
        // lấy thong tin từ listview
        private SinhVien GetSVLV(ListViewItem lvitem)
        {
            SinhVien sv = new SinhVien();
            sv.MSSV = lvitem.SubItems[0].Text;
            sv.HoTenLot = lvitem.SubItems[1].Text;
            sv.Ten = lvitem.SubItems[2].Text;
            sv.NgaySinh = DateTime.Parse(lvitem.SubItems[3].Text);
            sv.GioiTinh = false;
            if (lvitem.SubItems[4].Text == "Nam")
                sv.GioiTinh = true;
            sv.Lop = lvitem.SubItems[5].Text;
            sv.CMND = lvitem.SubItems[6].Text;
            sv.SDT = lvitem.SubItems[7].Text;
            sv.DiaChi = lvitem.SubItems[8].Text;
            List<string> monhoc = new List<string>();
            string[] s = lvitem.SubItems[9].Text.Split(',');
            foreach (string t in s)
                monhoc.Add(t);
            sv.DSMonHoc = monhoc;
            return sv;
        }
        // thiết lập thong tin len control
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMSSV.Text = sv.MSSV;
            this.txtHoTenLot.Text = sv.HoTenLot;
            this.txtTen.Text = sv.Ten;
            this.dtpNgaySinh.Value = sv.NgaySinh;
            this.cbLop.Text = sv.Lop;
            this.mtxtCMND.Text = sv.CMND;
            this.mtxtSDT.Text = sv.SDT;
            this.txtDiaChi.Text = sv.DiaChi;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else
                this.rdNu.Checked = true;
            for (int i = 0; i < this.clbMonHocDangKy.Items.Count; i++)
                this.clbMonHocDangKy.SetItemChecked(i, false);
            foreach (string s in sv.DSMonHoc)
                for (int i = 0; i < clbMonHocDangKy.Items.Count; i++)
                    if (s.CompareTo(this.clbMonHocDangKy.Items[i]) == 0)
                        this.clbMonHocDangKy.SetItemChecked(i, true);
        }
        private IStudentStorage GetStorageByExtension(string path)
        {
            switch (Path.GetExtension(path).ToLower())
            {
                case ".txt": return new Filetxt();
                case ".xml": return new FileXML();
                case ".json": return new FileJSON();
                default: return new Filetxt(); // mặc định .txt
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            var storage = GetStorageByExtension(_dataPath);
            var list = storage.Load(_dataPath); 
            foreach (var sv in list)
            {
                if (qlsv.KiemTraMSSV(sv.MSSV, sv.Lop)) 
                    qlsv.Them(sv);
                else
                    MessageBox.Show($"MSSV {sv.MSSV} không hợp lệ cho lớp {sv.Lop} → bỏ qua.", "Cảnh báo");
            }


            lvDSSV.Items.Clear();
            foreach (var sv in qlsv.dssv) ThemSV(sv);
            LoadLV();
        }
        // lấy thong tin từ listview lên control
        private void lvDSSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvDSSV.SelectedItems.Count;
            if (count > 0)
            {
                ListViewItem lvitem = this.lvDSSV.SelectedItems[0];
                SinhVien sv = GetSVLV(lvitem);
                ThietLapThongTin(sv);
            }
        }
       
        //Kiểm tra nhập đủ thông tin
        private bool KiemTraThongTin()
        {
            if (string.IsNullOrWhiteSpace(mtxtMSSV.Text)||mtxtMSSV.Text.Trim().Length!=7)
            {
                MessageBox.Show("Vui lòng nhập MSSV.", "Thông báo", MessageBoxButtons.OK);
                mtxtMSSV.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtHoTenLot.Text))
            {
                MessageBox.Show("Vui lòng nhập Họ và tên lót.", "Thông báo", MessageBoxButtons.OK);
                txtHoTenLot.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                MessageBox.Show("Vui lòng nhập Tên.", "Thông báo", MessageBoxButtons.OK);
                txtTen.Focus();
                return false;
            }
            if (cbLop.SelectedIndex < 0)
            {
                MessageBox.Show("Vui lòng chọn Lớp.", "Thông báo", MessageBoxButtons.OK);
                cbLop.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(mtxtCMND.Text) || mtxtCMND.Text.Trim().Length != 9)
            {
                MessageBox.Show("Vui lòng nhập số CMND.", "Thông báo", MessageBoxButtons.OK);
                mtxtCMND.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(mtxtSDT.Text) || mtxtSDT.Text.Trim().Length != 12)
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thông báo", MessageBoxButtons.OK);
                mtxtSDT.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtDiaChi.Text))
            {
                MessageBox.Show("Vui lòng nhập địa chỉ liên lạc.", "Thông báo", MessageBoxButtons.OK);
                txtDiaChi.Focus();
                return false;
            }
            if (!rdNam.Checked && !rdNu.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (clbMonHocDangKy.CheckedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một môn học.", "Thông báo", MessageBoxButtons.OK);
                return false;
            }
            if (!qlsv.KiemTraMSSV(mtxtMSSV.Text.Trim(), cbLop.Text))
            {
                mtxtMSSV.Focus();
                return false;
            }
            return true;
        }
        private int SoSanhMSSV(object o1, object o2)
        {
            string ma = o1 as string;
            SinhVien sv = o2 as SinhVien;
            return string.Compare(ma, sv.MSSV, true);
        }
        private void ClearControl()
        {
            mtxtMSSV.Clear();
            mtxtCMND.Clear();
            mtxtSDT.Clear();
            txtHoTenLot.Clear();
            txtTen.Clear();
            txtDiaChi.Clear();
            dtpNgaySinh.Value=DateTime.Now;
            rdNam.Checked = false;
            rdNu.Checked = false;
            cbLop.SelectedIndex = -1;
            for (int i = 0; i < clbMonHocDangKy.Items.Count; i++)
                clbMonHocDangKy.SetItemChecked(i, false);
            lvDSSV.SelectedItems.Clear();
            mtxtMSSV.Focus();

        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin()) return;
            txt.QlSinhVien = qlsv;
            var sv = GetSV();
            if (qlsv.Tim(sv.MSSV, SoSanhMSSV) != null)
            {
                MessageBox.Show("MSSV dã tồn tại", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            qlsv.Them(sv);
            LoadLV();
            string path = @"../../DSSV.txt";
            txt.Save(path, qlsv.dssv);
            MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
            ClearControl();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (!KiemTraThongTin()) return;
            SinhVien sv = GetSV();
            bool kq;
            kq = qlsv.Sua(sv, sv.MSSV, SoSanhMSSV);
            if (kq)
            {
                this.LoadLV();
                string path = @"../../DSSV.txt";
                txt.Save( path, qlsv.dssv); MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Chưa có MSSV này", "Thông báo", MessageBoxButtons.OK);
            ClearControl();

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Bạn có chắc chắn muốn thoát chương trình không?","Thông báo",MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void HienThiKetQua(List<SinhVien> ketQua)
        {
            lvDSSV.Items.Clear();
            foreach (var sv in ketQua)
                ThemSV(sv);
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            groupBoxTim.Visible = true;
        }
        private void btnTim_Click(object sender, EventArgs e)
        {
            var ketQua = qlsv.TimNhieuDieuKien(txtTimMSSV.Text.Trim(),txtTimTen.Text.Trim(),txtTimLop.Text.Trim(),cbMSSV.Checked,cbTen.Checked,checkBoxLop.Checked);
            HienThiKetQua(ketQua);
            MessageBox.Show($"Tìm thấy {ketQua.Count} sinh viên.", "Kết quả");
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            groupBoxTim.Visible = false;
            HienThiKetQua(qlsv.dssv);
        }

        private void lvDSSV_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button== MouseButtons.Right)
            {
                var hit = lvDSSV.HitTest(e.Location);
                if(hit.Item != null)
                {
                    lvDSSV.SelectedItems.Clear();
                    hit.Item.Selected = true;
                }
                contextMenuStriplvDSSV.Show(lvDSSV, e.Location);
            }
        }

        private void xóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvDSSV.Items.Count - 1;
            for (i = count; i > 0; i--)
            {
                lvitem = this.lvDSSV.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhMSSV);
            }
            LoadLV();
            string path = @"../../DSSV.txt";
            txt.Save(path, qlsv.dssv);
            MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
        }

        private void clbMonHocDangKy_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                int i= clbMonHocDangKy.IndexFromPoint(e.Location);
                if(i!=ListBox.NoMatches)
                {
                    clbMonHocDangKy.SelectedIndex = i;
                    contextMenuStripMonHocDK.Show(clbMonHocDangKy, e.Location);
                }
            }
        }

        private void xóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int i = clbMonHocDangKy.SelectedIndex;
            if(i==ListBox.NoMatches)
            {
                MessageBox.Show("Chọn môn cần xóa", "Thông báo", MessageBoxButtons.OK);
                return;
            }
            string mon = clbMonHocDangKy.Items[i].ToString();
            var confirm = MessageBox.Show($"Xóa môn: {mon}?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm != DialogResult.Yes) 
                return;
            clbMonHocDangKy.Items.RemoveAt(i);
        }

        private void thêmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var frm = new frmThemMonHoc())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    string mon = frm.TenMon;

                    bool daTonTai = clbMonHocDangKy.Items
                        .Cast<object>()
                        .Any(x => string.Equals(x.ToString().Trim(), mon, StringComparison.OrdinalIgnoreCase));

                    if (daTonTai)
                    {
                        MessageBox.Show("Môn này đã tồn tại trong danh sách.", "Thông báo");
                        return;
                    }

                    clbMonHocDangKy.Items.Add(mon, false);
                }
            }
        }

       
    }
}
