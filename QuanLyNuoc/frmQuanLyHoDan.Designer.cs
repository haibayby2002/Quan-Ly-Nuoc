namespace QuanLyNuoc
{
    partial class frmQuanLyHoDan
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
            this.cmbNhanh = new System.Windows.Forms.ComboBox();
            this.cmbHoc = new System.Windows.Forms.ComboBox();
            this.cmbLoaiHo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPhanLoaiHo = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cmbNhanh
            // 
            this.cmbNhanh.FormattingEnabled = true;
            this.cmbNhanh.Location = new System.Drawing.Point(75, 46);
            this.cmbNhanh.Name = "cmbNhanh";
            this.cmbNhanh.Size = new System.Drawing.Size(95, 27);
            this.cmbNhanh.TabIndex = 0;
            // 
            // cmbHoc
            // 
            this.cmbHoc.FormattingEnabled = true;
            this.cmbHoc.Location = new System.Drawing.Point(208, 46);
            this.cmbHoc.Name = "cmbHoc";
            this.cmbHoc.Size = new System.Drawing.Size(95, 27);
            this.cmbHoc.TabIndex = 1;
            // 
            // cmbLoaiHo
            // 
            this.cmbLoaiHo.FormattingEnabled = true;
            this.cmbLoaiHo.Location = new System.Drawing.Point(496, 46);
            this.cmbLoaiHo.Name = "cmbLoaiHo";
            this.cmbLoaiHo.Size = new System.Drawing.Size(104, 27);
            this.cmbLoaiHo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhánh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Hộc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại hộ";
            // 
            // chkPhanLoaiHo
            // 
            this.chkPhanLoaiHo.AutoSize = true;
            this.chkPhanLoaiHo.Location = new System.Drawing.Point(351, 48);
            this.chkPhanLoaiHo.Name = "chkPhanLoaiHo";
            this.chkPhanLoaiHo.Size = new System.Drawing.Size(139, 23);
            this.chkPhanLoaiHo.TabIndex = 6;
            this.chkPhanLoaiHo.Text = "Lọc theo loại hộ";
            this.chkPhanLoaiHo.UseVisualStyleBackColor = true;
            // 
            // frmQuanLyHoDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 401);
            this.Controls.Add(this.chkPhanLoaiHo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLoaiHo);
            this.Controls.Add(this.cmbHoc);
            this.Controls.Add(this.cmbNhanh);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyHoDan";
            this.Text = "Quản lý hộ dân";
            this.Load += new System.EventHandler(this.frmQuanLyHoDan_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNhanh;
        private System.Windows.Forms.ComboBox cmbHoc;
        private System.Windows.Forms.ComboBox cmbLoaiHo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPhanLoaiHo;
    }
}