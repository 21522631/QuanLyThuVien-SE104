namespace GUI
{
    partial class fTraCuuSach
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
            this.tabTraCuuSach = new System.Windows.Forms.TabControl();
            this.tabpgTracCuuSach = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSach = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTraCuuSach = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabpgTraCuuLoaiDocGia = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvLoaiDocGia = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTraCuuLoaiDocGia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabTraCuuSach.SuspendLayout();
            this.tabpgTracCuuSach.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.tabpgTraCuuLoaiDocGia.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDocGia)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTraCuuSach
            // 
            this.tabTraCuuSach.Controls.Add(this.tabpgTracCuuSach);
            this.tabTraCuuSach.Controls.Add(this.tabpgTraCuuLoaiDocGia);
            this.tabTraCuuSach.Location = new System.Drawing.Point(12, 19);
            this.tabTraCuuSach.Name = "tabTraCuuSach";
            this.tabTraCuuSach.SelectedIndex = 0;
            this.tabTraCuuSach.Size = new System.Drawing.Size(776, 413);
            this.tabTraCuuSach.TabIndex = 1;
            // 
            // tabpgTracCuuSach
            // 
            this.tabpgTracCuuSach.Controls.Add(this.groupBox1);
            this.tabpgTracCuuSach.Controls.Add(this.label6);
            this.tabpgTracCuuSach.Controls.Add(this.groupBox2);
            this.tabpgTracCuuSach.Location = new System.Drawing.Point(4, 22);
            this.tabpgTracCuuSach.Name = "tabpgTracCuuSach";
            this.tabpgTracCuuSach.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgTracCuuSach.Size = new System.Drawing.Size(768, 387);
            this.tabpgTracCuuSach.TabIndex = 0;
            this.tabpgTracCuuSach.Text = "Tra cứu sách";
            this.tabpgTracCuuSach.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSach);
            this.groupBox1.Location = new System.Drawing.Point(6, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 274);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tra cứu";
            // 
            // dgvSach
            // 
            this.dgvSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSach.Location = new System.Drawing.Point(6, 19);
            this.dgvSach.Name = "dgvSach";
            this.dgvSach.Size = new System.Drawing.Size(752, 249);
            this.dgvSach.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "TRA CỨU THÔNG TIN SÁCH";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTraCuuSach);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(6, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(756, 73);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tra cứu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label1.Location = new System.Drawing.Point(180, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "(Nhập mã sách, tên sách, mã thể loại, tên thể loại, nhà xuất bản hoặc năm xuất bả" +
    "n)";
            // 
            // txtTraCuuSach
            // 
            this.txtTraCuuSach.Location = new System.Drawing.Point(233, 16);
            this.txtTraCuuSach.Name = "txtTraCuuSach";
            this.txtTraCuuSach.Size = new System.Drawing.Size(296, 20);
            this.txtTraCuuSach.TabIndex = 1;
            this.txtTraCuuSach.TextChanged += new System.EventHandler(this.txtTraCuuSach_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhập thông tin tra cứu";
            // 
            // tabpgTraCuuLoaiDocGia
            // 
            this.tabpgTraCuuLoaiDocGia.Controls.Add(this.groupBox4);
            this.tabpgTraCuuLoaiDocGia.Controls.Add(this.groupBox3);
            this.tabpgTraCuuLoaiDocGia.Controls.Add(this.label2);
            this.tabpgTraCuuLoaiDocGia.Location = new System.Drawing.Point(4, 22);
            this.tabpgTraCuuLoaiDocGia.Name = "tabpgTraCuuLoaiDocGia";
            this.tabpgTraCuuLoaiDocGia.Padding = new System.Windows.Forms.Padding(3);
            this.tabpgTraCuuLoaiDocGia.Size = new System.Drawing.Size(768, 387);
            this.tabpgTraCuuLoaiDocGia.TabIndex = 1;
            this.tabpgTraCuuLoaiDocGia.Text = "Tra cứu loại độc giả";
            this.tabpgTraCuuLoaiDocGia.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvLoaiDocGia);
            this.groupBox4.Location = new System.Drawing.Point(6, 107);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(756, 274);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin tra cứu";
            // 
            // dgvLoaiDocGia
            // 
            this.dgvLoaiDocGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDocGia.Location = new System.Drawing.Point(6, 19);
            this.dgvLoaiDocGia.Name = "dgvLoaiDocGia";
            this.dgvLoaiDocGia.Size = new System.Drawing.Size(752, 249);
            this.dgvLoaiDocGia.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtTraCuuLoaiDocGia);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(6, 30);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(756, 73);
            this.groupBox3.TabIndex = 24;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tra cứu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label3.Location = new System.Drawing.Point(221, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "(Nhập mã độc giả, tên độc giả, mã loại độc giả hoặc loại độc giả)";
            // 
            // txtTraCuuLoaiDocGia
            // 
            this.txtTraCuuLoaiDocGia.Location = new System.Drawing.Point(233, 16);
            this.txtTraCuuLoaiDocGia.Name = "txtTraCuuLoaiDocGia";
            this.txtTraCuuLoaiDocGia.Size = new System.Drawing.Size(296, 20);
            this.txtTraCuuLoaiDocGia.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nhập thông tin tra cứu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "TRA CỨU THÔNG TIN LOẠI ĐỘC GỈA";
            // 
            // fTraCuuSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabTraCuuSach);
            this.Name = "fTraCuuSach";
            this.Text = "Tra Cứu Thông Tin Sách";
            this.Load += new System.EventHandler(this.fTraCuuSach_Load);
            this.tabTraCuuSach.ResumeLayout(false);
            this.tabpgTracCuuSach.ResumeLayout(false);
            this.tabpgTracCuuSach.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSach)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabpgTraCuuLoaiDocGia.ResumeLayout(false);
            this.tabpgTraCuuLoaiDocGia.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDocGia)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTraCuuSach;
        private System.Windows.Forms.TabPage tabpgTracCuuSach;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTraCuuSach;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tabpgTraCuuLoaiDocGia;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvLoaiDocGia;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTraCuuLoaiDocGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}