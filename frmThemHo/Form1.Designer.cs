namespace frmThemHo
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên hộ: ";
            // 
            // txtTenHo
            // 
            this.txtTenHo.Location = new System.Drawing.Point(102, 98);
            this.txtTenHo.Name = "txtTenHo";
            this.txtTenHo.Size = new System.Drawing.Size(272, 26);
            this.txtTenHo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại hộ";
            // 
            // cmbLoaiHo
            // 
            this.cmbLoaiHo.FormattingEnabled = true;
            this.cmbLoaiHo.Location = new System.Drawing.Point(102, 149);
            this.cmbLoaiHo.Name = "cmbLoaiHo";
            this.cmbLoaiHo.Size = new System.Drawing.Size(272, 27);
            this.cmbLoaiHo.TabIndex = 3;
            // 
            // frmThemHo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 336);
            this.Controls.Add(this.cmbLoaiHo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenHo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmThemHo";
            this.Text = "Thêm hộ sử dụng";
            this.Load += new System.EventHandler(this.frmThemHo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenHo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbLoaiHo;
    }
}

