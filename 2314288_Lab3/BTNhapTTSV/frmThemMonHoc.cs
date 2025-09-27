using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTNhapTTSV
{
    public partial class frmThemMonHoc : Form
    {
        public string TenMon { get; private set; }
        public frmThemMonHoc()
        {
            InitializeComponent();
        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTenMon.Text))
            {
                MessageBox.Show("Vui lòng nhập tên môn.", "Thông báo");
                return;
            }

            TenMon = txtTenMon.Text.Trim();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
