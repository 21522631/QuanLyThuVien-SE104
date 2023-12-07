namespace GUI
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
            this.cboSoPhieuNhap = new System.Windows.Forms.ComboBox();
            this.txtMaTacGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboMaSach = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.button13 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.cboSoPhieuNhap);
            this.panel1.Controls.Add(this.txtMaTacGia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 285);
            this.panel1.TabIndex = 1;
            // 
            // cboSoPhieuNhap
            // 
            this.cboSoPhieuNhap.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboSoPhieuNhap.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboSoPhieuNhap.FormattingEnabled = true;
            this.cboSoPhieuNhap.Location = new System.Drawing.Point(125, 27);
            this.cboSoPhieuNhap.Name = "cboSoPhieuNhap";
            this.cboSoPhieuNhap.Size = new System.Drawing.Size(96, 21);
            this.cboSoPhieuNhap.TabIndex = 74;
            // 
            // txtMaTacGia
            // 
            this.txtMaTacGia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaTacGia.Location = new System.Drawing.Point(333, 28);
            this.txtMaTacGia.Name = "txtMaTacGia";
            this.txtMaTacGia.Size = new System.Drawing.Size(84, 20);
            this.txtMaTacGia.TabIndex = 73;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 72;
            this.label1.Text = "Tổng tiền";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView5);
            this.groupBox2.Location = new System.Drawing.Point(212, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(325, 192);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sách Nhập";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 19);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(313, 167);
            this.dataGridView5.TabIndex = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboMaSach);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.domainUpDown2);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Location = new System.Drawing.Point(3, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 192);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách Nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cboMaSach
            // 
            this.cboMaSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaSach.FormattingEnabled = true;
            this.cboMaSach.Location = new System.Drawing.Point(87, 20);
            this.cboMaSach.Name = "cboMaSach";
            this.cboMaSach.Size = new System.Drawing.Size(96, 21);
            this.cboMaSach.TabIndex = 71;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(87, 107);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 20);
            this.textBox1.TabIndex = 70;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(6, 28);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(75, 13);
            this.label26.TabIndex = 62;
            this.label26.Text = "Mã sách nhập";
            this.label26.Click += new System.EventHandler(this.label26_Click);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(140, 81);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(43, 20);
            this.domainUpDown2.TabIndex = 65;
            this.domainUpDown2.Text = "00";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(104, 155);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(97, 23);
            this.button13.TabIndex = 69;
            this.button13.Text = "Xoá sách nhập";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(5, 88);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(76, 13);
            this.label25.TabIndex = 63;
            this.label25.Text = "Số lượng nhập";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 54);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(44, 13);
            this.label28.TabIndex = 66;
            this.label28.Text = "Đơn giá";
            this.label28.Click += new System.EventHandler(this.label28_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(0, 155);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(98, 23);
            this.button14.TabIndex = 68;
            this.button14.Text = "Thêm sách nhập";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(87, 51);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(96, 20);
            this.textBox8.TabIndex = 67;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(5, 114);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "Thành tiền";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(43, 32);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(76, 13);
            this.label32.TabIndex = 54;
            this.label32.Text = "Số phiếu nhâp";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(181, 3);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(216, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "THÔNG TIN CHI TIẾT PHIẾU NHẬP SÁCH";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(456, 253);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 76;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(375, 253);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 75;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // fThemChiTietPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 309);
            this.Controls.Add(this.panel1);
            this.Name = "fThemChiTietPhieuNhapSach";
            this.Text = "Thêm Chi Tiết Phiếu Nhập Sách";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtMaTacGia;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox cboMaSach;
        private System.Windows.Forms.ComboBox cboSoPhieuNhap;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}