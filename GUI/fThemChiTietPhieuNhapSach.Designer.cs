﻿namespace GUI
{
    partial class fThemChiTietPhieuNhapSach
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoPhieuNhap = new System.Windows.Forms.TextBox();
            this.dtmNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvDSSachNhap = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.domSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.btnXoaSachNhap = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.btnThemSachNhap = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSachNhap)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtSoPhieuNhap);
            this.panel1.Controls.Add(this.dtmNgayLap);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtTongTien);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 285);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(209, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Ngày lập";
            // 
            // txtSoPhieuNhap
            // 
            this.txtSoPhieuNhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSoPhieuNhap.Location = new System.Drawing.Point(107, 29);
            this.txtSoPhieuNhap.Name = "txtSoPhieuNhap";
            this.txtSoPhieuNhap.Size = new System.Drawing.Size(84, 20);
            this.txtSoPhieuNhap.TabIndex = 85;
            // 
            // dtmNgayLap
            // 
            this.dtmNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayLap.Location = new System.Drawing.Point(264, 29);
            this.dtmNgayLap.Name = "dtmNgayLap";
            this.dtmNgayLap.Size = new System.Drawing.Size(80, 20);
            this.dtmNgayLap.TabIndex = 96;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(495, 259);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 6;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(414, 259);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTongTien.Location = new System.Drawing.Point(469, 29);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(84, 20);
            this.txtTongTien.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(411, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Tổng tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvDSSachNhap);
            this.groupBox2.Location = new System.Drawing.Point(212, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(364, 192);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sách Nhập";
            // 
            // dgvDSSachNhap
            // 
            this.dgvDSSachNhap.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDSSachNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSachNhap.Location = new System.Drawing.Point(6, 19);
            this.dgvDSSachNhap.Name = "dgvDSSachNhap";
            this.dgvDSSachNhap.Size = new System.Drawing.Size(352, 167);
            this.dgvDSSachNhap.TabIndex = 60;
            this.dgvDSSachNhap.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSachNhap_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.domSoLuong);
            this.groupBox1.Controls.Add(this.txtTenSach);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboMaSach);
            this.groupBox1.Controls.Add(this.txtThanhTien);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.btnXoaSachNhap);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.btnThemSachNhap);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Location = new System.Drawing.Point(3, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 192);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách Nhập";
            // 
            // domSoLuong
            // 
            this.domSoLuong.Location = new System.Drawing.Point(143, 102);
            this.domSoLuong.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.domSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.domSoLuong.Name = "domSoLuong";
            this.domSoLuong.Size = new System.Drawing.Size(54, 20);
            this.domSoLuong.TabIndex = 2;
            this.domSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.domSoLuong.ValueChanged += new System.EventHandler(this.domSoLuong_ValueChanged);
            // 
            // txtTenSach
            // 
            this.txtTenSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTenSach.Location = new System.Drawing.Point(87, 50);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(110, 20);
            this.txtTenSach.TabIndex = 83;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 82;
            this.label2.Text = "Tên sách nhập";
            // 
            // cboMaSach
            // 
            this.cboMaSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(87, 20);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(68, 21);
            this.cboMaSach.TabIndex = 0;
            this.cboMaSach.SelectedIndexChanged += new System.EventHandler(this.cboMaSach_SelectedIndexChanged);
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtThanhTien.Location = new System.Drawing.Point(87, 128);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(110, 20);
            this.txtThanhTien.TabIndex = 70;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 13);
            this.label26.TabIndex = 62;
            this.label26.Text = "Mã sách nhập";
            // 
            // btnXoaSachNhap
            // 
            this.btnXoaSachNhap.Location = new System.Drawing.Point(104, 155);
            this.btnXoaSachNhap.Name = "btnXoaSachNhap";
            this.btnXoaSachNhap.Size = new System.Drawing.Size(97, 23);
            this.btnXoaSachNhap.TabIndex = 4;
            this.btnXoaSachNhap.Text = "Xoá sách nhập";
            this.btnXoaSachNhap.UseVisualStyleBackColor = true;
            this.btnXoaSachNhap.Click += new System.EventHandler(this.btnXoaSachNhap_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(6, 109);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 13);
            this.label25.TabIndex = 63;
            this.label25.Text = "Số lượng nhập";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 83);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 66;
            this.label28.Text = "Đơn giá";
            // 
            // btnThemSachNhap
            // 
            this.btnThemSachNhap.Location = new System.Drawing.Point(0, 155);
            this.btnThemSachNhap.Name = "btnThemSachNhap";
            this.btnThemSachNhap.Size = new System.Drawing.Size(98, 23);
            this.btnThemSachNhap.TabIndex = 3;
            this.btnThemSachNhap.Text = "Thêm sách nhập";
            this.btnThemSachNhap.UseVisualStyleBackColor = true;
            this.btnThemSachNhap.Click += new System.EventHandler(this.btnThemSachNhap_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtDonGia.Location = new System.Drawing.Point(87, 76);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(110, 20);
            this.txtDonGia.TabIndex = 1;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 135);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "Thành tiền";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(25, 32);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 13);
            this.label32.TabIndex = 54;
            this.label32.Text = "Số phiếu nhâp";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(181, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(242, 15);
            this.label23.TabIndex = 25;
            this.label23.Text = "THÔNG TIN CHI TIẾT PHIẾU NHẬP SÁCH";
            // 
            // fThemChiTietPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 309);
            this.Controls.Add(this.panel1);
            this.Name = "fThemChiTietPhieuNhapSach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Chi Tiết Phiếu Nhập Sách";
            this.Load += new System.EventHandler(this.fThemChiTietPhieuNhapSach_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSachNhap)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.domSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dgvDSSachNhap;
        private System.Windows.Forms.Button btnXoaSachNhap;
        private System.Windows.Forms.Button btnThemSachNhap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSoPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmNgayLap;
        private System.Windows.Forms.NumericUpDown domSoLuong;
    }
}