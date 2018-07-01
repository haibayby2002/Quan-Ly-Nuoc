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
            //dgvHoDan.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //Đọc nhánh khi load lên
            cmbNhanh.Items.Add("Tất cả");
            SqlDataReader r = Database.Read("select *from Nhanh");
            while (r.Read())
            {
                cmbNhanh.Items.Add(r["MaNhanh"]);
            }
            r.Close();
            cmbNhanh.SelectedIndex = 0;
            cmbNhanh_SelectionChangeCommitted(null, null);
        }

        //Khi mà thay đổi Nhánh thì hộc cũng sẽ thay đổi theo (trừ trường hợp tất cả các nhánh
        private void cmbNhanh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmbNhanh.SelectedIndex != 0)     //Không chọn tất cả nhánh thì sẽ load hộc
            {
                //Hiện combobox và text hộc
                cmbHoc.Show();
                lblHoc.Show();

                cmbHoc.Items.Clear();
                cmbHoc.Items.Add("Tất cả");

                //Load tất cả các hộc
                SqlDataReader r = Database.Read("select MaHoc from KhuVuc where MaNhanh = '" + cmbNhanh.Text + "'");
                while (r.Read())
                {
                    cmbHoc.Items.Add(r["MaHoc"]);
                }
                r.Close();
                cmbHoc.SelectedIndex = 0;

                //Tiến hành load
                if (cmbHoc.SelectedIndex == 0)  //Tất cả các hộc trong nhánh
                {
                    if (!chkPhanLoaiHo.Checked) //Tất cả các loại hộ
                    {
                        dgvHoDan.DataSource = Database.LoadCSDL(@"select *from SelectTheoNhanh('" + cmbNhanh.Text + "')");
                    }
                    else        //Phân loại hộ
                    {
                        dgvHoDan.DataSource = Database.LoadCSDL(@"select *from SelectTheoNhanhVaLoai('" + cmbNhanh.Text + "', '" + cmbLoaiHo.SelectedValue + "')");
                    }
                }
                else        //Chia hộc
                {
                    if (!chkPhanLoaiHo.Checked) //Tất cả các loại hộ
                    {
                        dgvHoDan.DataSource = Database.LoadCSDL(@"select *from SelectTheoNhanhVaHoc('" + cmbNhanh.Text + "', " + cmbHoc.Text + ")");
                    }
                    else
                    {
                        dgvHoDan.DataSource = Database.LoadCSDL(@"select *from SelectTheoNhanhHocVaLoai('" + cmbNhanh.Text + "', " + cmbHoc.Text + ", '" + cmbLoaiHo.SelectedValue + "')");
                    }
                }
            }
            else
            {
                //Ẩn đi vì chọn tất cả
                cmbHoc.Hide();
                lblHoc.Hide();
                cmbHoc.Items.Clear();

                //Phân loại hay không
                if (!chkPhanLoaiHo.Checked)
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"select * from SelectFull()");
                }
                else
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"select *from SelectTheoLoai('" + cmbLoaiHo.SelectedValue + "')");
                }
            }
        }

        //Chia dựa vào hộc
        private void cmbHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Chọn tất cả thì chỉ lấy theo nhánh tương ứng
            if (cmbHoc.SelectedIndex == 0)
            {
                if (!chkPhanLoaiHo.Checked)     //Phân loại
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"select *from SelectTheoNhanh('" + cmbNhanh.Text + "')");
                }
                else    //Không phân loại
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"select *from SelectTheoNhanhVaLoai('" + cmbNhanh.Text + "', '" + cmbLoaiHo.SelectedValue + "')");
                }
            }
            else    //Trường hợp chọn hộc thì lọc ra nhánh trong hộc
            {
                //không phân loại
                if (!chkPhanLoaiHo.Checked)
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"select *from SelectTheoNhanhVaHoc('" + cmbNhanh.Text + "', " + cmbHoc.Text + ")");
                }
                else
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"select *from SelectTheoNhanhHocVaLoai('" + cmbNhanh.Text + "', " + cmbHoc.Text + ", '" + cmbLoaiHo.SelectedValue + "')");
                }
            }
        }

        //Lọc theo loại hộ
        private void chkPhanLoaiHo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPhanLoaiHo.Checked)  //Nếu có phân loại
            {
                cmbLoaiHo.Show();   //Cho combo nó hiện ra
                lblLoaiHo.Show();

                //Set cho nó value và text hiển thị
                cmbLoaiHo.ValueMember = "MaLoai";
                cmbLoaiHo.DisplayMember = "MoTa";
                //Dù gì thì cũng phải load CSDL lên loại hộ
                cmbLoaiHo.DataSource = Database.LoadCSDL(@"select *from LoaiHo");

                if (cmbNhanh.SelectedIndex == 0)  //Nếu nhánh chọn tất cả thì theo nhánh mà chiến
                {
                    cmbNhanh_SelectionChangeCommitted(null, null);
                }
                else    //Ngược lại thì cứ theo hộc mà indexchange
                {
                    cmbHoc_SelectedIndexChanged(null, null);
                }
            }
            else
            {
                //Cái này thì không phân loại hộ nên là sẽ cho cái cmbLoaiHo về rỗng
                cmbLoaiHo.DataSource = null;
                //-------------------------------------
                cmbLoaiHo.Hide();   //Ản đi vì không càn nữa
                lblLoaiHo.Hide();

                //Cuối cùng là dựa vào mà load lên thôi
                if (cmbNhanh.SelectedIndex == 0)  //Nếu nhánh chọn tất cả thì theo nhánh mà chiến
                {
                    cmbNhanh_SelectionChangeCommitted(null, null);
                }
                else    //Ngược lại thì cứ theo hộc mà indexchange
                {
                    cmbHoc_SelectedIndexChanged(null, null);
                }
            }
        }

        private void cmbLoaiHo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gọi lại cái thay đổi của mấy cái combobox kia cho nhanh
            if (cmbNhanh.SelectedIndex == 0)  //Nếu nhánh chọn tất cả thì theo nhánh mà chiến
            {
                cmbNhanh_SelectionChangeCommitted(null, null);
            }
            else    //Ngược lại thì cứ theo hộc mà indexchange
            {
                cmbHoc_SelectedIndexChanged(null, null);
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

        #region Tra cuu dua vao ten va ma

        private void txtTraCuu_TextChanged(object sender, EventArgs e)
        {
            if (dgvHoDan.RowCount != 0)
            {
                CurrencyManager c = (CurrencyManager)BindingContext[dgvHoDan.DataSource];
                c.SuspendBinding();
                foreach (DataGridViewRow item in dgvHoDan.Rows)
                {
                    if (!Database.RemoveUnicode(item.Cells["TenHo"].Value.ToString()).ToLower().Contains(Database.RemoveUnicode(txtTraCuu.Text).ToLower())
                        && !(item.Cells["MaHo"].Value.ToString().ToLower().Contains(Database.RemoveUnicode(txtTraCuu.Text).ToLower())))
                    {
                        item.Visible = false;
                    }
                    else
                    {
                        item.Visible = true;
                    }
                }
                c.ResumeBinding();
                
            }
        }


        private void txtTraCuu_Leave(object sender, EventArgs e)
        {
            if(!dgvHoDan.Focused)
            {
                foreach (DataGridViewRow item in dgvHoDan.Rows)
                {
                    item.Visible = true;
                }
            }
        }

        #endregion

        #region chon ho de xoa
        private void chkCheckAll_CheckedChanged(object sender, EventArgs e)
        {
            if (dgvHoDan.RowCount != 0)
            {
                foreach (DataGridViewRow item in dgvHoDan.Rows)
                {
                    item.Cells["check"].Value = chkCheckAll.Checked;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> r = new List<DataGridViewRow>();
            int dem = 0;
            foreach (DataGridViewRow item in dgvHoDan.Rows)
            {
                if(Convert.ToBoolean(item.Cells["check"].Value))
                {
                    dem++;
                    r.Add(item);
                }
            }

            //Phải có phần tử chọn thì mới xóa được
            if (dem == 0)
            {
                MessageBox.Show("Bạn chưa chọn hộ để xóa, xin vui lòng kiểm tra lại", "Chưa chọn phần tử", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                //Hỏi xem có thực sự muốn xóa hay không
                DialogResult d = MessageBox.Show("Bạn có chắc chắn muốn xóa " + dem.ToString() + " hộ?", "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (d == DialogResult.OK)
                {
                    if (dem < 3)
                    {
                        for (int i = 0; i < r.Count; i++)
                        {
                            //MessageBox.Show("Nhanh " + Database.GetNhanh(r[i].Cells["MaHo"].ToString()) + "\r\n" + "Ma so: " + Database.GetId(r[i].Cells["MaHo"].ToString()));
                            Database.Change(@"delete from HoDan where MaHo = " + Database.GetId(r[i].Cells["MaHo"].Value.ToString()) + " and MaNhanh = '" + Database.GetNhanh(r[i].Cells["MaHo"].Value.ToString()) + "'");
                        }
                        chkPhanLoaiHo_CheckedChanged(null, null);
                        MessageBox.Show("Đã xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else    //Số phần tử cần xóa >= 3 nên cần phải nhập mật khẩu xác nhận mới cho xóa
                    {
                        frmHoiQuanTri QuanTri = new frmHoiQuanTri("Bạn cần quyền quản trị để xóa cùng lúc nhiều hộ sử dụng (" + dem + " hộ)");
                        QuanTri.ShowDialog();
                        if (frmHoiQuanTri.check)
                        {
                            for (int i = 0; i < r.Count; i++)
                            {
                                //MessageBox.Show("Nhanh " + Database.GetNhanh(r[i].Cells["MaHo"].ToString()) + "\r\n" + "Ma so: " + Database.GetId(r[i].Cells["MaHo"].ToString()));
                                Database.Change(@"delete from HoDan where MaHo = " + Database.GetId(r[i].Cells["MaHo"].Value.ToString()) + " and MaNhanh = '" + Database.GetNhanh(r[i].Cells["MaHo"].Value.ToString()) + "'");
                            }
                            chkPhanLoaiHo_CheckedChanged(null, null);
                            MessageBox.Show("Đã xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        #endregion
    }
}
