using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNuoc
{
    public partial class frmThemHo : Form
    {
        public frmThemHo()
        {
            InitializeComponent();
        }

        public static bool check;   //Kiểm tra xem có thỏa điều kiện thêm khi kết thúc form hay không

        private void frmThemHo_Load(object sender, EventArgs e)
        {
            check = false;

            cmbLoaiHo.Items.Clear();
            cmbLoaiHo.ValueMember = "MaLoai";
            cmbLoaiHo.DisplayMember = "MoTa";
            cmbLoaiHo.DataSource = Database.LoadCSDL("select * from LoaiHo");
            cmbLoaiHo.SelectedIndex = 1;

            cmbMaNhanh.Items.Clear();
            SqlDataReader r = Database.Read("Select MaNhanh from Nhanh");
            while (r.Read())
            {
                cmbMaNhanh.Items.Add(r.GetString(0));
            }
            r.Close();
        }

        #region Load comboBox  

        //Load nhánh
        private void cmbMaNhanh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbMaHoc.Items.Clear();
            SqlDataReader r = Database.Read("select MaHoc from KhuVuc where MaNhanh = '" + cmbMaNhanh.Text + "'");
            while (r.Read())
            {
                cmbMaHoc.Items.Add(r["MaHoc"]);
            }
            r.Close();
            if (cmbMaNhanh.Text != "")
            {
                txtMaSo.Text = Database.GetValue("exec GetId '" + cmbMaNhanh.Text + "'").ToString();
            }
            else
            {
                txtMaSo.Text = "";
            }
        }

        #endregion



        private void rdbCapSan_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbCapSan.Checked)
            {
                if (cmbMaNhanh.Text != "")
                {
                    txtMaSo.Text = Database.GetValue("exec GetId '" + cmbMaNhanh.Text + "'").ToString();
                }
                else
                {
                    txtMaSo.Text = "";
                }
                txtMaSo.Enabled = false;
            }
            else
            {
                txtMaSo.Enabled = true;
                txtMaSo.Text = "";
                txtMaSo.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            check = false;
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if (txtTenHo.Text == "")    //Tên hộ không được rỗng
            {
                MessageBox.Show("Vui lòng nhập vào tên hộ sử dụng!", "Lỗi thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if (cmbMaNhanh.Text == "" || cmbMaHoc.Text == "")  //Bỏ trống nhánh hoặc hộc
            {
                MessageBox.Show("Vui lòng chọn mã nhánh và mã hộc", "Lỗi chưa chọn đầy đủ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            else if(rdbTuCap.Checked && txtMaSo.Text == "")     //Điều kiện mã số bỏ trống
            {
                MessageBox.Show("Mã số chưa được cấp, vui lòng kiểm tra lại mã số", "Lỗi thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMaSo.Focus();
                return;
            }
            else        //Chỉ còn kiểm tra lỗi throw exception và check
            {
                try
                {
                    //AddUser
                    Database.Change(string.Format("exec AddUser '{0}', {1}, {2}, N'{3}', '{4}'", cmbMaNhanh.Text, cmbMaHoc.Text, txtMaSo.Text, txtTenHo.Text, cmbLoaiHo.SelectedValue));
                    check = true;
                    this.Close();
                }
                catch(SqlException error)
                {
                    check = false;
                    MessageBox.Show("Không thể thêm, vui lòng kiểm tra mã số xem đã bị trùng?\r\n Lỗi: " + error.Message);
                    this.Close();
                }

            }
        }
    }
}
