namespace GUI
{
    partial class fQuanLyPhieuMuonTra
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
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtmNgayPhaiTra = new System.Windows.Forms.DateTimePicker();
            this.dtmNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.txtMaCuonSach = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNoCu = new System.Windows.Forms.TextBox();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.txtSoPhieuMuonTra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkTinhTrang = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoaLoaiDocGia = new System.Windows.Forms.Button();
            this.btnSuaDocGia = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.btnThemPhieuMuon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "THÔNG TIN PHIẾU MƯỢN TRẢ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtmNgayTra);
            this.groupBox1.Controls.Add(this.dtmNgayPhaiTra);
            this.groupBox1.Controls.Add(this.dtmNgayMuon);
            this.groupBox1.Controls.Add(this.txtMaDocGia);
            this.groupBox1.Controls.Add(this.txtMaCuonSach);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNoCu);
            this.groupBox1.Controls.Add(this.txtTongNo);
            this.groupBox1.Controls.Add(this.txtTienPhat);
            this.groupBox1.Controls.Add(this.txtSoPhieuMuonTra);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.chkTinhTrang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 159);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết phiếu mượn";
            // 
            // dtmNgayTra
            // 
            this.dtmNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayTra.Location = new System.Drawing.Point(487, 41);
            this.dtmNgayTra.Name = "dtmNgayTra";
            this.dtmNgayTra.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayTra.TabIndex = 87;
            // 
            // dtmNgayPhaiTra
            // 
            this.dtmNgayPhaiTra.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayPhaiTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayPhaiTra.Location = new System.Drawing.Point(316, 91);
            this.dtmNgayPhaiTra.Name = "dtmNgayPhaiTra";
            this.dtmNgayPhaiTra.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayPhaiTra.TabIndex = 86;
            // 
            // dtmNgayMuon
            // 
            this.dtmNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayMuon.Location = new System.Drawing.Point(316, 66);
            this.dtmNgayMuon.Name = "dtmNgayMuon";
            this.dtmNgayMuon.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayMuon.TabIndex = 85;
            this.dtmNgayMuon.ValueChanged += new System.EventHandler(this.dtmNgayMuon_ValueChanged);
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaDocGia.Location = new System.Drawing.Point(487, 13);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(91, 20);
            this.txtMaDocGia.TabIndex = 84;
            // 
            // txtMaCuonSach
            // 
            this.txtMaCuonSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaCuonSach.Location = new System.Drawing.Point(316, 39);
            this.txtMaCuonSach.Name = "txtMaCuonSach";
            this.txtMaCuonSach.Size = new System.Drawing.Size(91, 20);
            this.txtMaCuonSach.TabIndex = 83;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(420, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Nợ cũ";
            // 
            // txtNoCu
            // 
            this.txtNoCu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtNoCu.Location = new System.Drawing.Point(487, 91);
            this.txtNoCu.Name = "txtNoCu";
            this.txtNoCu.Size = new System.Drawing.Size(91, 20);
            this.txtNoCu.TabIndex = 81;
            // 
            // txtTongNo
            // 
            this.txtTongNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTongNo.Location = new System.Drawing.Point(487, 117);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.Size = new System.Drawing.Size(91, 20);
            this.txtTongNo.TabIndex = 80;
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTienPhat.Location = new System.Drawing.Point(487, 65);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(91, 20);
            this.txtTienPhat.TabIndex = 79;
            // 
            // txtSoPhieuMuonTra
            // 
            this.txtSoPhieuMuonTra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSoPhieuMuonTra.Location = new System.Drawing.Point(316, 13);
            this.txtSoPhieuMuonTra.Name = "txtSoPhieuMuonTra";
            this.txtSoPhieuMuonTra.Size = new System.Drawing.Size(91, 20);
            this.txtSoPhieuMuonTra.TabIndex = 78;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(420, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Tổng nợ";
            // 
            // chkTinhTrang
            // 
            this.chkTinhTrang.AutoSize = true;
            this.chkTinhTrang.Location = new System.Drawing.Point(316, 118);
            this.chkTinhTrang.Name = "chkTinhTrang";
            this.chkTinhTrang.Size = new System.Drawing.Size(15, 14);
            this.chkTinhTrang.TabIndex = 53;
            this.chkTinhTrang.UseVisualStyleBackColor = true;
            this.chkTinhTrang.CheckedChanged += new System.EventHandler(this.chkTinhTrang_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(211, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Đã trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ngày trả";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(211, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Ngày phải trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tiền phạt";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(420, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số phiếu mượn trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(211, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã cuốn sách";
            // 
            // btnXoaLoaiDocGia
            // 
            this.btnXoaLoaiDocGia.Location = new System.Drawing.Point(704, 198);
            this.btnXoaLoaiDocGia.Name = "btnXoaLoaiDocGia";
            this.btnXoaLoaiDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLoaiDocGia.TabIndex = 17;
            this.btnXoaLoaiDocGia.Text = "Xoá";
            this.btnXoaLoaiDocGia.UseVisualStyleBackColor = true;
            this.btnXoaLoaiDocGia.Click += new System.EventHandler(this.btnXoaLoaiDocGia_Click);
            // 
            // btnSuaDocGia
            // 
            this.btnSuaDocGia.Location = new System.Drawing.Point(623, 198);
            this.btnSuaDocGia.Name = "btnSuaDocGia";
            this.btnSuaDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDocGia.TabIndex = 6;
            this.btnSuaDocGia.Text = "Sửa";
            this.btnSuaDocGia.UseVisualStyleBackColor = true;
            this.btnSuaDocGia.Click += new System.EventHandler(this.btnSuaDocGia_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.dgvPhieuMuon);
            this.groupBox12.Location = new System.Drawing.Point(3, 228);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(776, 246);
            this.groupBox12.TabIndex = 29;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Thông tin chung phiếu mượn";
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(6, 19);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.Size = new System.Drawing.Size(763, 221);
            this.dgvPhieuMuon.TabIndex = 0;
            this.dgvPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellContentClick);
            // 
            // btnThemPhieuMuon
            // 
            this.btnThemPhieuMuon.Location = new System.Drawing.Point(3, 198);
            this.btnThemPhieuMuon.Name = "btnThemPhieuMuon";
            this.btnThemPhieuMuon.Size = new System.Drawing.Size(104, 24);
            this.btnThemPhieuMuon.TabIndex = 31;
            this.btnThemPhieuMuon.Text = "Thêm phiếu mượn";
            this.btnThemPhieuMuon.UseVisualStyleBackColor = true;
            this.btnThemPhieuMuon.Click += new System.EventHandler(this.btnThemPhieuMuon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemPhieuMuon);
            this.panel1.Controls.Add(this.groupBox12);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnXoaLoaiDocGia);
            this.panel1.Controls.Add(this.btnSuaDocGia);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 480);
            this.panel1.TabIndex = 0;
            // 
            // fQuanLyPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 503);
            this.Controls.Add(this.panel1);
            this.Name = "fQuanLyPhieuMuonTra";
            this.Text = "Phiếu Mượn Trả";
            this.Load += new System.EventHandler(this.fPhieuMuonTra_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkTinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoaLoaiDocGia;
        private System.Windows.Forms.Button btnSuaDocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.Button btnThemPhieuMuon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNoCu;
        private System.Windows.Forms.TextBox txtTongNo;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.TextBox txtSoPhieuMuonTra;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.TextBox txtMaCuonSach;
        private System.Windows.Forms.DateTimePicker dtmNgayTra;
        private System.Windows.Forms.DateTimePicker dtmNgayPhaiTra;
        private System.Windows.Forms.DateTimePicker dtmNgayMuon;
    }
}