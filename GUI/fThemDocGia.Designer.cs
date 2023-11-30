namespace GUI
{
    partial class fThemDocGia
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
            this.lblMaDocGia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.dmtNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtmNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtmNgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboLoaiDocGia = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboLoaiDocGia);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtMatKhau);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTenDangNhap);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.dtmNgayHetHan);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.dtmNgayLapThe);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDiaChi);
            this.panel1.Controls.Add(this.dmtNgaySinh);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtHoVaTen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblMaDocGia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(347, 326);
            this.panel1.TabIndex = 0;
            // 
            // lblMaDocGia
            // 
            this.lblMaDocGia.AutoSize = true;
            this.lblMaDocGia.Location = new System.Drawing.Point(89, 42);
            this.lblMaDocGia.Name = "lblMaDocGia";
            this.lblMaDocGia.Size = new System.Drawing.Size(22, 13);
            this.lblMaDocGia.TabIndex = 21;
            this.lblMaDocGia.Text = ".....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã độc giả";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(119, 168);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(197, 20);
            this.txtDiaChi.TabIndex = 27;
            this.txtDiaChi.TextChanged += new System.EventHandler(this.txtDiaChi_TextChanged);
            // 
            // dmtNgaySinh
            // 
            this.dmtNgaySinh.Location = new System.Drawing.Point(119, 142);
            this.dmtNgaySinh.Name = "dmtNgaySinh";
            this.dmtNgaySinh.Size = new System.Drawing.Size(197, 20);
            this.dmtNgaySinh.TabIndex = 26;
            this.dmtNgaySinh.ValueChanged += new System.EventHandler(this.dmtNgaySinh_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Địa chỉ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày sinh";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(119, 64);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(197, 20);
            this.txtHoVaTen.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Họ và tên";
            // 
            // dtmNgayHetHan
            // 
            this.dtmNgayHetHan.Location = new System.Drawing.Point(119, 246);
            this.dtmNgayHetHan.Name = "dtmNgayHetHan";
            this.dtmNgayHetHan.Size = new System.Drawing.Size(197, 20);
            this.dtmNgayHetHan.TabIndex = 33;
            this.dtmNgayHetHan.ValueChanged += new System.EventHandler(this.dtmNgayHetHan_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Ngày hết hạn";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // dtmNgayLapThe
            // 
            this.dtmNgayLapThe.Location = new System.Drawing.Point(119, 220);
            this.dtmNgayLapThe.Name = "dtmNgayLapThe";
            this.dtmNgayLapThe.Size = new System.Drawing.Size(197, 20);
            this.dtmNgayLapThe.TabIndex = 31;
            this.dtmNgayLapThe.ValueChanged += new System.EventHandler(this.dtmNgayLapThe_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Ngày lập thẻ";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 194);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 29;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 201);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Email";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "THÔNG TIN ĐỘC GIẢ";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(160, 281);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(241, 281);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tên đăng nhập";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.Location = new System.Drawing.Point(119, 90);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(197, 20);
            this.txtTenDangNhap.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(24, 123);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 39;
            this.label10.Text = "Mật khẩu";
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(119, 116);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(197, 20);
            this.txtMatKhau.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(137, 42);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 41;
            this.label11.Text = "Loại độc giả";
            // 
            // cboLoaiDocGia
            // 
            this.cboLoaiDocGia.FormattingEnabled = true;
            this.cboLoaiDocGia.Location = new System.Drawing.Point(209, 39);
            this.cboLoaiDocGia.Name = "cboLoaiDocGia";
            this.cboLoaiDocGia.Size = new System.Drawing.Size(107, 21);
            this.cboLoaiDocGia.TabIndex = 42;
            // 
            // fThemDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 350);
            this.Controls.Add(this.panel1);
            this.Name = "fThemDocGia";
            this.Text = "Thêm Độc Giả";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMaDocGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.DateTimePicker dmtNgaySinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmNgayHetHan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtmNgayLapThe;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboLoaiDocGia;
        private System.Windows.Forms.Label label11;
    }
}