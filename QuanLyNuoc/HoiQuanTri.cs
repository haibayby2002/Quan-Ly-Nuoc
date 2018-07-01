using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNuoc
{
    public partial class frmHoiQuanTri : Form
    {
        public frmHoiQuanTri()
        {
            InitializeComponent();
        }

        public frmHoiQuanTri(string VanDe)
        {
            InitializeComponent();
            lblQuanTri.Text += "\r\n-" + VanDe;
    }

        public static bool check;

        private void frmHoiQuanTri_Load(object sender, EventArgs e)
        {
            check = false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        bool KiemTraMatKhau()
        {
            if (txtMatKhau.Text != "12345678")
            {
                return false;
            }
            return true;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (!KiemTraMatKhau())
            {
                MessageBox.Show("Mật khẩu không đúng, vui lòng kiểm tra lại!", "Sai mật khẩu", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMatKhau.SelectAll();
            }
            else
            {
                check = true;
                this.Close();
            }

        }

        private void chkXacNhan_CheckedChanged(object sender, EventArgs e)
        {
            btnXacNhan.Enabled = chkXacNhan.Checked && (txtMatKhau.Text != "");
        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {
            chkXacNhan_CheckedChanged(null, null);
        }

        private void txtMatKhau_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && btnXacNhan.Enabled)
            {
                btnXacNhan_Click(null, null);
            }
        }
    }
}
