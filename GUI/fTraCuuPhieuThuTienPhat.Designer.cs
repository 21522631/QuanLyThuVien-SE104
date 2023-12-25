namespace GUI
{
    partial class fTraCuuPhieuThuTienPhat
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvPhieuThuTien = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkApDungNgay = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtmNgayThu = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThuTien)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.dtmNgayThu);
            this.groupBox2.Controls.Add(this.chkApDungNgay);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTraCuu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 73);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra cứu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(173, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "(Nhập số phiếu thu hoặc mã độc giả)";
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(147, 22);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(296, 20);
            this.txtTraCuu.TabIndex = 1;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.txtTraCuu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập thông tin tra cứu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(277, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(240, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "TRA CỨU THÔNG TIN PHIẾU THU TIỀN PHẠT";
            // 
            // dgvPhieuThuTien
            // 
            this.dgvPhieuThuTien.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuThuTien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuThuTien.Location = new System.Drawing.Point(6, 19);
            this.dgvPhieuThuTien.Name = "dgvPhieuThuTien";
            this.dgvPhieuThuTien.Size = new System.Drawing.Size(744, 253);
            this.dgvPhieuThuTien.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhieuThuTien);
            this.groupBox1.Location = new System.Drawing.Point(12, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 278);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tra cứu";
            // 
            // chkApDungNgay
            // 
            this.chkApDungNgay.AutoSize = true;
            this.chkApDungNgay.Location = new System.Drawing.Point(449, 23);
            this.chkApDungNgay.Name = "chkApDungNgay";
            this.chkApDungNgay.Size = new System.Drawing.Size(106, 17);
            this.chkApDungNgay.TabIndex = 94;
            this.chkApDungNgay.Text = "Kết hợp với ngày";
            this.chkApDungNgay.UseVisualStyleBackColor = true;
            this.chkApDungNgay.CheckedChanged += new System.EventHandler(this.chkApDungNgay_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(578, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Ngày thu";
            // 
            // dtmNgayThu
            // 
            this.dtmNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayThu.Location = new System.Drawing.Point(633, 22);
            this.dtmNgayThu.Name = "dtmNgayThu";
            this.dtmNgayThu.Size = new System.Drawing.Size(80, 20);
            this.dtmNgayThu.TabIndex = 96;
            this.dtmNgayThu.ValueChanged += new System.EventHandler(this.dtmNgayThu_ValueChanged);
            // 
            // fTraCuuPhieuThuTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 394);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Name = "fTraCuuPhieuThuTienPhat";
            this.Text = "Tra Cứu Phiếu Thu Tiền Phạt";
            this.Load += new System.EventHandler(this.fTraCuuPhieuThuTienPhat_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuThuTien)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvPhieuThuTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkApDungNgay;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtmNgayThu;
    }
}