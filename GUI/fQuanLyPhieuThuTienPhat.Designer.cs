namespace GUI
{
    partial class fQuanLyPhieuThuTienPhat
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
            this.btnThemPhieuThu = new System.Windows.Forms.Button();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.dgvPTTP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.txtMaDocGia = new System.Windows.Forms.TextBox();
            this.txtSoPhieuThu = new System.Windows.Forms.TextBox();
            this.dtmNgayThu = new System.Windows.Forms.DateTimePicker();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTTP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThemPhieuThu);
            this.panel1.Controls.Add(this.groupBox12);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(783, 480);
            this.panel1.TabIndex = 1;
            // 
            // btnThemPhieuThu
            // 
            this.btnThemPhieuThu.Location = new System.Drawing.Point(9, 198);
            this.btnThemPhieuThu.Name = "btnThemPhieuThu";
            this.btnThemPhieuThu.Size = new System.Drawing.Size(104, 24);
            this.btnThemPhieuThu.TabIndex = 31;
            this.btnThemPhieuThu.Text = "Thêm phiếu thu";
            this.btnThemPhieuThu.UseVisualStyleBackColor = true;
            this.btnThemPhieuThu.Click += new System.EventHandler(this.btnThemPhieuThu_Click);
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.dgvPTTP);
            this.groupBox12.Location = new System.Drawing.Point(3, 228);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(776, 246);
            this.groupBox12.TabIndex = 29;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Thông tin tất cả phiếu thu tiền phạt";
            // 
            // dgvPTTP
            // 
            this.dgvPTTP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPTTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTTP.Location = new System.Drawing.Point(6, 19);
            this.dgvPTTP.Name = "dgvPTTP";
            this.dgvPTTP.Size = new System.Drawing.Size(763, 221);
            this.dgvPTTP.TabIndex = 0;
            this.dgvPTTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPTTP_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoTienThu);
            this.groupBox1.Controls.Add(this.txtMaDocGia);
            this.groupBox1.Controls.Add(this.txtSoPhieuThu);
            this.groupBox1.Controls.Add(this.dtmNgayThu);
            this.groupBox1.Controls.Add(this.txtConLai);
            this.groupBox1.Controls.Add(this.txtTongNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 159);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết phiếu thu tiền phạt";
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSoTienThu.Location = new System.Drawing.Point(495, 66);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(91, 20);
            this.txtSoTienThu.TabIndex = 92;
            // 
            // txtMaDocGia
            // 
            this.txtMaDocGia.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtMaDocGia.Location = new System.Drawing.Point(289, 40);
            this.txtMaDocGia.Name = "txtMaDocGia";
            this.txtMaDocGia.Size = new System.Drawing.Size(91, 20);
            this.txtMaDocGia.TabIndex = 91;
            // 
            // txtSoPhieuThu
            // 
            this.txtSoPhieuThu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSoPhieuThu.Location = new System.Drawing.Point(373, 13);
            this.txtSoPhieuThu.Name = "txtSoPhieuThu";
            this.txtSoPhieuThu.Size = new System.Drawing.Size(91, 20);
            this.txtSoPhieuThu.TabIndex = 90;
            // 
            // dtmNgayThu
            // 
            this.dtmNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayThu.Location = new System.Drawing.Point(289, 66);
            this.dtmNgayThu.Name = "dtmNgayThu";
            this.dtmNgayThu.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayThu.TabIndex = 88;
            // 
            // txtConLai
            // 
            this.txtConLai.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtConLai.Location = new System.Drawing.Point(495, 91);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.Size = new System.Drawing.Size(91, 20);
            this.txtConLai.TabIndex = 82;
            // 
            // txtTongNo
            // 
            this.txtTongNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTongNo.Location = new System.Drawing.Point(495, 39);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.Size = new System.Drawing.Size(91, 20);
            this.txtTongNo.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(419, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Còn lại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tổng nợ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(417, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Số tiền thu";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(208, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Mã độc giả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày thu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(299, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số phiếu thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(289, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 15);
            this.label6.TabIndex = 22;
            this.label6.Text = "THÔNG TIN PHIẾU THU TIỀN PHẠT";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(705, 198);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 17;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(624, 198);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 6;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // fQuanLyPhieuThuTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 498);
            this.Controls.Add(this.panel1);
            this.Name = "fQuanLyPhieuThuTienPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Thu Tiền Phạt";
            this.Load += new System.EventHandler(this.fQuanLyPhieuThuTienPhat_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTTP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThemPhieuThu;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.DataGridView dgvPTTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTongNo;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.DateTimePicker dtmNgayThu;
        private System.Windows.Forms.TextBox txtSoPhieuThu;
        private System.Windows.Forms.TextBox txtMaDocGia;
        private System.Windows.Forms.TextBox txtSoTienThu;
    }
}