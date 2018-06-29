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
    public partial class frmDangNhap : Form
    {
        #region Form
        public frmDangNhap()
        {
            InitializeComponent();
        }


        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void frmDangNhap_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                //Click vào nút đăng nhập
            }
        }

        #endregion

        private void ptbExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region Exit


        #endregion

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

        }

    }
}
