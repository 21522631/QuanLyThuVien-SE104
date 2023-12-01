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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label26 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.domainUpDown2 = new System.Windows.Forms.DomainUpDown();
            this.button13 = new System.Windows.Forms.Button();
            this.label25 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.button14 = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label32 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dateTimePicker1);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(540, 242);
            this.panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(333, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(97, 20);
            this.textBox1.TabIndex = 73;
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
            this.groupBox2.Location = new System.Drawing.Point(327, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 149);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sách Nhập";
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Location = new System.Drawing.Point(6, 19);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(199, 121);
            this.dataGridView5.TabIndex = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label26);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.domainUpDown2);
            this.groupBox1.Controls.Add(this.button13);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Location = new System.Drawing.Point(3, 61);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 149);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sách Nhập";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
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
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(87, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(73, 20);
            this.textBox6.TabIndex = 64;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // domainUpDown2
            // 
            this.domainUpDown2.Location = new System.Drawing.Point(269, 26);
            this.domainUpDown2.Name = "domainUpDown2";
            this.domainUpDown2.Size = new System.Drawing.Size(43, 20);
            this.domainUpDown2.TabIndex = 65;
            this.domainUpDown2.Text = "00";
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(235, 117);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(68, 23);
            this.button13.TabIndex = 69;
            this.button13.Text = "Xoá sách";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(189, 28);
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
            this.button14.Location = new System.Drawing.Point(163, 117);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(68, 23);
            this.button14.TabIndex = 68;
            this.button14.Text = "Thêm sách";
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
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(87, 77);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(96, 20);
            this.textBox7.TabIndex = 59;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(6, 77);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(58, 13);
            this.label24.TabIndex = 58;
            this.label24.Text = "Thành tiền";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 29);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(91, 20);
            this.dateTimePicker1.TabIndex = 57;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(70, 35);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(49, 13);
            this.label32.TabIndex = 54;
            this.label32.Text = "Ngày lập";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(454, 216);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 23);
            this.btnHuy.TabIndex = 40;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(381, 216);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 23);
            this.btnLuu.TabIndex = 39;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(163, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(168, 13);
            this.label23.TabIndex = 25;
            this.label23.Text = "THÔNG TIN PHIẾU NHẬP SÁCH";
            // 
            // fThemPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(561, 267);
            this.Controls.Add(this.panel1);
            this.Name = "fThemPhieuNhapSach";
            this.Text = "Thêm Phiếu Nhập Sách";
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
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DomainUpDown domainUpDown2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label24;
    }
}