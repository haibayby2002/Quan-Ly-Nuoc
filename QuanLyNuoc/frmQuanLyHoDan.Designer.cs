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
            this.lblHoc = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkPhanLoaiHo = new System.Windows.Forms.CheckBox();
            this.dgvHoDan = new System.Windows.Forms.DataGridView();
            this.MaHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoDan)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNhanh
            // 
            this.cmbNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanh.FormattingEnabled = true;
            this.cmbNhanh.Location = new System.Drawing.Point(75, 46);
            this.cmbNhanh.Name = "cmbNhanh";
            this.cmbNhanh.Size = new System.Drawing.Size(95, 27);
            this.cmbNhanh.TabIndex = 0;
            this.cmbNhanh.SelectedIndexChanged += new System.EventHandler(this.cmbNhanh_SelectedIndexChanged);
            // 
            // cmbHoc
            // 
            this.cmbHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoc.FormattingEnabled = true;
            this.cmbHoc.Location = new System.Drawing.Point(208, 46);
            this.cmbHoc.Name = "cmbHoc";
            this.cmbHoc.Size = new System.Drawing.Size(95, 27);
            this.cmbHoc.TabIndex = 1;
            // 
            // cmbLoaiHo
            // 
            this.cmbLoaiHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiHo.FormattingEnabled = true;
            this.cmbLoaiHo.Location = new System.Drawing.Point(496, 46);
            this.cmbLoaiHo.Name = "cmbLoaiHo";
            this.cmbLoaiHo.Size = new System.Drawing.Size(104, 27);
            this.cmbLoaiHo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhánh";
            // 
            // lblHoc
            // 
            this.lblHoc.AutoSize = true;
            this.lblHoc.Location = new System.Drawing.Point(237, 24);
            this.lblHoc.Name = "lblHoc";
            this.lblHoc.Size = new System.Drawing.Size(36, 19);
            this.lblHoc.TabIndex = 4;
            this.lblHoc.Text = "Hộc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(519, 24);
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
            this.chkPhanLoaiHo.CheckedChanged += new System.EventHandler(this.chkPhanLoaiHo_CheckedChanged);
            // 
            // dgvHoDan
            // 
            this.dgvHoDan.AllowUserToAddRows = false;
            this.dgvHoDan.AllowUserToDeleteRows = false;
            this.dgvHoDan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoDan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHo,
            this.TenHo,
            this.MaNhanh,
            this.MaHoc});
            this.dgvHoDan.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoDan.Location = new System.Drawing.Point(0, 136);
            this.dgvHoDan.MultiSelect = false;
            this.dgvHoDan.Name = "dgvHoDan";
            this.dgvHoDan.ReadOnly = true;
            this.dgvHoDan.RowHeadersVisible = false;
            this.dgvHoDan.Size = new System.Drawing.Size(662, 265);
            this.dgvHoDan.TabIndex = 7;
            // 
            // MaHo
            // 
            this.MaHo.DataPropertyName = "MaHo";
            this.MaHo.HeaderText = "Mã hộ";
            this.MaHo.Name = "MaHo";
            this.MaHo.ReadOnly = true;
            // 
            // TenHo
            // 
            this.TenHo.DataPropertyName = "TenHo";
            this.TenHo.HeaderText = "Tên hộ sử dụng";
            this.TenHo.Name = "TenHo";
            this.TenHo.ReadOnly = true;
            // 
            // MaNhanh
            // 
            this.MaNhanh.DataPropertyName = "MaNhanh";
            this.MaNhanh.HeaderText = "Mã nhánh";
            this.MaNhanh.Name = "MaNhanh";
            this.MaNhanh.ReadOnly = true;
            // 
            // MaHoc
            // 
            this.MaHoc.DataPropertyName = "MaHoc";
            this.MaHoc.HeaderText = "Mã hộc";
            this.MaHoc.Name = "MaHoc";
            this.MaHoc.ReadOnly = true;
            // 
            // frmQuanLyHoDan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 401);
            this.Controls.Add(this.dgvHoDan);
            this.Controls.Add(this.chkPhanLoaiHo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLoaiHo);
            this.Controls.Add(this.cmbHoc);
            this.Controls.Add(this.cmbNhanh);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyHoDan";
            this.Text = "Quản lý hộ dân";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuanLyHoDan_FormClosed);
            this.Load += new System.EventHandler(this.frmQuanLyHoDan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoDan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbNhanh;
        private System.Windows.Forms.ComboBox cmbHoc;
        private System.Windows.Forms.ComboBox cmbLoaiHo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkPhanLoaiHo;
        private System.Windows.Forms.DataGridView dgvHoDan;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoc;
    }
}