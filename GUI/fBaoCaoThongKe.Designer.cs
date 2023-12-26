namespace GUI
{
    partial class fBaoCaoThongKe
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
            this.tabpgBCTKSachTraTre = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBCSachTraTre = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXuatExcelBCTraTre = new System.Windows.Forms.Button();
            this.dtmTGBCSachTraTre = new System.Windows.Forms.DateTimePicker();
            this.btnTKSachTraTre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabpgBCTKTinhHinhMuonSach = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvBCTinhHinhMuon = new System.Windows.Forms.DataGridView();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtmTGBCTinhHinhMuon = new System.Windows.Forms.DateTimePicker();
            this.btnTKTinhHinhMuon = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tabBaoCaoThongKe = new System.Windows.Forms.TabControl();
            this.tabpgBCTKSachTraTre.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCSachTraTre)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabpgBCTKTinhHinhMuonSach.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCTinhHinhMuon)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.tabBaoCaoThongKe.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabpgBCTKSachTraTre
            // 
            this.tabpgBCTKSachTraTre.Controls.Add(this.groupBox2);
            this.tabpgBCTKSachTraTre.Controls.Add(this.groupBox1);
            this.tabpgBCTKSachTraTre.Controls.Add(this.label16);
            this.tabpgBCTKSachTraTre.Location = new System.Drawing.Point(4, 22);
            this.tabpgBCTKSachTraTre.Name = "tabpgBCTKSachTraTre";
            this.tabpgBCTKSachTraTre.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgBCTKSachTraTre.Size = new System.Drawing.Size(791, 495);
            this.tabpgBCTKSachTraTre.TabIndex = 2;
            this.tabpgBCTKSachTraTre.Text = "Báo Cáo Thống Kê Sách Trả Trễ";
            this.tabpgBCTKSachTraTre.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBCSachTraTre);
            this.groupBox2.Location = new System.Drawing.Point(6, 89);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 397);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Thống Kê";
            // 
            // dgvBCSachTraTre
            // 
            this.dgvBCSachTraTre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCSachTraTre.Location = new System.Drawing.Point(6, 19);
            this.dgvBCSachTraTre.Name = "dgvBCSachTraTre";
            this.dgvBCSachTraTre.Size = new System.Drawing.Size(763, 378);
            this.dgvBCSachTraTre.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXuatExcelBCTraTre);
            this.groupBox1.Controls.Add(this.dtmTGBCSachTraTre);
            this.groupBox1.Controls.Add(this.btnTKSachTraTre);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(6, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 55);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tuỳ Chọn";
            // 
            // btnXuatExcelBCTraTre
            // 
            this.btnXuatExcelBCTraTre.Location = new System.Drawing.Point(688, 19);
            this.btnXuatExcelBCTraTre.Name = "btnXuatExcelBCTraTre";
            this.btnXuatExcelBCTraTre.Size = new System.Drawing.Size(75, 23);
            this.btnXuatExcelBCTraTre.TabIndex = 51;
            this.btnXuatExcelBCTraTre.Text = "Xuất Excel";
            this.btnXuatExcelBCTraTre.UseVisualStyleBackColor = true;
            this.btnXuatExcelBCTraTre.Click += new System.EventHandler(this.btnXuatExcelBCTraTre_Click);
            // 
            // dtmTGBCSachTraTre
            // 
            this.dtmTGBCSachTraTre.CustomFormat = "dd/MM/yyyy";
            this.dtmTGBCSachTraTre.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmTGBCSachTraTre.Location = new System.Drawing.Point(363, 24);
            this.dtmTGBCSachTraTre.Name = "dtmTGBCSachTraTre";
            this.dtmTGBCSachTraTre.Size = new System.Drawing.Size(91, 20);
            this.dtmTGBCSachTraTre.TabIndex = 50;
            this.dtmTGBCSachTraTre.ValueChanged += new System.EventHandler(this.dtmTGBCSachTraTre_ValueChanged);
            // 
            // btnTKSachTraTre
            // 
            this.btnTKSachTraTre.Location = new System.Drawing.Point(470, 20);
            this.btnTKSachTraTre.Name = "btnTKSachTraTre";
            this.btnTKSachTraTre.Size = new System.Drawing.Size(75, 23);
            this.btnTKSachTraTre.TabIndex = 2;
            this.btnTKSachTraTre.Text = "Thống Kê";
            this.btnTKSachTraTre.UseVisualStyleBackColor = true;
            this.btnTKSachTraTre.Click += new System.EventHandler(this.btnTKSachTraTre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập ngày báo cáo";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(323, 12);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "BÁO CÁO THỐNG KÊ SÁCH TRẢ TRỄ";
            // 
            // tabpgBCTKTinhHinhMuonSach
            // 
            this.tabpgBCTKTinhHinhMuonSach.Controls.Add(this.groupBox4);
            this.tabpgBCTKTinhHinhMuonSach.Controls.Add(this.groupBox6);
            this.tabpgBCTKTinhHinhMuonSach.Controls.Add(this.label12);
            this.tabpgBCTKTinhHinhMuonSach.Location = new System.Drawing.Point(4, 22);
            this.tabpgBCTKTinhHinhMuonSach.Name = "tabpgBCTKTinhHinhMuonSach";
            this.tabpgBCTKTinhHinhMuonSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgBCTKTinhHinhMuonSach.Size = new System.Drawing.Size(791, 495);
            this.tabpgBCTKTinhHinhMuonSach.TabIndex = 1;
            this.tabpgBCTKTinhHinhMuonSach.Text = "Báo Cáo Thống Kê Tình Hình Mượn Theo Thể Loại";
            this.tabpgBCTKTinhHinhMuonSach.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvBCTinhHinhMuon);
            this.groupBox4.Location = new System.Drawing.Point(6, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(776, 397);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Thống Kê";
            // 
            // dgvBCTinhHinhMuon
            // 
            this.dgvBCTinhHinhMuon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBCTinhHinhMuon.Location = new System.Drawing.Point(6, 19);
            this.dgvBCTinhHinhMuon.Name = "dgvBCTinhHinhMuon";
            this.dgvBCTinhHinhMuon.Size = new System.Drawing.Size(763, 372);
            this.dgvBCTinhHinhMuon.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtmTGBCTinhHinhMuon);
            this.groupBox6.Controls.Add(this.btnTKTinhHinhMuon);
            this.groupBox6.Controls.Add(this.label19);
            this.groupBox6.Location = new System.Drawing.Point(6, 31);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(769, 55);
            this.groupBox6.TabIndex = 23;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tuỳ Chọn";
            // 
            // dtmTGBCTinhHinhMuon
            // 
            this.dtmTGBCTinhHinhMuon.CustomFormat = "MM/yyyy";
            this.dtmTGBCTinhHinhMuon.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmTGBCTinhHinhMuon.Location = new System.Drawing.Point(338, 23);
            this.dtmTGBCTinhHinhMuon.Name = "dtmTGBCTinhHinhMuon";
            this.dtmTGBCTinhHinhMuon.Size = new System.Drawing.Size(91, 20);
            this.dtmTGBCTinhHinhMuon.TabIndex = 49;
            this.dtmTGBCTinhHinhMuon.ValueChanged += new System.EventHandler(this.dtmTGBCTinhHinhMuon_ValueChanged);
            // 
            // btnTKTinhHinhMuon
            // 
            this.btnTKTinhHinhMuon.Location = new System.Drawing.Point(435, 20);
            this.btnTKTinhHinhMuon.Name = "btnTKTinhHinhMuon";
            this.btnTKTinhHinhMuon.Size = new System.Drawing.Size(75, 23);
            this.btnTKTinhHinhMuon.TabIndex = 2;
            this.btnTKTinhHinhMuon.Text = "Thống Kê";
            this.btnTKTinhHinhMuon.UseVisualStyleBackColor = true;
            this.btnTKTinhHinhMuon.Click += new System.EventHandler(this.btnTKTinhHinhMuon_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(231, 25);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 13);
            this.label19.TabIndex = 0;
            this.label19.Text = "Nhập ngày báo cáo";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(267, 15);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(293, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "BÁO CÁO THỐNG KÊ TÌNH HÌNH MƯỢN THEO THỂ LOẠI";
            // 
            // tabBaoCaoThongKe
            // 
            this.tabBaoCaoThongKe.Controls.Add(this.tabpgBCTKTinhHinhMuonSach);
            this.tabBaoCaoThongKe.Controls.Add(this.tabpgBCTKSachTraTre);
            this.tabBaoCaoThongKe.Location = new System.Drawing.Point(12, 12);
            this.tabBaoCaoThongKe.Name = "tabBaoCaoThongKe";
            this.tabBaoCaoThongKe.SelectedIndex = 0;
            this.tabBaoCaoThongKe.Size = new System.Drawing.Size(799, 521);
            this.tabBaoCaoThongKe.TabIndex = 1;
            // 
            // fBaoCaoThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 542);
            this.Controls.Add(this.tabBaoCaoThongKe);
            this.Name = "fBaoCaoThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Thống Kê";
            this.Load += new System.EventHandler(this.fBaoCaoThongKe_Load);
            this.tabpgBCTKSachTraTre.ResumeLayout(false);
            this.tabpgBCTKSachTraTre.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCSachTraTre)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabpgBCTKTinhHinhMuonSach.ResumeLayout(false);
            this.tabpgBCTKTinhHinhMuonSach.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBCTinhHinhMuon)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabBaoCaoThongKe.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabpgBCTKSachTraTre;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TabPage tabpgBCTKTinhHinhMuonSach;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabBaoCaoThongKe;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DataGridView dgvBCSachTraTre;
        private System.Windows.Forms.DateTimePicker dtmTGBCSachTraTre;
        private System.Windows.Forms.Button btnTKSachTraTre;
        private System.Windows.Forms.DataGridView dgvBCTinhHinhMuon;
        private System.Windows.Forms.DateTimePicker dtmTGBCTinhHinhMuon;
        private System.Windows.Forms.Button btnTKTinhHinhMuon;
        private System.Windows.Forms.Button btnXuatExcelBCTraTre;
    }
}