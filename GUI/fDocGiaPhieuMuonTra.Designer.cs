namespace GUI
{
    partial class fDocGiaPhieuMuonTra
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
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dgvPhieuMuon = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtmNgayTra = new System.Windows.Forms.DateTimePicker();
            this.dtmNgayPhaiTra = new System.Windows.Forms.DateTimePicker();
            this.dtmNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.txtMaCuonSach = new System.Windows.Forms.TextBox();
            this.txtTienPhat = new System.Windows.Forms.TextBox();
            this.txtSoPhieuMuonTra = new System.Windows.Forms.TextBox();
            this.chkTinhTrang = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.dgvPhieuMuon);
            this.groupBox12.Location = new System.Drawing.Point(12, 199);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(687, 246);
            this.groupBox12.TabIndex = 32;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Thông tin chung phiếu mượn";
            // 
            // dgvPhieuMuon
            // 
            this.dgvPhieuMuon.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPhieuMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuMuon.Location = new System.Drawing.Point(6, 19);
            this.dgvPhieuMuon.Name = "dgvPhieuMuon";
            this.dgvPhieuMuon.Size = new System.Drawing.Size(673, 221);
            this.dgvPhieuMuon.TabIndex = 0;
            this.dgvPhieuMuon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuMuon_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtmNgayTra);
            this.groupBox1.Controls.Add(this.dtmNgayPhaiTra);
            this.groupBox1.Controls.Add(this.dtmNgayMuon);
            this.groupBox1.Controls.Add(this.txtMaCuonSach);
            this.groupBox1.Controls.Add(this.txtTienPhat);
            this.groupBox1.Controls.Add(this.txtSoPhieuMuonTra);
            this.groupBox1.Controls.Add(this.chkTinhTrang);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 159);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết phiếu mượn";
            // 
            // dtmNgayTra
            // 
            this.dtmNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayTra.Location = new System.Drawing.Point(374, 33);
            this.dtmNgayTra.Name = "dtmNgayTra";
            this.dtmNgayTra.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayTra.TabIndex = 87;
            // 
            // dtmNgayPhaiTra
            // 
            this.dtmNgayPhaiTra.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayPhaiTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayPhaiTra.Location = new System.Drawing.Point(205, 109);
            this.dtmNgayPhaiTra.Name = "dtmNgayPhaiTra";
            this.dtmNgayPhaiTra.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayPhaiTra.TabIndex = 86;
            // 
            // dtmNgayMuon
            // 
            this.dtmNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayMuon.Location = new System.Drawing.Point(205, 84);
            this.dtmNgayMuon.Name = "dtmNgayMuon";
            this.dtmNgayMuon.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayMuon.TabIndex = 85;
            // 
            // txtMaCuonSach
            // 
            this.txtMaCuonSach.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaCuonSach.Location = new System.Drawing.Point(205, 57);
            this.txtMaCuonSach.Name = "txtMaCuonSach";
            this.txtMaCuonSach.Size = new System.Drawing.Size(91, 20);
            this.txtMaCuonSach.TabIndex = 83;
            // 
            // txtTienPhat
            // 
            this.txtTienPhat.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTienPhat.Location = new System.Drawing.Point(374, 57);
            this.txtTienPhat.Name = "txtTienPhat";
            this.txtTienPhat.Size = new System.Drawing.Size(91, 20);
            this.txtTienPhat.TabIndex = 79;
            this.txtTienPhat.Text = "0";
            // 
            // txtSoPhieuMuonTra
            // 
            this.txtSoPhieuMuonTra.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSoPhieuMuonTra.Location = new System.Drawing.Point(205, 31);
            this.txtSoPhieuMuonTra.Name = "txtSoPhieuMuonTra";
            this.txtSoPhieuMuonTra.Size = new System.Drawing.Size(91, 20);
            this.txtSoPhieuMuonTra.TabIndex = 78;
            // 
            // chkTinhTrang
            // 
            this.chkTinhTrang.AutoSize = true;
            this.chkTinhTrang.Location = new System.Drawing.Point(374, 90);
            this.chkTinhTrang.Name = "chkTinhTrang";
            this.chkTinhTrang.Size = new System.Drawing.Size(15, 14);
            this.chkTinhTrang.TabIndex = 53;
            this.chkTinhTrang.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(310, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Đã trả";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ngày trả";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(100, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Ngày phải trả";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Tiền phạt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày mượn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(100, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số phiếu mượn trả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Mã cuốn sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "THÔNG TIN PHIẾU MƯỢN TRẢ";
            // 
            // fDocGiaPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 453);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "fDocGiaPhieuMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Mượn Trả";
            this.Load += new System.EventHandler(this.fDocGiaPhieuMuonTra_Load);
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuMuon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.DataGridView dgvPhieuMuon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtmNgayTra;
        private System.Windows.Forms.DateTimePicker dtmNgayPhaiTra;
        private System.Windows.Forms.DateTimePicker dtmNgayMuon;
        private System.Windows.Forms.TextBox txtMaCuonSach;
        private System.Windows.Forms.TextBox txtTienPhat;
        private System.Windows.Forms.TextBox txtSoPhieuMuonTra;
        private System.Windows.Forms.CheckBox chkTinhTrang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}