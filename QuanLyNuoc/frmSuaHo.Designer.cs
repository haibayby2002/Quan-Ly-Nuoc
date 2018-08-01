using System.Data.SqlClient;

namespace QuanLyNuoc
{
    partial class frmSuaHo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.txtTenHo = new System.Windows.Forms.TextBox();
            this.cmbNhanh = new System.Windows.Forms.ComboBox();
            this.cmbHoc = new System.Windows.Forms.ComboBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.chkCapLai = new System.Windows.Forms.CheckBox();
            this.cmbLoaiHo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã số: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên hộ: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhánh: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Hộc: ";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Enabled = false;
            this.txtMaSo.Location = new System.Drawing.Point(120, 35);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(140, 26);
            this.txtMaSo.TabIndex = 4;
            // 
            // txtTenHo
            // 
            this.txtTenHo.Location = new System.Drawing.Point(120, 77);
            this.txtTenHo.Name = "txtTenHo";
            this.txtTenHo.Size = new System.Drawing.Size(237, 26);
            this.txtTenHo.TabIndex = 5;
            // 
            // cmbNhanh
            // 
            this.cmbNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanh.FormattingEnabled = true;
            this.cmbNhanh.Location = new System.Drawing.Point(120, 120);
            this.cmbNhanh.Name = "cmbNhanh";
            this.cmbNhanh.Size = new System.Drawing.Size(237, 27);
            this.cmbNhanh.TabIndex = 6;
            this.cmbNhanh.SelectedValueChanged += new System.EventHandler(this.cmbNhanh_SelectedValueChanged);
            // 
            // cmbHoc
            // 
            this.cmbHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoc.FormattingEnabled = true;
            this.cmbHoc.Location = new System.Drawing.Point(120, 160);
            this.cmbHoc.Name = "cmbHoc";
            this.cmbHoc.Size = new System.Drawing.Size(237, 27);
            this.cmbHoc.TabIndex = 7;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.Location = new System.Drawing.Point(266, 256);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(91, 37);
            this.btnXacNhan.TabIndex = 8;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Location = new System.Drawing.Point(177, 256);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(83, 37);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // chkCapLai
            // 
            this.chkCapLai.AutoSize = true;
            this.chkCapLai.Location = new System.Drawing.Point(272, 38);
            this.chkCapLai.Name = "chkCapLai";
            this.chkCapLai.Size = new System.Drawing.Size(71, 23);
            this.chkCapLai.TabIndex = 10;
            this.chkCapLai.Text = "Cấp lại";
            this.chkCapLai.UseVisualStyleBackColor = true;
            this.chkCapLai.CheckedChanged += new System.EventHandler(this.chkCapLai_CheckedChanged);
            // 
            // cmbLoaiHo
            // 
            this.cmbLoaiHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiHo.FormattingEnabled = true;
            this.cmbLoaiHo.Location = new System.Drawing.Point(120, 203);
            this.cmbLoaiHo.Name = "cmbLoaiHo";
            this.cmbLoaiHo.Size = new System.Drawing.Size(237, 27);
            this.cmbLoaiHo.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Loại hộ:";
            // 
            // frmSuaHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 314);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLoaiHo);
            this.Controls.Add(this.chkCapLai);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.cmbHoc);
            this.Controls.Add(this.cmbNhanh);
            this.Controls.Add(this.txtTenHo);
            this.Controls.Add(this.txtMaSo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSuaHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sửa hộ";
            this.Load += new System.EventHandler(this.frmSuaHo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.TextBox txtTenHo;
        private System.Windows.Forms.ComboBox cmbNhanh;
        private System.Windows.Forms.ComboBox cmbHoc;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.CheckBox chkCapLai;
        private System.Windows.Forms.ComboBox cmbLoaiHo;
        private System.Windows.Forms.Label label5;
    }
}