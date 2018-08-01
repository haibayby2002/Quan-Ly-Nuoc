namespace QuanLyNuoc
{
    partial class frmThemHo
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
            this.txtTenHo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbLoaiHo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbMaNhanh = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaHoc = new System.Windows.Forms.ComboBox();
            this.grbMaHo = new System.Windows.Forms.GroupBox();
            this.txtMaSo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.rdbTuCap = new System.Windows.Forms.RadioButton();
            this.rdbCapSan = new System.Windows.Forms.RadioButton();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.grbMaHo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hộ: ";
            // 
            // txtTenHo
            // 
            this.txtTenHo.Location = new System.Drawing.Point(150, 119);
            this.txtTenHo.Name = "txtTenHo";
            this.txtTenHo.Size = new System.Drawing.Size(225, 26);
            this.txtTenHo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại hộ: ";
            // 
            // cmbLoaiHo
            // 
            this.cmbLoaiHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiHo.FormattingEnabled = true;
            this.cmbLoaiHo.Location = new System.Drawing.Point(150, 165);
            this.cmbLoaiHo.Name = "cmbLoaiHo";
            this.cmbLoaiHo.Size = new System.Drawing.Size(225, 27);
            this.cmbLoaiHo.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Mã nhánh: ";
            // 
            // cmbMaNhanh
            // 
            this.cmbMaNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaNhanh.FormattingEnabled = true;
            this.cmbMaNhanh.Location = new System.Drawing.Point(150, 27);
            this.cmbMaNhanh.Name = "cmbMaNhanh";
            this.cmbMaNhanh.Size = new System.Drawing.Size(225, 27);
            this.cmbMaNhanh.TabIndex = 5;
            this.cmbMaNhanh.SelectionChangeCommitted += new System.EventHandler(this.cmbMaNhanh_SelectionChangeCommitted);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 19);
            this.label4.TabIndex = 6;
            this.label4.Text = "Mã hộc: ";
            // 
            // cmbMaHoc
            // 
            this.cmbMaHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaHoc.FormattingEnabled = true;
            this.cmbMaHoc.Location = new System.Drawing.Point(150, 72);
            this.cmbMaHoc.Name = "cmbMaHoc";
            this.cmbMaHoc.Size = new System.Drawing.Size(225, 27);
            this.cmbMaHoc.TabIndex = 7;
            // 
            // grbMaHo
            // 
            this.grbMaHo.Controls.Add(this.txtMaSo);
            this.grbMaHo.Controls.Add(this.label5);
            this.grbMaHo.Controls.Add(this.rdbTuCap);
            this.grbMaHo.Controls.Add(this.rdbCapSan);
            this.grbMaHo.Location = new System.Drawing.Point(41, 207);
            this.grbMaHo.Name = "grbMaHo";
            this.grbMaHo.Size = new System.Drawing.Size(349, 117);
            this.grbMaHo.TabIndex = 8;
            this.grbMaHo.TabStop = false;
            this.grbMaHo.Text = "Mã hộ";
            // 
            // txtMaSo
            // 
            this.txtMaSo.Enabled = false;
            this.txtMaSo.Location = new System.Drawing.Point(109, 70);
            this.txtMaSo.Name = "txtMaSo";
            this.txtMaSo.Size = new System.Drawing.Size(225, 26);
            this.txtMaSo.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 19);
            this.label5.TabIndex = 2;
            this.label5.Text = "Mã số: ";
            // 
            // rdbTuCap
            // 
            this.rdbTuCap.AutoSize = true;
            this.rdbTuCap.Location = new System.Drawing.Point(263, 25);
            this.rdbTuCap.Name = "rdbTuCap";
            this.rdbTuCap.Size = new System.Drawing.Size(71, 23);
            this.rdbTuCap.TabIndex = 1;
            this.rdbTuCap.Text = "Tự cấp";
            this.rdbTuCap.UseVisualStyleBackColor = true;
            // 
            // rdbCapSan
            // 
            this.rdbCapSan.AutoSize = true;
            this.rdbCapSan.Checked = true;
            this.rdbCapSan.Location = new System.Drawing.Point(18, 25);
            this.rdbCapSan.Name = "rdbCapSan";
            this.rdbCapSan.Size = new System.Drawing.Size(156, 23);
            this.rdbCapSan.TabIndex = 0;
            this.rdbCapSan.TabStop = true;
            this.rdbCapSan.Text = "Chương trình cấp sẵn";
            this.rdbCapSan.UseVisualStyleBackColor = true;
            this.rdbCapSan.CheckedChanged += new System.EventHandler(this.rdbCapSan_CheckedChanged);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(304, 331);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(87, 36);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(223, 331);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 36);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // frmThemHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 379);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.grbMaHo);
            this.Controls.Add(this.cmbMaHoc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMaNhanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbLoaiHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenHo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThemHo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm hộ sử dụng";
            this.Load += new System.EventHandler(this.frmThemHo_Load);
            this.grbMaHo.ResumeLayout(false);
            this.grbMaHo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLoaiHo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbMaNhanh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaHoc;
        private System.Windows.Forms.GroupBox grbMaHo;
        private System.Windows.Forms.TextBox txtMaSo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdbTuCap;
        private System.Windows.Forms.RadioButton rdbCapSan;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
    }
}