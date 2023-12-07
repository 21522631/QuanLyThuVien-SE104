namespace GUI
{
    partial class fThemPhieuNhapSach
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
            this.label23 = new System.Windows.Forms.Label();
            this.dtmNgayLap = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(42, 9);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(168, 13);
            this.label23.TabIndex = 26;
            this.label23.Text = "THÔNG TIN PHIẾU NHẬP SÁCH";
            // 
            // dtmNgayLap
            // 
            this.dtmNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayLap.Location = new System.Drawing.Point(108, 37);
            this.dtmNgayLap.Name = "dtmNgayLap";
            this.dtmNgayLap.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayLap.TabIndex = 51;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(53, 44);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 52;
            this.label32.Text = "Ngày lập";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(164, 72);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 54;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(83, 72);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 53;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // fThemPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 108);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.dtmNgayLap);
            this.Controls.Add(this.label23);
            this.Name = "fThemPhieuNhapSach";
            this.Text = "Thêm Phiếu Nhập Sách";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dtmNgayLap;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}