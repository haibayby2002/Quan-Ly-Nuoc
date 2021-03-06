﻿using System;
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
            //chkCheckAll_CheckedChanged(null, null);
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
                        dgvHoDan.DataSource = Database.LoadCSDL(@"exec SelectTheoNhanh '" + cmbNhanh.Text + "'");
                    }
                    else        //Phân loại hộ
                    {
                        dgvHoDan.DataSource = Database.LoadCSDL(@"exec SelectTheoNhanhVaLoai '" + cmbNhanh.Text + "', '" + cmbLoaiHo.SelectedValue + "'");
                    }
                }
                else        //Chia hộc
                {
                    if (!chkPhanLoaiHo.Checked) //Tất cả các loại hộ
                    {
                        dgvHoDan.DataSource = Database.LoadCSDL(@"exec SelectTheoNhanhHoc '" + cmbNhanh.Text + "', " + cmbHoc.Text + "");
                    }
                    else
                    {
                        dgvHoDan.DataSource = Database.LoadCSDL(@"exec SelectTheoNhanhHocVaLoai '" + cmbNhanh.Text + "', " + cmbHoc.Text + ", '" + cmbLoaiHo.SelectedValue + "'");
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
                    dgvHoDan.DataSource = Database.LoadCSDL(@"exec SelectAll");
                }
                else
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"exec SelectTheoLoai '" + cmbLoaiHo.SelectedValue + "'");
                }
            }
            if (dgvHoDan.Rows.Count != 0) dgvHoDan.Rows[0].Selected = false;
        }

        //Chia dựa vào hộc
        private void cmbHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Chọn tất cả thì chỉ lấy theo nhánh tương ứng
            if (cmbHoc.SelectedIndex == 0)
            {
                if (!chkPhanLoaiHo.Checked)     //Phân loại
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"exec SelectTheoNhanh '" + cmbNhanh.Text + "'");
                }
                else    //Không phân loại
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"exec SelectTheoNhanhVaLoai'" + cmbNhanh.Text + "', '" + cmbLoaiHo.SelectedValue + "'");
                }
            }
            else    //Trường hợp chọn hộc thì lọc ra nhánh trong hộc
            {
                //không phân loại
                if (!chkPhanLoaiHo.Checked)
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"exec SelectTheoNhanhHoc '" + cmbNhanh.Text + "', " + cmbHoc.Text + "");
                }
                else
                {
                    dgvHoDan.DataSource = Database.LoadCSDL(@"exec SelectTheoNhanhHocVaLoai '" + cmbNhanh.Text + "', " + cmbHoc.Text + ", '" + cmbLoaiHo.SelectedValue + "'");
                }
            }
            if (dgvHoDan.Rows.Count != 0) dgvHoDan.Rows[0].Selected = false;
        }

        void ReLoad()
        {
            if (cmbNhanh.SelectedIndex == 0)  //Nếu nhánh chọn tất cả thì theo nhánh mà chiến
            {
                cmbNhanh_SelectionChangeCommitted(null, null);
            }
            else    //Ngược lại thì cứ theo hộc mà indexchange
            {
                cmbHoc_SelectedIndexChanged(null, null);
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

                ReLoad();
            }
            else
            {
                //Cái này thì không phân loại hộ nên là sẽ cho cái cmbLoaiHo về rỗng
                cmbLoaiHo.DataSource = null;
                //-------------------------------------
                cmbLoaiHo.Hide();   //Ản đi vì không càn nữa
                lblLoaiHo.Hide();

                //Cuối cùng là dựa vào mà load lên thôi
                ReLoad();
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
                    item.Selected = chkCheckAll.Checked;
                }
            }
        }

        

        #endregion

        #region Thêm xóa sửa huyền thoại
        private void btnThemHo_Click(object sender, EventArgs e)
        {
            frmThemHo frmThem = new frmThemHo();
            frmThem.ShowDialog();
            if (frmThemHo.check)
            {
                ReLoad();
                MessageBox.Show("Thêm thành công!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int dem = dgvHoDan.SelectedRows.Count;
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
                        string[] query = new string[dem];
                        int i = 0;
                        //);
                        foreach (DataGridViewRow c in dgvHoDan.SelectedRows)
                        {
                            query[i] = @"delete from HoDan where MaHo = " + Database.GetId(c.Cells["MaHo"].Value.ToString()) + " and MaNhanh = '" + Database.GetNhanh(c.Cells["MaHo"].Value.ToString()) + "'";
                            i++;
                        }
                        Database.Change(query);
                        chkPhanLoaiHo_CheckedChanged(null, null);
                        MessageBox.Show("Đã xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else    //Số phần tử cần xóa >= 3 nên cần phải nhập mật khẩu xác nhận mới cho xóa
                    {
                        frmHoiQuanTri QuanTri = new frmHoiQuanTri("Bạn cần quyền quản trị để xóa cùng lúc nhiều hộ sử dụng (" + dem + " hộ)");
                        QuanTri.ShowDialog();
                        if (frmHoiQuanTri.check)
                        {
                            //Xóa
                            string[] query = new string[dem];
                            int i = 0;
                            //);
                            foreach (DataGridViewRow c in dgvHoDan.SelectedRows)
                            {
                                query[i] = @"delete from HoDan where MaHo = " + Database.GetId(c.Cells["MaHo"].Value.ToString()) + " and MaNhanh = '" + Database.GetNhanh(c.Cells["MaHo"].Value.ToString()) + "'";
                                i++;
                            }
                            Database.Change(query);
                            chkPhanLoaiHo_CheckedChanged(null, null);
                            MessageBox.Show("Đã xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }


        #endregion

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvHoDan.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn hộ để sửa", "Lỗi chưa chọn phần tử", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if(dgvHoDan.SelectedRows.Count != 1)
            {
                MessageBox.Show("Vui lòng chỉ chọn một hộ để sửa", "Mỗi lần chỉ sửa thông tin cho một hộ", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                DataGridViewRow i = dgvHoDan.SelectedRows[0];
                frmSuaHo formSuaHo = new frmSuaHo(i.Cells["MaHo"].Value.ToString(), i.Cells["TenHo"].Value.ToString(), i.Cells["MaNhanh"].Value.ToString(), int.Parse(i.Cells["MaHoc"].Value.ToString()), i.Cells["LoaiHo"].Value.ToString());
                formSuaHo.ShowDialog();
                if (frmSuaHo.check)
                {
                    MessageBox.Show("Sửa đổi thông tin thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ReLoad();
                }
            }
        }

        private void dgvHoDan_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            btnSua_Click(null, null);
        }
    }
}
