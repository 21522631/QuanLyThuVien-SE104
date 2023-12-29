namespace GUI
{
    partial class fThemPhieuMuonTra
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
            this.dtmNgayPhaiTra = new System.Windows.Forms.DateTimePicker();
            this.dtmNgayMuon = new System.Windows.Forms.DateTimePicker();
            this.cboMaCuonSach = new System.Windows.Forms.ComboBox();
            this.cboMaDocGia = new System.Windows.Forms.ComboBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtmNgayPhaiTra);
            this.panel1.Controls.Add(this.dtmNgayMuon);
            this.panel1.Controls.Add(this.cboMaCuonSach);
            this.panel1.Controls.Add(this.cboMaDocGia);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 129);
            this.panel1.TabIndex = 0;
            // 
            // dtmNgayPhaiTra
            // 
            this.dtmNgayPhaiTra.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayPhaiTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayPhaiTra.Location = new System.Drawing.Point(277, 65);
            this.dtmNgayPhaiTra.Name = "dtmNgayPhaiTra";
            this.dtmNgayPhaiTra.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayPhaiTra.TabIndex = 66;
            // 
            // dtmNgayMuon
            // 
            this.dtmNgayMuon.Cursor = System.Windows.Forms.Cursors.No;
            this.dtmNgayMuon.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayMuon.Location = new System.Drawing.Point(277, 38);
            this.dtmNgayMuon.Name = "dtmNgayMuon";
            this.dtmNgayMuon.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayMuon.TabIndex = 65;
            this.dtmNgayMuon.ValueChanged += new System.EventHandler(this.dtmNgayMuon_ValueChanged);
            // 
            // cboMaCuonSach
            // 
            this.cboMaCuonSach.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaCuonSach.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaCuonSach.FormattingEnabled = true;
            this.cboMaCuonSach.Location = new System.Drawing.Point(94, 64);
            this.cboMaCuonSach.Name = "cboMaCuonSach";
            this.cboMaCuonSach.Size = new System.Drawing.Size(91, 21);
            this.cboMaCuonSach.TabIndex = 64;
            // 
            // cboMaDocGia
            // 
            this.cboMaDocGia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cboMaDocGia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cboMaDocGia.FormattingEnabled = true;
            this.cboMaDocGia.Location = new System.Drawing.Point(94, 38);
            this.cboMaDocGia.Name = "cboMaDocGia";
            this.cboMaDocGia.Size = new System.Drawing.Size(91, 21);
            this.cboMaDocGia.TabIndex = 63;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(301, 99);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 23);
            this.btnHuy.TabIndex = 62;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(228, 99);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 23);
            this.btnLuu.TabIndex = 61;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Ngày phải trả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Ngày mượn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 51;
            this.label4.Text = "Mã cuốn sách";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(107, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "THÔNG TIN PHIẾU MƯỢN TRẢ";
            // 
            // fThemPhieuMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 153);
            this.Controls.Add(this.panel1);
            this.Name = "fThemPhieuMuonTra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Phiếu Mượn Trả";
            this.Load += new System.EventHandler(this.fThemPhieuMuonTra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.ComboBox cboMaDocGia;
        private System.Windows.Forms.ComboBox cboMaCuonSach;
        private System.Windows.Forms.DateTimePicker dtmNgayMuon;
        private System.Windows.Forms.DateTimePicker dtmNgayPhaiTra;
    }
}