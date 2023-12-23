namespace GUI
{
    partial class fQuanLyDocGia
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
            this.tabpgLoaiDocGia = new System.Windows.Forms.TabPage();
            this.btnXoaLoaiDocGia = new System.Windows.Forms.Button();
            this.btnSuaLoaiDocGia = new System.Windows.Forms.Button();
            this.btnThemLoaiDocGia = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiDocGia = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMaLoaiDocGia = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenLoaiDocGia = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tabpgDocGia = new System.Windows.Forms.TabPage();
            this.btnXoaDocGia = new System.Windows.Forms.Button();
            this.btnSuaDocGia = new System.Windows.Forms.Button();
            this.btnThemDocGia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvDocGia = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboLoaiDocGia = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtmNgayLapThe = new System.Windows.Forms.DateTimePicker();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.dtmNgayHetHan = new System.Windows.Forms.DateTimePicker();
            this.dtmNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHoVaTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabQuanLyDocGia = new System.Windows.Forms.TabControl();
            this.tabpgLoaiDocGia.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDocGia)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabpgDocGia.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabQuanLyDocGia.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpgLoaiDocGia
            // 
            this.tabpgLoaiDocGia.Controls.Add(this.btnXoaLoaiDocGia);
            this.tabpgLoaiDocGia.Controls.Add(this.btnSuaLoaiDocGia);
            this.tabpgLoaiDocGia.Controls.Add(this.btnThemLoaiDocGia);
            this.tabpgLoaiDocGia.Controls.Add(this.groupBox4);
            this.tabpgLoaiDocGia.Controls.Add(this.label10);
            this.tabpgLoaiDocGia.Controls.Add(this.groupBox5);
            this.tabpgLoaiDocGia.Location = new System.Drawing.Point(4, 22);
            this.tabpgLoaiDocGia.Name = "tabpgLoaiDocGia";
            this.tabpgLoaiDocGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgLoaiDocGia.Size = new System.Drawing.Size(796, 460);
            this.tabpgLoaiDocGia.TabIndex = 2;
            this.tabpgLoaiDocGia.Text = "Loại độc giả";
            this.tabpgLoaiDocGia.UseVisualStyleBackColor = true;
            this.tabpgLoaiDocGia.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // btnXoaLoaiDocGia
            // 
            this.btnXoaLoaiDocGia.Location = new System.Drawing.Point(704, 175);
            this.btnXoaLoaiDocGia.Name = "btnXoaLoaiDocGia";
            this.btnXoaLoaiDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLoaiDocGia.TabIndex = 25;
            this.btnXoaLoaiDocGia.Text = "Xoá";
            this.btnXoaLoaiDocGia.UseVisualStyleBackColor = true;
            this.btnXoaLoaiDocGia.Click += new System.EventHandler(this.btnXoaLoaiDocGia_Click);
            // 
            // btnSuaLoaiDocGia
            // 
            this.btnSuaLoaiDocGia.Location = new System.Drawing.Point(623, 175);
            this.btnSuaLoaiDocGia.Name = "btnSuaLoaiDocGia";
            this.btnSuaLoaiDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnSuaLoaiDocGia.TabIndex = 24;
            this.btnSuaLoaiDocGia.Text = "Sửa";
            this.btnSuaLoaiDocGia.UseVisualStyleBackColor = true;
            this.btnSuaLoaiDocGia.Click += new System.EventHandler(this.btnSuaLoaiDocGia_Click);
            // 
            // btnThemLoaiDocGia
            // 
            this.btnThemLoaiDocGia.Location = new System.Drawing.Point(10, 175);
            this.btnThemLoaiDocGia.Name = "btnThemLoaiDocGia";
            this.btnThemLoaiDocGia.Size = new System.Drawing.Size(105, 23);
            this.btnThemLoaiDocGia.TabIndex = 23;
            this.btnThemLoaiDocGia.Text = "Thêm loại độc giả";
            this.btnThemLoaiDocGia.UseVisualStyleBackColor = true;
            this.btnThemLoaiDocGia.Click += new System.EventHandler(this.btnThemLoaiDocGia_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvLoaiDocGia);
            this.groupBox4.Location = new System.Drawing.Point(10, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 250);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin tất cả loại độc giả";
            // 
            // dgvLoaiDocGia
            // 
            this.dgvLoaiDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDocGia.Location = new System.Drawing.Point(6, 19);
            this.dgvLoaiDocGia.Name = "dgvLoaiDocGia";
            this.dgvLoaiDocGia.Size = new System.Drawing.Size(763, 225);
            this.dgvLoaiDocGia.TabIndex = 0;
            this.dgvLoaiDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDocGia_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(198, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "CẬP NHẬP THÔNG TIN LOẠI ĐỘC GIẢ";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMaLoaiDocGia);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtTenLoaiDocGia);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(10, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(776, 141);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin chi tiết loại độc giả";
            // 
            // txtMaLoaiDocGia
            // 
            this.txtMaLoaiDocGia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaLoaiDocGia.Location = new System.Drawing.Point(338, 36);
            this.txtMaLoaiDocGia.Name = "txtMaLoaiDocGia";
            this.txtMaLoaiDocGia.Size = new System.Drawing.Size(84, 20);
            this.txtMaLoaiDocGia.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(234, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Mã loại độc giả";
            // 
            // txtTenLoaiDocGia
            // 
            this.txtTenLoaiDocGia.Location = new System.Drawing.Point(338, 65);
            this.txtTenLoaiDocGia.Name = "txtTenLoaiDocGia";
            this.txtTenLoaiDocGia.Size = new System.Drawing.Size(197, 20);
            this.txtTenLoaiDocGia.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(234, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(84, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Tên loại độc giả";
            // 
            // tabpgDocGia
            // 
            this.tabpgDocGia.Controls.Add(this.btnXoaDocGia);
            this.tabpgDocGia.Controls.Add(this.btnSuaDocGia);
            this.tabpgDocGia.Controls.Add(this.btnThemDocGia);
            this.tabpgDocGia.Controls.Add(this.groupBox3);
            this.tabpgDocGia.Controls.Add(this.label6);
            this.tabpgDocGia.Controls.Add(this.groupBox1);
            this.tabpgDocGia.Location = new System.Drawing.Point(4, 22);
            this.tabpgDocGia.Name = "tabpgDocGia";
            this.tabpgDocGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgDocGia.Size = new System.Drawing.Size(796, 460);
            this.tabpgDocGia.TabIndex = 0;
            this.tabpgDocGia.Text = "Độc giả";
            this.tabpgDocGia.UseVisualStyleBackColor = true;
            this.tabpgDocGia.Click += new System.EventHandler(this.tabpgDocGia_Click);
            // 
            // btnXoaDocGia
            // 
            this.btnXoaDocGia.Location = new System.Drawing.Point(711, 175);
            this.btnXoaDocGia.Name = "btnXoaDocGia";
            this.btnXoaDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnXoaDocGia.TabIndex = 27;
            this.btnXoaDocGia.Text = "Xoá";
            this.btnXoaDocGia.UseVisualStyleBackColor = true;
            this.btnXoaDocGia.Click += new System.EventHandler(this.btnXoaDocGia_Click);
            // 
            // btnSuaDocGia
            // 
            this.btnSuaDocGia.Location = new System.Drawing.Point(630, 175);
            this.btnSuaDocGia.Name = "btnSuaDocGia";
            this.btnSuaDocGia.Size = new System.Drawing.Size(75, 23);
            this.btnSuaDocGia.TabIndex = 26;
            this.btnSuaDocGia.Text = "Sửa";
            this.btnSuaDocGia.UseVisualStyleBackColor = true;
            this.btnSuaDocGia.Click += new System.EventHandler(this.btnSuaDocGia_Click);
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.Location = new System.Drawing.Point(16, 174);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(92, 23);
            this.btnThemDocGia.TabIndex = 22;
            this.btnThemDocGia.Text = "Thêm độc giả";
            this.btnThemDocGia.UseVisualStyleBackColor = true;
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvDocGia);
            this.groupBox3.Location = new System.Drawing.Point(10, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 251);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tất cả độc giả";
            // 
            // dgvDocGia
            // 
            this.dgvDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocGia.Location = new System.Drawing.Point(6, 19);
            this.dgvDocGia.Name = "dgvDocGia";
            this.dgvDocGia.Size = new System.Drawing.Size(764, 226);
            this.dgvDocGia.TabIndex = 0;
            this.dgvDocGia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDocGia_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "CẬP NHẬP THÔNG TIN ĐỘC GIẢ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboLoaiDocGia);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtmNgayLapThe);
            this.groupBox1.Controls.Add(this.txtMaDocGia);
            this.groupBox1.Controls.Add(this.dtmNgayHetHan);
            this.groupBox1.Controls.Add(this.dtmNgaySinh);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHoVaTen);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết độc giả";
            // 
            // cboLoaiDocGia
            // 
            this.cboLoaiDocGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboLoaiDocGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboLoaiDocGia.FormattingEnabled = true;
            this.cboLoaiDocGia.Location = new System.Drawing.Point(464, 21);
            this.cboLoaiDocGia.Name = "cboLoaiDocGia";
            this.cboLoaiDocGia.Size = new System.Drawing.Size(121, 21);
            this.cboLoaiDocGia.TabIndex = 55;
            this.cboLoaiDocGia.SelectedIndexChanged += new System.EventHandler(this.cboLoaiDocGia_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Loại độc giả";
            // 
            // dtmNgayLapThe
            // 
            this.dtmNgayLapThe.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayLapThe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayLapThe.Location = new System.Drawing.Point(464, 80);
            this.dtmNgayLapThe.Name = "dtmNgayLapThe";
            this.dtmNgayLapThe.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayLapThe.TabIndex = 52;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaDocGia.Location = new System.Drawing.Point(159, 26);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(84, 20);
            this.txtMaDocGia.TabIndex = 51;
            // 
            // dtmNgayHetHan
            // 
            this.dtmNgayHetHan.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayHetHan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayHetHan.Location = new System.Drawing.Point(464, 106);
            this.dtmNgayHetHan.Name = "dtmNgayHetHan";
            this.dtmNgayHetHan.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayHetHan.TabIndex = 50;
            // 
            // dtmNgaySinh
            // 
            this.dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtmNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgaySinh.Location = new System.Drawing.Point(159, 80);
            this.dtmNgaySinh.Name = "dtmNgaySinh";
            this.dtmNgaySinh.Size = new System.Drawing.Size(91, 20);
            this.dtmNgaySinh.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã độc giả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(387, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ngày hết hạn";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Ngày lập thẻ";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(464, 51);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(197, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Email";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(159, 106);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(197, 20);
            this.txtDiaChi.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày sinh";
            // 
            // txtHoVaTen
            // 
            this.txtHoVaTen.Location = new System.Drawing.Point(159, 52);
            this.txtHoVaTen.Name = "txtHoVaTen";
            this.txtHoVaTen.Size = new System.Drawing.Size(197, 20);
            this.txtHoVaTen.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Họ và tên";
            // 
            // tabQuanLyDocGia
            // 
            this.tabQuanLyDocGia.Controls.Add(this.tabpgDocGia);
            this.tabQuanLyDocGia.Controls.Add(this.tabpgLoaiDocGia);
            this.tabQuanLyDocGia.Location = new System.Drawing.Point(12, 12);
            this.tabQuanLyDocGia.Name = "tabQuanLyDocGia";
            this.tabQuanLyDocGia.SelectedIndex = 0;
            this.tabQuanLyDocGia.Size = new System.Drawing.Size(804, 486);
            this.tabQuanLyDocGia.TabIndex = 6;
            // 
            // fQuanLyDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 508);
            this.Controls.Add(this.tabQuanLyDocGia);
            this.Name = "fQuanLyDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Độc Giả";
            this.Load += new System.EventHandler(this.fQuanLyDocGia_Load);
            this.tabpgLoaiDocGia.ResumeLayout(false);
            this.tabpgLoaiDocGia.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDocGia)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabpgDocGia.ResumeLayout(false);
            this.tabpgDocGia.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocGia)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabQuanLyDocGia.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabpgLoaiDocGia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvLoaiDocGia;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenLoaiDocGia;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabpgDocGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvDocGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmNgayHetHan;
        private System.Windows.Forms.DateTimePicker dtmNgaySinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoVaTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabQuanLyDocGia;
        private System.Windows.Forms.Button btnThemLoaiDocGia;
        private System.Windows.Forms.Button btnThemDocGia;
        private System.Windows.Forms.TextBox txtMaLoaiDocGia;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.DateTimePicker dtmNgayLapThe;
        private System.Windows.Forms.Button btnSuaLoaiDocGia;
        private System.Windows.Forms.Button btnXoaLoaiDocGia;
        private System.Windows.Forms.Button btnXoaDocGia;
        private System.Windows.Forms.Button btnSuaDocGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoaiDocGia;
    }
}