namespace GUI
{
    partial class fThemChucNang
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
            this.txtTenManHinhDuocLoad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTenChucNang = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtTenManHinhDuocLoad);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtTenChucNang);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(268, 132);
            this.panel1.TabIndex = 1;
            // 
            // txtTenManHinhDuocLoad
            // 
            this.txtTenManHinhDuocLoad.Location = new System.Drawing.Point(135, 67);
            this.txtTenManHinhDuocLoad.Name = "txtTenManHinhDuocLoad";
            this.txtTenManHinhDuocLoad.Size = new System.Drawing.Size(122, 20);
            this.txtTenManHinhDuocLoad.TabIndex = 77;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 76;
            this.label9.Text = "Tên màn hình được load";
            // 
            // txtTenChucNang
            // 
            this.txtTenChucNang.Location = new System.Drawing.Point(135, 41);
            this.txtTenChucNang.Name = "txtTenChucNang";
            this.txtTenChucNang.Size = new System.Drawing.Size(122, 20);
            this.txtTenChucNang.TabIndex = 75;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 48);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Tên chức năng";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(182, 101);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 73;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(101, 101);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 72;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(69, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 15);
            this.label6.TabIndex = 66;
            this.label6.Text = "THÔNG TIN CHỨC NĂNG";
            // 
            // fThemChucNang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 151);
            this.Controls.Add(this.panel1);
            this.Name = "fThemChucNang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Chức Năng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenManHinhDuocLoad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTenChucNang;
        private System.Windows.Forms.Label label8;
    }
}