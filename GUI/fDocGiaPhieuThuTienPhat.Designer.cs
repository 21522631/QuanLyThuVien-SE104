namespace GUI
{
    partial class fDocGiaPhieuThuTienPhat
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
            this.dgvPTTP = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSoTienThu = new System.Windows.Forms.TextBox();
            this.txtSoPhieuThu = new System.Windows.Forms.TextBox();
            this.dtmNgayThu = new System.Windows.Forms.DateTimePicker();
            this.txtConLai = new System.Windows.Forms.TextBox();
            this.txtTongNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTTP)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.dgvPTTP);
            this.groupBox12.Location = new System.Drawing.Point(12, 144);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(475, 246);
            this.groupBox12.TabIndex = 32;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Thông tin tất cả phiếu thu tiền phạt";
            // 
            // dgvPTTP
            // 
            this.dgvPTTP.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPTTP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPTTP.Location = new System.Drawing.Point(6, 19);
            this.dgvPTTP.Name = "dgvPTTP";
            this.dgvPTTP.Size = new System.Drawing.Size(463, 221);
            this.dgvPTTP.TabIndex = 0;
            this.dgvPTTP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPTTP_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSoTienThu);
            this.groupBox1.Controls.Add(this.txtSoPhieuThu);
            this.groupBox1.Controls.Add(this.dtmNgayThu);
            this.groupBox1.Controls.Add(this.txtConLai);
            this.groupBox1.Controls.Add(this.txtTongNo);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 112);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chi tiết phiếu thu tiền phạt";
            // 
            // txtSoTienThu
            // 
            this.txtSoTienThu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSoTienThu.Location = new System.Drawing.Point(347, 49);
            this.txtSoTienThu.Name = "txtSoTienThu";
            this.txtSoTienThu.Size = new System.Drawing.Size(91, 20);
            this.txtSoTienThu.TabIndex = 92;
            // 
            // txtSoPhieuThu
            // 
            this.txtSoPhieuThu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtSoPhieuThu.Location = new System.Drawing.Point(154, 27);
            this.txtSoPhieuThu.Name = "txtSoPhieuThu";
            this.txtSoPhieuThu.Size = new System.Drawing.Size(91, 20);
            this.txtSoPhieuThu.TabIndex = 90;
            // 
            // dtmNgayThu
            // 
            this.dtmNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtmNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmNgayThu.Location = new System.Drawing.Point(154, 53);
            this.dtmNgayThu.Name = "dtmNgayThu";
            this.dtmNgayThu.Size = new System.Drawing.Size(91, 20);
            this.dtmNgayThu.TabIndex = 88;
            // 
            // txtConLai
            // 
            this.txtConLai.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtConLai.Location = new System.Drawing.Point(347, 75);
            this.txtConLai.Name = "txtConLai";
            this.txtConLai.Size = new System.Drawing.Size(91, 20);
            this.txtConLai.TabIndex = 82;
            // 
            // txtTongNo
            // 
            this.txtTongNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTongNo.Location = new System.Drawing.Point(347, 23);
            this.txtTongNo.Name = "txtTongNo";
            this.txtTongNo.Size = new System.Drawing.Size(91, 20);
            this.txtTongNo.TabIndex = 81;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 80);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Còn lại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 36;
            this.label2.Text = "Tổng nợ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(275, 55);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Số tiền thu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ngày thu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Số phiếu thu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(145, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(210, 15);
            this.label6.TabIndex = 30;
            this.label6.Text = "THÔNG TIN PHIẾU THU TIỀN PHẠT";
            // 
            // fDocGiaPhieuThuTienPhat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 403);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Name = "fDocGiaPhieuThuTienPhat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phiếu Thu Tiền Phạt";
            this.Load += new System.EventHandler(this.fDocGiaPhieuThuTienPhat_Load);
            this.groupBox12.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPTTP)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.DataGridView dgvPTTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSoTienThu;
        private System.Windows.Forms.TextBox txtSoPhieuThu;
        private System.Windows.Forms.DateTimePicker dtmNgayThu;
        private System.Windows.Forms.TextBox txtConLai;
        private System.Windows.Forms.TextBox txtTongNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}