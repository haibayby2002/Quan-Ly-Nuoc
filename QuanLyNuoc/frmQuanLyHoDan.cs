using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNuoc
{
    public partial class frmQuanLyHoDan : Form
    {
        public frmQuanLyHoDan()
        {
            InitializeComponent();
        }

        #region load from database
        private void frmQuanLyHoDan_Load(object sender, EventArgs e)
        {
            //Đọc nhánh khi load lên
            cmbNhanh.Items.Add("Tất cả");
            SqlDataReader r = Database.Read("select *from Nhanh");
            while (r.Read())
            {
                cmbNhanh.Items.Add(r["MaNhanh"]);
            }
            r.Close();
            cmbNhanh.SelectedIndex = 0;
        }

        //Khi mà thay đổi Nhánh thì hộc cũng sẽ thay đổi theo (trừ trường hợp tất cả các nhánh
        private void cmbNhanh_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNhanh.SelectedIndex != 0)     //Không chọn tất cả nhánh thì sẽ load hộc
            {
                //Hiện combobox và text hộc
                cmbHoc.Show();
                lblHoc.Show();

                cmbHoc.Items.Clear();
                cmbHoc.Items.Add("Tất cả");
                SqlDataReader r = Database.Read("select MaHoc from KhuVuc where MaNhanh = '" + cmbNhanh.Text + "'");
                while (r.Read())
                {
                    cmbHoc.Items.Add(r["MaHoc"]);
                }
                r.Close();
                cmbHoc.SelectedIndex = 0;
            }
            else
            {
                //Ẩn đi vì chọn tất cả
                cmbHoc.Hide();
                lblHoc.Hide();
                cmbHoc.Items.Clear();
            }
        }

        //Lọc theo loại hộ
        private void chkPhanLoaiHo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhanLoaiHo.Checked)
            {
                cmbLoaiHo.DataSource = Database.LoadCSDL("select *from LoaiHo");
                cmbLoaiHo.DisplayMember = "MoTa";
                cmbLoaiHo.ValueMember = "MaLoai";
                cmbLoaiHo.Enabled = true;
            }
            else
            {
                cmbLoaiHo.Enabled = false;
                cmbLoaiHo.DataSource = null;
            }
        }

        #endregion

        //Khi đóng form mà nếu còn kết nối CSDL thì đóng kết nối lại
        private void frmQuanLyHoDan_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Database.conn.State == ConnectionState.Open)
            {
                Database.conn.Close();
            }
        }
    }
}
