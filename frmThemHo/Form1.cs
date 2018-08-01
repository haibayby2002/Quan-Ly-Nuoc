using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmThemHo
{
    public partial class frmThemHo : Form
    {
        public frmThemHo()
        {
            InitializeComponent();
        }

        

        #region Load loai ho
        private void frmThemHo_Load(object sender, EventArgs e)
        {
            cmbLoaiHo.ValueMember = "MaLoai";
            cmbLoaiHo.DisplayMember = "MoTa";
            cmbLoaiHo.DataSource = Database
        }
        #endregion
    }
}
