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
    public partial class frmSuaHo : Form
    {
        public frmSuaHo()
        {
            InitializeComponent();
            //Đọc nhánh khi load lên
            SqlDataReader r = Database.Read("select *from Nhanh");
            while (r.Read())
            {
                cmbNhanh.Items.Add(r["MaNhanh"]);
            }
            r.Close();
        }

        public static bool check;

        public frmSuaHo(string maSo, string tenHo, string nhanh, int hoc, string loaiHo)
        {
            InitializeComponent();

            //Load loại hộ
            //Set cho nó value và text hiển thị
            cmbLoaiHo.ValueMember = "MaLoai";
            cmbLoaiHo.DisplayMember = "MoTa";
            //Dù gì thì cũng phải load CSDL lên loại hộ
            cmbLoaiHo.DataSource = Database.LoadCSDL(@"select *from LoaiHo");

            //Đọc nhánh khi load lên
            SqlDataReader r = Database.Read("select *from Nhanh");
            while (r.Read())
            {
                cmbNhanh.Items.Add(r["MaNhanh"]);
            }
            r.Close();

            //MessageBox.Show(maSo);
            //MessageBox.Show(tenHo);
            //MessageBox.Show(nhanh + " " + hoc.ToString());
            //MessageBox.Show(loaiHo);

            maSo = maSo.Substring(nhanh.Length);

            txtMaSo.Text = maSo;
            txtTenHo.Text = tenHo;
            cmbNhanh.SelectedItem = nhanh;
            cmbHoc.SelectedItem = hoc;
            cmbLoaiHo.Text = loaiHo;

            this.maSo = int.Parse(maSo);
            this.maNhanh = nhanh;
            txtMaSo.Text = this.maSo.ToString();
        }

        public int maSo;
        public string maNhanh;

        private void frmSuaHo_Load(object sender, EventArgs e)
        {
            check = false;
        }

        private void cmbNhanh_SelectedValueChanged(object sender, EventArgs e)
        {
            //Xử lý hộc
            cmbHoc.Items.Clear();
            //Load tất cả các hộc
            SqlDataReader r = Database.Read("select MaHoc from KhuVuc where MaNhanh = '" + cmbNhanh.Text + "'");
            while (r.Read())
            {
                cmbHoc.Items.Add(r["MaHoc"]);
            }
            r.Close();

            //Xử lý mã số
            if (cmbNhanh.Text != maNhanh && !chkCapLai.Checked)   //Nếu nhánh thay đổi khác nhánh ban đầu vả tắt cấp lại
            {
                txtMaSo.Text = Database.GetValue("exec GetId '" + cmbNhanh.Text + "'").ToString();
            }
            else if (!chkCapLai.Checked)
            {
                txtMaSo.Text = maSo.ToString();
            }
        }

        private void chkCapLai_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCapLai.Checked)  //Nếu chọn cấp lại thì lưu mã số vào biến tạm để xử lý sau này
            {
                txtMaSo.Enabled = true;
                txtMaSo.Text = "";
            }
            else
            {
                txtMaSo.Text = maSo.ToString();
                txtMaSo.Enabled = false;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            check = false;
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            //Kiểm tra trước
            if (txtMaSo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mã số", "Lỗi thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMaSo.Focus();
                return;
            }
            else if (!Database.ChuoiLaSo(txtMaSo.Text)) 
            {
                MessageBox.Show("Định dạng mã số không đúng. Lưu ý, mã số chỉ tồn tại ký số. Vui lòng kiểm tra lại", "Lỗi sai định dạng", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtMaSo.Focus();
                txtMaSo.SelectAll();
                return;
            }
            else if(txtTenHo.Text == "")
            {
                MessageBox.Show("Vui lòng nhập tên hộ", "Lỗi thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtTenHo.Focus();
                return;
            }
            else if(cmbNhanh.Text == "")
            {
                MessageBox.Show("Vui lòng chọn nhánh", "Lỗi thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbNhanh.DroppedDown = true;
                return;
            }
            else if(cmbHoc.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hộc", "Lỗi thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cmbHoc.DroppedDown = true;
                return;
            }
            else    //Đến được đây rồi thì chỉ còn kiểm tra ràng buộc toàn vẹn nữa thôi
            {
                if(int.Parse(txtMaSo.Text) == maSo && cmbNhanh.Text == maNhanh)
                {
                    try
                    {
                        Database.Change(string.Format(@"exec UpdateUserNotKey '{0}', {1}, {2}, N'{3}', '{4}'",
                            cmbNhanh.Text, cmbHoc.Text, txtMaSo.Text, txtTenHo.Text, cmbLoaiHo.SelectedValue));
                        check = true;
                        this.Close();
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show("Mã số đã trong nhánh đã tồn tại, vui lòng kiểm tra lại\r\n" + error.Message, "Lỗi bị trùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    try
                    {
                        Database.Change(string.Format(@"exec UpdateUser '{0}', {1}, {2}, N'{3}', '{4}', {5}, '{6}' ",
                            cmbNhanh.Text, cmbHoc.Text, txtMaSo.Text, txtTenHo.Text, cmbLoaiHo.SelectedValue, maSo.ToString(), maNhanh));
                        check = true;
                        this.Close();
                    }
                    catch (SqlException error)
                    {
                        MessageBox.Show("Mã số đã trong nhánh đã tồn tại, vui lòng kiểm tra lại\r\n" + error.Message, "Lỗi bị trùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
        }


    }
}
