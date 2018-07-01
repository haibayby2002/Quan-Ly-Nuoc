namespace QuanLyNuoc
{
    partial class frmHoiQuanTri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHoiQuanTri));
            this.lblQuanTri = new System.Windows.Forms.Label();
            this.lblMayKhau = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.chkXacNhan = new System.Windows.Forms.CheckBox();
            this.ptbAdmin = new System.Windows.Forms.PictureBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // lblQuanTri
            // 
            this.lblQuanTri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQuanTri.AutoSize = true;
            this.lblQuanTri.Location = new System.Drawing.Point(163, 9);
            this.lblQuanTri.MaximumSize = new System.Drawing.Size(500, 0);
            this.lblQuanTri.Name = "lblQuanTri";
            this.lblQuanTri.Size = new System.Drawing.Size(497, 84);
            this.lblQuanTri.TabIndex = 0;
            this.lblQuanTri.Text = resources.GetString("lblQuanTri.Text");
            this.lblQuanTri.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMayKhau
            // 
            this.lblMayKhau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblMayKhau.AutoSize = true;
            this.lblMayKhau.Location = new System.Drawing.Point(15, 162);
            this.lblMayKhau.Name = "lblMayKhau";
            this.lblMayKhau.Size = new System.Drawing.Size(131, 21);
            this.lblMayKhau.TabIndex = 1;
            this.lblMayKhau.Text = "Nhập mật khẩu: ";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMatKhau.Location = new System.Drawing.Point(149, 159);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(504, 29);
            this.txtMatKhau.TabIndex = 2;
            this.txtMatKhau.UseSystemPasswordChar = true;
            this.txtMatKhau.TextChanged += new System.EventHandler(this.txtMatKhau_TextChanged);
            this.txtMatKhau.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtMatKhau_KeyUp);
            // 
            // chkXacNhan
            // 
            this.chkXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chkXacNhan.AutoSize = true;
            this.chkXacNhan.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkXacNhan.Location = new System.Drawing.Point(19, 194);
            this.chkXacNhan.Name = "chkXacNhan";
            this.chkXacNhan.Size = new System.Drawing.Size(638, 25);
            this.chkXacNhan.TabIndex = 3;
            this.chkXacNhan.Text = "Tôi đã hiểu và sẵn sàng chịu trách nhiệm về hệ thống thông tin trong cơ sở dữ liệ" +
    "u";
            this.chkXacNhan.UseVisualStyleBackColor = true;
            this.chkXacNhan.CheckedChanged += new System.EventHandler(this.chkXacNhan_CheckedChanged);
            // 
            // ptbAdmin
            // 
            this.ptbAdmin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbAdmin.Image = global::QuanLyNuoc.Properties.Resources.admin;
            this.ptbAdmin.Location = new System.Drawing.Point(19, 12);
            this.ptbAdmin.Name = "ptbAdmin";
            this.ptbAdmin.Size = new System.Drawing.Size(134, 135);
            this.ptbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAdmin.TabIndex = 6;
            this.ptbAdmin.TabStop = false;
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Image = global::QuanLyNuoc.Properties.Resources.icons8_cancel_32;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.Location = new System.Drawing.Point(446, 228);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(84, 42);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXacNhan.Enabled = false;
            this.btnXacNhan.Image = global::QuanLyNuoc.Properties.Resources.icons8_ok_hand_32;
            this.btnXacNhan.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXacNhan.Location = new System.Drawing.Point(536, 228);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(117, 42);
            this.btnXacNhan.TabIndex = 4;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmHoiQuanTri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 281);
            this.Controls.Add(this.ptbAdmin);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.chkXacNhan);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.lblMayKhau);
            this.Controls.Add(this.lblQuanTri);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHoiQuanTri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận quyền quản trị";
            this.Load += new System.EventHandler(this.frmHoiQuanTri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuanTri;
        private System.Windows.Forms.Label lblMayKhau;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.CheckBox chkXacNhan;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.PictureBox ptbAdmin;
    }
}