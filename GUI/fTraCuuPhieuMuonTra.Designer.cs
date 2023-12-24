namespace GUI
{
    partial class fTraCuuPhieuMuonTra
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkApDungLoc = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkDaTra = new System.Windows.Forms.CheckBox();
            this.chkChuaTra = new System.Windows.Forms.CheckBox();
            this.dtmNgay = new System.Windows.Forms.DateTimePicker();
            this.chkNgayTra = new System.Windows.Forms.CheckBox();
            this.chkNgayMuon = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTraCuu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuMuonTra = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonTra)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "TRA CỨU THÔNG TIN PHIẾU MƯỢN TRẢ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkApDungLoc);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTraCuu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 106);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra cứu";
            // 
            // chkApDungLoc
            // 
            this.chkApDungLoc.AutoSize = true;
            this.chkApDungLoc.Location = new System.Drawing.Point(429, 40);
            this.chkApDungLoc.Name = "chkApDungLoc";
            this.chkApDungLoc.Size = new System.Drawing.Size(83, 17);
            this.chkApDungLoc.TabIndex = 26;
            this.chkApDungLoc.Text = "Áp dụng lọc";
            this.chkApDungLoc.UseVisualStyleBackColor = true;
            this.chkApDungLoc.CheckedChanged += new System.EventHandler(this.chkApDungLoc_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.chkDaTra);
            this.groupBox3.Controls.Add(this.chkChuaTra);
            this.groupBox3.Controls.Add(this.dtmNgay);
            this.groupBox3.Controls.Add(this.chkNgayTra);
            this.groupBox3.Controls.Add(this.chkNgayMuon);
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.groupBox3.Location = new System.Drawing.Point(516, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 83);
            this.groupBox3.TabIndex = 93;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin lọc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 89;
            this.label2.Text = "Tình trạng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Ngày";
            // 
            // chkDaTra
            // 
            this.chkDaTra.AutoSize = true;
            this.chkDaTra.Location = new System.Drawing.Point(21, 39);
            this.chkDaTra.Name = "chkDaTra";
            this.chkDaTra.Size = new System.Drawing.Size(55, 17);
            this.chkDaTra.TabIndex = 90;
            this.chkDaTra.Text = "Đã trả";
            this.chkDaTra.UseVisualStyleBackColor = true;
            this.chkDaTra.CheckedChanged += new System.EventHandler(this.chkDaTra_CheckedChanged);
            // 
            // chkChuaTra
            // 
            this.chkChuaTra.AutoSize = true;
            this.chkChuaTra.Location = new System.Drawing.Point(21, 58);
            this.chkChuaTra.Name = "chkChuaTra";
            this.chkChuaTra.Size = new System.Drawing.Size(66, 17);
            this.chkChuaTra.TabIndex = 91;
            this.chkChuaTra.Text = "Chưa trả";
            this.chkChuaTra.UseVisualStyleBackColor = true;
            this.chkChuaTra.CheckedChanged += new System.EventHandler(this.chkChuaTra_CheckedChanged);
            // 
            // dtmNgay
            // 
            this.dtmNgay.CustomFormat = "dd/MM/yyyy";
            this.dtmNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgay.Location = new System.Drawing.Point(127, 16);
            this.dtmNgay.Name = "dtmNgay";
            this.dtmNgay.Size = new System.Drawing.Size(80, 20);
            this.dtmNgay.TabIndex = 86;
            this.dtmNgay.ValueChanged += new System.EventHandler(this.dtmNgayMuon_ValueChanged);
            // 
            // chkNgayTra
            // 
            this.chkNgayTra.AutoSize = true;
            this.chkNgayTra.Location = new System.Drawing.Point(127, 58);
            this.chkNgayTra.Name = "chkNgayTra";
            this.chkNgayTra.Size = new System.Drawing.Size(66, 17);
            this.chkNgayTra.TabIndex = 88;
            this.chkNgayTra.Text = "Ngày trả";
            this.chkNgayTra.UseVisualStyleBackColor = true;
            this.chkNgayTra.CheckedChanged += new System.EventHandler(this.chkNgayTra_CheckedChanged);
            // 
            // chkNgayMuon
            // 
            this.chkNgayMuon.AutoSize = true;
            this.chkNgayMuon.Location = new System.Drawing.Point(127, 39);
            this.chkNgayMuon.Name = "chkNgayMuon";
            this.chkNgayMuon.Size = new System.Drawing.Size(80, 17);
            this.chkNgayMuon.TabIndex = 87;
            this.chkNgayMuon.Text = "Ngày mượn";
            this.chkNgayMuon.UseVisualStyleBackColor = true;
            this.chkNgayMuon.CheckedChanged += new System.EventHandler(this.chkNgayMuon_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(144, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "(Nhập số phiếu mượn,  mã độc giả hoặc mã cuốn sách )";
            // 
            // txtTraCuu
            // 
            this.txtTraCuu.Location = new System.Drawing.Point(130, 37);
            this.txtTraCuu.Name = "txtTraCuu";
            this.txtTraCuu.Size = new System.Drawing.Size(296, 20);
            this.txtTraCuu.TabIndex = 1;
            this.txtTraCuu.TextChanged += new System.EventHandler(this.txtTraCuu_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập thông tin tra cứu";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvPhieuMuonTra);
            this.groupBox1.Location = new System.Drawing.Point(12, 147);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 240);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tra cứu";
            // 
            // dgvPhieuMuonTra
            // 
            this.dgvPhieuMuonTra.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuMuonTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuonTra.Location = new System.Drawing.Point(6, 19);
            this.dgvPhieuMuonTra.Name = "dgvPhieuMuonTra";
            this.dgvPhieuMuonTra.Size = new System.Drawing.Size(736, 212);
            this.dgvPhieuMuonTra.TabIndex = 1;
            // 
            // fTraCuuPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 392);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label6);
            this.Name = "fTraCuuPhieuMuonTra";
            this.Text = "Tra Cứu Phiếu Mượn Trả";
            this.Load += new System.EventHandler(this.fTraCuuPhieuMuonTra_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuonTra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraCuu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvPhieuMuonTra;
        private System.Windows.Forms.DateTimePicker dtmNgay;
        private System.Windows.Forms.CheckBox chkNgayTra;
        private System.Windows.Forms.CheckBox chkNgayMuon;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkChuaTra;
        private System.Windows.Forms.CheckBox chkDaTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkApDungLoc;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}