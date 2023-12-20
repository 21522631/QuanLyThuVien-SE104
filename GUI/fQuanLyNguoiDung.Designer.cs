namespace GUI
{
    partial class fQuanLyNguoiDung
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
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.tabQuanNguoiDung = new System.Windows.Forms.TabControl();
            this.tabpgNguoiDung = new System.Windows.Forms.TabPage();
            this.btnXoaNguoiDung = new System.Windows.Forms.Button();
            this.btnNguoiDung = new System.Windows.Forms.Button();
            this.btnThemDocGia = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTenDangNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNhomNguoiDung = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaNguoiDung = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTenNguoiDung = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabpgNhomNguoiDung = new System.Windows.Forms.TabPage();
            this.btnXoaNhomNguoiDung = new System.Windows.Forms.Button();
            this.btnSuaNhomNguoiDung = new System.Windows.Forms.Button();
            this.btnThemNhomNguoiDung = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvNhomNguoiDung = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtMaNhomNguoiDung = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTenNhomNguoiDung = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.tabQuanNguoiDung.SuspendLayout();
            this.tabpgNguoiDung.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabpgNhomNguoiDung.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomNguoiDung)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "CẬP NHẬP THÔNG TIN NGƯỜI DÙNG";
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDung.Location = new System.Drawing.Point(6, 19);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.Size = new System.Drawing.Size(764, 226);
            this.dgvNguoiDung.TabIndex = 0;
            this.dgvNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiDung_CellContentClick);
            // 
            // tabQuanNguoiDung
            // 
            this.tabQuanNguoiDung.Controls.Add(this.tabpgNguoiDung);
            this.tabQuanNguoiDung.Controls.Add(this.tabpgNhomNguoiDung);
            this.tabQuanNguoiDung.Location = new System.Drawing.Point(12, 12);
            this.tabQuanNguoiDung.Name = "tabQuanNguoiDung";
            this.tabQuanNguoiDung.SelectedIndex = 0;
            this.tabQuanNguoiDung.Size = new System.Drawing.Size(804, 489);
            this.tabQuanNguoiDung.TabIndex = 7;
            // 
            // tabpgNguoiDung
            // 
            this.tabpgNguoiDung.Controls.Add(this.btnXoaNguoiDung);
            this.tabpgNguoiDung.Controls.Add(this.btnNguoiDung);
            this.tabpgNguoiDung.Controls.Add(this.btnThemDocGia);
            this.tabpgNguoiDung.Controls.Add(this.groupBox3);
            this.tabpgNguoiDung.Controls.Add(this.label6);
            this.tabpgNguoiDung.Controls.Add(this.groupBox1);
            this.tabpgNguoiDung.Location = new System.Drawing.Point(4, 22);
            this.tabpgNguoiDung.Name = "tabpgNguoiDung";
            this.tabpgNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgNguoiDung.Size = new System.Drawing.Size(796, 463);
            this.tabpgNguoiDung.TabIndex = 0;
            this.tabpgNguoiDung.Text = "Người dùng";
            this.tabpgNguoiDung.UseVisualStyleBackColor = true;
            // 
            // btnXoaNguoiDung
            // 
            this.btnXoaNguoiDung.Location = new System.Drawing.Point(711, 175);
            this.btnXoaNguoiDung.Name = "btnXoaNguoiDung";
            this.btnXoaNguoiDung.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNguoiDung.TabIndex = 27;
            this.btnXoaNguoiDung.Text = "Xoá";
            this.btnXoaNguoiDung.UseVisualStyleBackColor = true;
            this.btnXoaNguoiDung.Click += new System.EventHandler(this.btnXoaNguoiDung_Click);
            // 
            // btnNguoiDung
            // 
            this.btnNguoiDung.Location = new System.Drawing.Point(630, 175);
            this.btnNguoiDung.Name = "btnNguoiDung";
            this.btnNguoiDung.Size = new System.Drawing.Size(75, 23);
            this.btnNguoiDung.TabIndex = 26;
            this.btnNguoiDung.Text = "Sửa";
            this.btnNguoiDung.UseVisualStyleBackColor = true;
            this.btnNguoiDung.Click += new System.EventHandler(this.btnSuaNguoiDung_Click);
            // 
            // btnThemDocGia
            // 
            this.btnThemDocGia.Location = new System.Drawing.Point(16, 174);
            this.btnThemDocGia.Name = "btnThemDocGia";
            this.btnThemDocGia.Size = new System.Drawing.Size(103, 23);
            this.btnThemDocGia.TabIndex = 22;
            this.btnThemDocGia.Text = " Thêm người dùng";
            this.btnThemDocGia.UseVisualStyleBackColor = true;
            this.btnThemDocGia.Click += new System.EventHandler(this.btnThemDocGia_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvNguoiDung);
            this.groupBox3.Location = new System.Drawing.Point(10, 203);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 251);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin tất cả người dùng";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTenDangNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboNhomNguoiDung);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtMaNguoiDung);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtTenNguoiDung);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(10, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 141);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết người dùng";
            // 
            // txtTenDangNhap
            // 
            this.txtTenDangNhap.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTenDangNhap.Location = new System.Drawing.Point(363, 74);
            this.txtTenDangNhap.Name = "txtTenDangNhap";
            this.txtTenDangNhap.Size = new System.Drawing.Size(197, 20);
            this.txtTenDangNhap.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Tên đăng nhập";
            // 
            // cboNhomNguoiDung
            // 
            this.cboNhomNguoiDung.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboNhomNguoiDung.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboNhomNguoiDung.FormattingEnabled = true;
            this.cboNhomNguoiDung.Location = new System.Drawing.Point(363, 100);
            this.cboNhomNguoiDung.Name = "cboNhomNguoiDung";
            this.cboNhomNguoiDung.Size = new System.Drawing.Size(121, 21);
            this.cboNhomNguoiDung.TabIndex = 55;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Nhóm người dùng";
            // 
            // txtMaNguoiDung
            // 
            this.txtMaNguoiDung.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaNguoiDung.Location = new System.Drawing.Point(363, 22);
            this.txtMaNguoiDung.Name = "txtMaNguoiDung";
            this.txtMaNguoiDung.Size = new System.Drawing.Size(84, 20);
            this.txtMaNguoiDung.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(263, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Mã người dùng";
            // 
            // txtTenNguoiDung
            // 
            this.txtTenNguoiDung.Location = new System.Drawing.Point(363, 48);
            this.txtTenNguoiDung.Name = "txtTenNguoiDung";
            this.txtTenNguoiDung.Size = new System.Drawing.Size(197, 20);
            this.txtTenNguoiDung.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(263, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên người dùng";
            // 
            // tabpgNhomNguoiDung
            // 
            this.tabpgNhomNguoiDung.Controls.Add(this.btnXoaNhomNguoiDung);
            this.tabpgNhomNguoiDung.Controls.Add(this.btnSuaNhomNguoiDung);
            this.tabpgNhomNguoiDung.Controls.Add(this.btnThemNhomNguoiDung);
            this.tabpgNhomNguoiDung.Controls.Add(this.groupBox4);
            this.tabpgNhomNguoiDung.Controls.Add(this.label10);
            this.tabpgNhomNguoiDung.Controls.Add(this.groupBox5);
            this.tabpgNhomNguoiDung.Location = new System.Drawing.Point(4, 22);
            this.tabpgNhomNguoiDung.Name = "tabpgNhomNguoiDung";
            this.tabpgNhomNguoiDung.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgNhomNguoiDung.Size = new System.Drawing.Size(796, 463);
            this.tabpgNhomNguoiDung.TabIndex = 2;
            this.tabpgNhomNguoiDung.Text = "Nhóm người dùng";
            this.tabpgNhomNguoiDung.UseVisualStyleBackColor = true;
            // 
            // btnXoaNhomNguoiDung
            // 
            this.btnXoaNhomNguoiDung.Location = new System.Drawing.Point(704, 175);
            this.btnXoaNhomNguoiDung.Name = "btnXoaNhomNguoiDung";
            this.btnXoaNhomNguoiDung.Size = new System.Drawing.Size(75, 23);
            this.btnXoaNhomNguoiDung.TabIndex = 25;
            this.btnXoaNhomNguoiDung.Text = "Xoá";
            this.btnXoaNhomNguoiDung.UseVisualStyleBackColor = true;
            this.btnXoaNhomNguoiDung.Click += new System.EventHandler(this.btnXoaNhomNguoiDung_Click);
            // 
            // btnSuaNhomNguoiDung
            // 
            this.btnSuaNhomNguoiDung.Location = new System.Drawing.Point(623, 175);
            this.btnSuaNhomNguoiDung.Name = "btnSuaNhomNguoiDung";
            this.btnSuaNhomNguoiDung.Size = new System.Drawing.Size(75, 23);
            this.btnSuaNhomNguoiDung.TabIndex = 24;
            this.btnSuaNhomNguoiDung.Text = "Sửa";
            this.btnSuaNhomNguoiDung.UseVisualStyleBackColor = true;
            this.btnSuaNhomNguoiDung.Click += new System.EventHandler(this.btnSuaNhomNguoiDung_Click);
            // 
            // btnThemNhomNguoiDung
            // 
            this.btnThemNhomNguoiDung.Location = new System.Drawing.Point(10, 175);
            this.btnThemNhomNguoiDung.Name = "btnThemNhomNguoiDung";
            this.btnThemNhomNguoiDung.Size = new System.Drawing.Size(128, 23);
            this.btnThemNhomNguoiDung.TabIndex = 23;
            this.btnThemNhomNguoiDung.Text = "Thêm nhóm người dùng";
            this.btnThemNhomNguoiDung.UseVisualStyleBackColor = true;
            this.btnThemNhomNguoiDung.Click += new System.EventHandler(this.btnThemNhomNguoiDung_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvNhomNguoiDung);
            this.groupBox4.Location = new System.Drawing.Point(10, 204);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 250);
            this.groupBox4.TabIndex = 21;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin tất cả nhóm người dùng";
            // 
            // dgvNhomNguoiDung
            // 
            this.dgvNhomNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNhomNguoiDung.Location = new System.Drawing.Point(6, 19);
            this.dgvNhomNguoiDung.Name = "dgvNhomNguoiDung";
            this.dgvNhomNguoiDung.Size = new System.Drawing.Size(763, 225);
            this.dgvNhomNguoiDung.TabIndex = 0;
            this.dgvNhomNguoiDung.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhomNguoiDung_CellContentClick);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(296, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(233, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "CẬP NHẬP THÔNG TIN NHÓM NGƯỜI DÙNG";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtMaNhomNguoiDung);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.txtTenNhomNguoiDung);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Location = new System.Drawing.Point(10, 28);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(776, 141);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thông tin chi tiết nhóm người dùng";
            // 
            // txtMaNhomNguoiDung
            // 
            this.txtMaNhomNguoiDung.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaNhomNguoiDung.Location = new System.Drawing.Point(342, 36);
            this.txtMaNhomNguoiDung.Name = "txtMaNhomNguoiDung";
            this.txtMaNhomNguoiDung.Size = new System.Drawing.Size(84, 20);
            this.txtMaNhomNguoiDung.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(225, 39);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Mã nhóm người dùng";
            // 
            // txtTenNhomNguoiDung
            // 
            this.txtTenNhomNguoiDung.Location = new System.Drawing.Point(342, 69);
            this.txtTenNhomNguoiDung.Name = "txtTenNhomNguoiDung";
            this.txtTenNhomNguoiDung.Size = new System.Drawing.Size(164, 20);
            this.txtTenNhomNguoiDung.TabIndex = 12;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(225, 72);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(111, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Tên nhóm người dùng";
            // 
            // fQuanLyNguoiDung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 512);
            this.Controls.Add(this.tabQuanNguoiDung);
            this.Name = "fQuanLyNguoiDung";
            this.Text = "fQuanLyNguoiDung";
            this.Load += new System.EventHandler(this.fQuanLyNguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.tabQuanNguoiDung.ResumeLayout(false);
            this.tabpgNguoiDung.ResumeLayout(false);
            this.tabpgNguoiDung.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabpgNhomNguoiDung.ResumeLayout(false);
            this.tabpgNhomNguoiDung.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNhomNguoiDung)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.TabControl tabQuanNguoiDung;
        private System.Windows.Forms.TabPage tabpgNguoiDung;
        private System.Windows.Forms.Button btnXoaNguoiDung;
        private System.Windows.Forms.Button btnNguoiDung;
        private System.Windows.Forms.Button btnThemDocGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabPage tabpgNhomNguoiDung;
        private System.Windows.Forms.Button btnXoaNhomNguoiDung;
        private System.Windows.Forms.Button btnSuaNhomNguoiDung;
        private System.Windows.Forms.Button btnThemNhomNguoiDung;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvNhomNguoiDung;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtMaNhomNguoiDung;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTenNhomNguoiDung;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNhomNguoiDung;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenDangNhap;
        private System.Windows.Forms.TextBox txtMaNguoiDung;
    }
}