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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cmbNhanh = new System.Windows.Forms.ComboBox();
            this.cmbHoc = new System.Windows.Forms.ComboBox();
            this.cmbLoaiHo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHoc = new System.Windows.Forms.Label();
            this.lblLoaiHo = new System.Windows.Forms.Label();
            this.chkPhanLoaiHo = new System.Windows.Forms.CheckBox();
            this.dgvHoDan = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThemHo = new System.Windows.Forms.Button();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.lblTraCuu = new System.Windows.Forms.Label();
            this.chkCheckAll = new System.Windows.Forms.CheckBox();
            this.MaHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNhanh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoDan)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbNhanh
            // 
            this.cmbNhanh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNhanh.FormattingEnabled = true;
            this.cmbNhanh.Location = new System.Drawing.Point(75, 39);
            this.cmbNhanh.Name = "cmbNhanh";
            this.cmbNhanh.Size = new System.Drawing.Size(95, 27);
            this.cmbNhanh.TabIndex = 0;
            this.cmbNhanh.SelectionChangeCommitted += new System.EventHandler(this.cmbNhanh_SelectionChangeCommitted);
            // 
            // cmbHoc
            // 
            this.cmbHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHoc.FormattingEnabled = true;
            this.cmbHoc.Location = new System.Drawing.Point(208, 39);
            this.cmbHoc.Name = "cmbHoc";
            this.cmbHoc.Size = new System.Drawing.Size(95, 27);
            this.cmbHoc.TabIndex = 1;
            this.cmbHoc.SelectedIndexChanged += new System.EventHandler(this.cmbHoc_SelectedIndexChanged);
            // 
            // cmbLoaiHo
            // 
            this.cmbLoaiHo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLoaiHo.FormattingEnabled = true;
            this.cmbLoaiHo.Location = new System.Drawing.Point(496, 39);
            this.cmbLoaiHo.Name = "cmbLoaiHo";
            this.cmbLoaiHo.Size = new System.Drawing.Size(104, 27);
            this.cmbLoaiHo.TabIndex = 2;
            this.cmbLoaiHo.Visible = false;
            this.cmbLoaiHo.SelectedIndexChanged += new System.EventHandler(this.cmbLoaiHo_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(97, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nhánh";
            // 
            // lblHoc
            // 
            this.lblHoc.AutoSize = true;
            this.lblHoc.Location = new System.Drawing.Point(237, 17);
            this.lblHoc.Name = "lblHoc";
            this.lblHoc.Size = new System.Drawing.Size(36, 19);
            this.lblHoc.TabIndex = 4;
            this.lblHoc.Text = "Hộc";
            // 
            // lblLoaiHo
            // 
            this.lblLoaiHo.AutoSize = true;
            this.lblLoaiHo.Location = new System.Drawing.Point(519, 17);
            this.lblLoaiHo.Name = "lblLoaiHo";
            this.lblLoaiHo.Size = new System.Drawing.Size(61, 19);
            this.lblLoaiHo.TabIndex = 5;
            this.lblLoaiHo.Text = "Loại hộ";
            this.lblLoaiHo.Visible = false;
            // 
            // chkPhanLoaiHo
            // 
            this.chkPhanLoaiHo.AutoSize = true;
            this.chkPhanLoaiHo.Location = new System.Drawing.Point(351, 41);
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
            this.dgvHoDan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvHoDan.ColumnHeadersHeight = 40;
            this.dgvHoDan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHo,
            this.TenHo,
            this.LoaiHo,
            this.MaNhanh,
            this.MaHoc});
            this.dgvHoDan.Location = new System.Drawing.Point(0, 156);
            this.dgvHoDan.Name = "dgvHoDan";
            this.dgvHoDan.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHoDan.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHoDan.RowHeadersVisible = false;
            this.dgvHoDan.RowHeadersWidth = 50;
            this.dgvHoDan.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvHoDan.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Indigo;
            this.dgvHoDan.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Lime;
            this.dgvHoDan.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.DimGray;
            this.dgvHoDan.RowTemplate.Height = 50;
            this.dgvHoDan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHoDan.Size = new System.Drawing.Size(952, 350);
            this.dgvHoDan.TabIndex = 7;
            this.dgvHoDan.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvHoDan_CellMouseDoubleClick);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::QuanLyNuoc.Properties.Resources.icons8_pencil_25;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.Location = new System.Drawing.Point(241, 84);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(91, 36);
            this.btnSua.TabIndex = 10;
            this.btnSua.Text = "Sửa hộ";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::QuanLyNuoc.Properties.Resources.icons8_trash_25;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.Location = new System.Drawing.Point(143, 84);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(92, 36);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa hộ";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThemHo
            // 
            this.btnThemHo.Image = global::QuanLyNuoc.Properties.Resources.icons8_plus_25;
            this.btnThemHo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThemHo.Location = new System.Drawing.Point(27, 84);
            this.btnThemHo.Name = "btnThemHo";
            this.btnThemHo.Size = new System.Drawing.Size(108, 36);
            this.btnThemHo.TabIndex = 8;
            this.btnThemHo.Text = "Thêm hộ";
            this.btnThemHo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThemHo.UseVisualStyleBackColor = true;
            this.btnThemHo.Click += new System.EventHandler(this.btnThemHo_Click);
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTraCuu.Location = new System.Drawing.Point(676, 92);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(260, 26);
            this.txtTraCuu.TabIndex = 11;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.txtTraCuu_TextChanged);
            this.txtTraCuu.Leave += new System.EventHandler(this.txtTraCuu_Leave);
            // 
            // lblTraCuu
            // 
            this.lblTraCuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTraCuu.AutoSize = true;
            this.lblTraCuu.Location = new System.Drawing.Point(519, 95);
            this.lblTraCuu.Name = "lblTraCuu";
            this.lblTraCuu.Size = new System.Drawing.Size(152, 19);
            this.lblTraCuu.TabIndex = 12;
            this.lblTraCuu.Text = "Tra cứu hộ sử dụng: ";
            // 
            // chkCheckAll
            // 
            this.chkCheckAll.AutoSize = true;
            this.chkCheckAll.Location = new System.Drawing.Point(18, 127);
            this.chkCheckAll.Name = "chkCheckAll";
            this.chkCheckAll.Size = new System.Drawing.Size(90, 23);
            this.chkCheckAll.TabIndex = 13;
            this.chkCheckAll.Text = "Chọn hết";
            this.chkCheckAll.UseVisualStyleBackColor = true;
            this.chkCheckAll.CheckedChanged += new System.EventHandler(this.chkCheckAll_CheckedChanged);
            // 
            // MaHo
            // 
            this.MaHo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaHo.DataPropertyName = "MaHo";
            this.MaHo.HeaderText = "Mã hộ";
            this.MaHo.Name = "MaHo";
            this.MaHo.ReadOnly = true;
            this.MaHo.Width = 77;
            // 
            // TenHo
            // 
            this.TenHo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TenHo.DataPropertyName = "TenHo";
            this.TenHo.HeaderText = "Tên hộ sử dụng";
            this.TenHo.Name = "TenHo";
            this.TenHo.ReadOnly = true;
            // 
            // LoaiHo
            // 
            this.LoaiHo.DataPropertyName = "LoaiHo";
            this.LoaiHo.HeaderText = "Loại hộ";
            this.LoaiHo.Name = "LoaiHo";
            this.LoaiHo.ReadOnly = true;
            // 
            // MaNhanh
            // 
            this.MaNhanh.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MaNhanh.DataPropertyName = "MaNhanh";
            this.MaNhanh.HeaderText = "Mã nhánh";
            this.MaNhanh.Name = "MaNhanh";
            this.MaNhanh.ReadOnly = true;
            this.MaNhanh.Width = 103;
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
            this.ClientSize = new System.Drawing.Size(948, 508);
            this.Controls.Add(this.chkCheckAll);
            this.Controls.Add(this.lblTraCuu);
            this.Controls.Add(this.txtTraCuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThemHo);
            this.Controls.Add(this.dgvHoDan);
            this.Controls.Add(this.chkPhanLoaiHo);
            this.Controls.Add(this.lblLoaiHo);
            this.Controls.Add(this.lblHoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbLoaiHo);
            this.Controls.Add(this.cmbHoc);
            this.Controls.Add(this.cmbNhanh);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmQuanLyHoDan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label lblLoaiHo;
        private System.Windows.Forms.CheckBox chkPhanLoaiHo;
        private System.Windows.Forms.DataGridView dgvHoDan;
        private System.Windows.Forms.Button btnThemHo;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Label lblTraCuu;
        private System.Windows.Forms.CheckBox chkCheckAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNhanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHoc;
    }
}