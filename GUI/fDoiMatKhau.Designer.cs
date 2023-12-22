namespace GUI
{
    partial class fDoiMatKhau
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtMatKhauHienTai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMatKhauMoi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhapLaiMatKhau = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.chkHienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chkHienThiMatKhau);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtNhapLaiMatKhau);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtMatKhauMoi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMatKhauHienTai);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 141);
            this.panel1.TabIndex = 0;
            // 
            // txtMatKhauHienTai
            // 
            this.txtMatKhauHienTai.Location = new System.Drawing.Point(100, 10);
            this.txtMatKhauHienTai.Name = "txtMatKhauHienTai";
            this.txtMatKhauHienTai.Size = new System.Drawing.Size(108, 20);
            this.txtMatKhauHienTai.TabIndex = 36;
            this.txtMatKhauHienTai.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "Mật khẩu hiện tại";
            // 
            // txtMatKhauMoi
            // 
            this.txtMatKhauMoi.Location = new System.Drawing.Point(100, 36);
            this.txtMatKhauMoi.Name = "txtMatKhauMoi";
            this.txtMatKhauMoi.Size = new System.Drawing.Size(108, 20);
            this.txtMatKhauMoi.TabIndex = 38;
            this.txtMatKhauMoi.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mật khẩu mới";
            // 
            // txtNhapLaiMatKhau
            // 
            this.txtNhapLaiMatKhau.Location = new System.Drawing.Point(100, 62);
            this.txtNhapLaiMatKhau.Name = "txtNhapLaiMatKhau";
            this.txtNhapLaiMatKhau.Size = new System.Drawing.Size(108, 20);
            this.txtNhapLaiMatKhau.TabIndex = 40;
            this.txtNhapLaiMatKhau.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Nhập lại mật khẩu";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(82, 9);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(85, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "ĐỔI MẬT KHẨU";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(141, 115);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 23);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Thoát";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(68, 115);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 23);
            this.btnLuu.TabIndex = 42;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // chkHienThiMatKhau
            // 
            this.chkHienThiMatKhau.AutoSize = true;
            this.chkHienThiMatKhau.Location = new System.Drawing.Point(99, 92);
            this.chkHienThiMatKhau.Name = "chkHienThiMatKhau";
            this.chkHienThiMatKhau.Size = new System.Drawing.Size(109, 17);
            this.chkHienThiMatKhau.TabIndex = 44;
            this.chkHienThiMatKhau.Text = "Hiển thị mật khẩu";
            this.chkHienThiMatKhau.UseVisualStyleBackColor = true;
            this.chkHienThiMatKhau.CheckedChanged += new System.EventHandler(this.chkHienThiMatKhau_CheckedChanged);
            // 
            // fDoiMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(248, 178);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.panel1);
            this.Name = "fDoiMatKhau";
            this.Text = "Đổi Mật Khẩu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNhapLaiMatKhau;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMatKhauMoi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatKhauHienTai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.CheckBox chkHienThiMatKhau;
    }
}