namespace GUI
{
    partial class fDocGia
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTraCuuSach = new System.Windows.Forms.Button();
            this.btnSachDangMuon = new System.Windows.Forms.Button();
            this.btnSachDaMuon = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThongTin = new System.Windows.Forms.Button();
            this.lblTenNguoiDung = new System.Windows.Forms.Label();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(7, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 63);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSachDaMuon);
            this.panel2.Controls.Add(this.btnSachDangMuon);
            this.panel2.Controls.Add(this.btnTraCuuSach);
            this.panel2.Location = new System.Drawing.Point(7, 75);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(755, 33);
            this.panel2.TabIndex = 1;
            // 
            // btnTraCuuSach
            // 
            this.btnTraCuuSach.Location = new System.Drawing.Point(152, 3);
            this.btnTraCuuSach.Name = "btnTraCuuSach";
            this.btnTraCuuSach.Size = new System.Drawing.Size(109, 23);
            this.btnTraCuuSach.TabIndex = 2;
            this.btnTraCuuSach.Text = "Tra Cứu Sách";
            this.btnTraCuuSach.UseVisualStyleBackColor = true;
            // 
            // btnSachDangMuon
            // 
            this.btnSachDangMuon.Location = new System.Drawing.Point(327, 3);
            this.btnSachDangMuon.Name = "btnSachDangMuon";
            this.btnSachDangMuon.Size = new System.Drawing.Size(109, 23);
            this.btnSachDangMuon.TabIndex = 3;
            this.btnSachDangMuon.Text = "Sách Đang Mượn";
            this.btnSachDangMuon.UseVisualStyleBackColor = true;
            // 
            // btnSachDaMuon
            // 
            this.btnSachDaMuon.Location = new System.Drawing.Point(495, 3);
            this.btnSachDaMuon.Name = "btnSachDaMuon";
            this.btnSachDaMuon.Size = new System.Drawing.Size(109, 23);
            this.btnSachDaMuon.TabIndex = 4;
            this.btnSachDaMuon.Text = "Sách Đã Mượn";
            this.btnSachDaMuon.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(7, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(765, 257);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(7, 377);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(765, 55);
            this.panel4.TabIndex = 3;
            // 
            // btnThongTin
            // 
            this.btnThongTin.Location = new System.Drawing.Point(640, 17);
            this.btnThongTin.Name = "btnThongTin";
            this.btnThongTin.Size = new System.Drawing.Size(109, 23);
            this.btnThongTin.TabIndex = 5;
            this.btnThongTin.Text = "Thông tin";
            this.btnThongTin.UseVisualStyleBackColor = true;
            // 
            // lblTenNguoiDung
            // 
            this.lblTenNguoiDung.AutoSize = true;
            this.lblTenNguoiDung.Location = new System.Drawing.Point(536, 22);
            this.lblTenNguoiDung.Name = "lblTenNguoiDung";
            this.lblTenNguoiDung.Size = new System.Drawing.Size(86, 13);
            this.lblTenNguoiDung.TabIndex = 6;
            this.lblTenNguoiDung.Text = "Tên Người Dùng";
            this.lblTenNguoiDung.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Location = new System.Drawing.Point(640, 46);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(109, 23);
            this.btnDangXuat.TabIndex = 7;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = true;
            // 
            // fDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 444);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.lblTenNguoiDung);
            this.Controls.Add(this.btnThongTin);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fDocGia";
            this.Text = "Phần Mềm Quản Lý Thư Viện";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSachDaMuon;
        private System.Windows.Forms.Button btnSachDangMuon;
        private System.Windows.Forms.Button btnTraCuuSach;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnThongTin;
        private System.Windows.Forms.Label lblTenNguoiDung;
        private System.Windows.Forms.Button btnDangXuat;
    }
}