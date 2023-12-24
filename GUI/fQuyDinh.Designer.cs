namespace GUI
{
    partial class fQuyDinh
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkApDungQDTienThu = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.domThoiHanTheDocGia = new System.Windows.Forms.NumericUpDown();
            this.domTuoiToiDa = new System.Windows.Forms.NumericUpDown();
            this.domTuoiToiThieu = new System.Windows.Forms.NumericUpDown();
            this.domSoNgayMuonToiDa = new System.Windows.Forms.NumericUpDown();
            this.domSoSachMuonToiDa = new System.Windows.Forms.NumericUpDown();
            this.domSoTienPhatTraTre = new System.Windows.Forms.NumericUpDown();
            this.domKhoangCachNamXuatBan = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domThoiHanTheDocGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domTuoiToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domTuoiToiThieu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domSoNgayMuonToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domSoSachMuonToiDa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domSoTienPhatTraTre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domKhoangCachNamXuatBan)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.domTuoiToiThieu);
            this.groupBox1.Controls.Add(this.domTuoiToiDa);
            this.groupBox1.Controls.Add(this.domThoiHanTheDocGia);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 104);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quy Định Độc Giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Tuổi tối đa của độc giả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Tuổi tối thiểu của độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Thời hạn thẻ độc giả";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(82, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "THÔNG TIN QUY ĐỊNH";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 325);
            this.panel1.TabIndex = 25;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(176, 292);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 23);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(103, 292);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 23);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.domKhoangCachNamXuatBan);
            this.groupBox2.Controls.Add(this.domSoTienPhatTraTre);
            this.groupBox2.Controls.Add(this.domSoSachMuonToiDa);
            this.groupBox2.Controls.Add(this.domSoNgayMuonToiDa);
            this.groupBox2.Controls.Add(this.chkApDungQDTienThu);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(263, 148);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quy Định Mượn Trả  Và Nhập Sách";
            // 
            // chkApDungQDTienThu
            // 
            this.chkApDungQDTienThu.AutoSize = true;
            this.chkApDungQDTienThu.Location = new System.Drawing.Point(196, 124);
            this.chkApDungQDTienThu.Name = "chkApDungQDTienThu";
            this.chkApDungQDTienThu.Size = new System.Drawing.Size(15, 14);
            this.chkApDungQDTienThu.TabIndex = 36;
            this.chkApDungQDTienThu.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 13);
            this.label8.TabIndex = 32;
            this.label8.Text = "Số tiền phạt trả trễ trên ngày";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Số tiền thu không vượt quá tiền nợ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Khoảng cách năm xuất bản tối đa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Số sách mượn tối đa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số ngày mượn tối đa";
            // 
            // domThoiHanTheDocGia
            // 
            this.domThoiHanTheDocGia.Location = new System.Drawing.Point(194, 23);
            this.domThoiHanTheDocGia.Name = "domThoiHanTheDocGia";
            this.domThoiHanTheDocGia.Size = new System.Drawing.Size(57, 20);
            this.domThoiHanTheDocGia.TabIndex = 32;
            // 
            // domTuoiToiDa
            // 
            this.domTuoiToiDa.Location = new System.Drawing.Point(194, 49);
            this.domTuoiToiDa.Name = "domTuoiToiDa";
            this.domTuoiToiDa.Size = new System.Drawing.Size(57, 20);
            this.domTuoiToiDa.TabIndex = 33;
            // 
            // domTuoiToiThieu
            // 
            this.domTuoiToiThieu.Location = new System.Drawing.Point(194, 75);
            this.domTuoiToiThieu.Name = "domTuoiToiThieu";
            this.domTuoiToiThieu.Size = new System.Drawing.Size(57, 20);
            this.domTuoiToiThieu.TabIndex = 34;
            // 
            // domSoNgayMuonToiDa
            // 
            this.domSoNgayMuonToiDa.Location = new System.Drawing.Point(194, 19);
            this.domSoNgayMuonToiDa.Name = "domSoNgayMuonToiDa";
            this.domSoNgayMuonToiDa.Size = new System.Drawing.Size(57, 20);
            this.domSoNgayMuonToiDa.TabIndex = 35;
            // 
            // domSoSachMuonToiDa
            // 
            this.domSoSachMuonToiDa.Location = new System.Drawing.Point(194, 45);
            this.domSoSachMuonToiDa.Name = "domSoSachMuonToiDa";
            this.domSoSachMuonToiDa.Size = new System.Drawing.Size(57, 20);
            this.domSoSachMuonToiDa.TabIndex = 38;
            // 
            // domSoTienPhatTraTre
            // 
            this.domSoTienPhatTraTre.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.domSoTienPhatTraTre.Location = new System.Drawing.Point(194, 71);
            this.domSoTienPhatTraTre.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.domSoTienPhatTraTre.Name = "domSoTienPhatTraTre";
            this.domSoTienPhatTraTre.Size = new System.Drawing.Size(57, 20);
            this.domSoTienPhatTraTre.TabIndex = 39;
            // 
            // domKhoangCachNamXuatBan
            // 
            this.domKhoangCachNamXuatBan.Location = new System.Drawing.Point(194, 97);
            this.domKhoangCachNamXuatBan.Name = "domKhoangCachNamXuatBan";
            this.domKhoangCachNamXuatBan.Size = new System.Drawing.Size(57, 20);
            this.domKhoangCachNamXuatBan.TabIndex = 40;
            // 
            // fQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 347);
            this.Controls.Add(this.panel1);
            this.Name = "fQuyDinh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quy Định";
            this.Load += new System.EventHandler(this.fQuyDinh_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domThoiHanTheDocGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domTuoiToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domTuoiToiThieu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domSoNgayMuonToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domSoSachMuonToiDa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domSoTienPhatTraTre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domKhoangCachNamXuatBan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkApDungQDTienThu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.NumericUpDown domThoiHanTheDocGia;
        private System.Windows.Forms.NumericUpDown domTuoiToiDa;
        private System.Windows.Forms.NumericUpDown domTuoiToiThieu;
        private System.Windows.Forms.NumericUpDown domSoSachMuonToiDa;
        private System.Windows.Forms.NumericUpDown domSoNgayMuonToiDa;
        private System.Windows.Forms.NumericUpDown domKhoangCachNamXuatBan;
        private System.Windows.Forms.NumericUpDown domSoTienPhatTraTre;
    }
}