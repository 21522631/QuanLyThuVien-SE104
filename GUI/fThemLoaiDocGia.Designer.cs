﻿namespace GUI
{
    partial class fThemLoaiDocGia
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
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.txtTenLoaiDocGia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHuy);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Controls.Add(this.txtTenLoaiDocGia);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(266, 120);
            this.panel1.TabIndex = 0;
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(186, 85);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(67, 23);
            this.btnHuy.TabIndex = 38;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(113, 85);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(67, 23);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // txtTenLoaiDocGia
            // 
            this.txtTenLoaiDocGia.Location = new System.Drawing.Point(105, 50);
            this.txtTenLoaiDocGia.Name = "txtTenLoaiDocGia";
            this.txtTenLoaiDocGia.Size = new System.Drawing.Size(148, 20);
            this.txtTenLoaiDocGia.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên loại độc giả";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG TIN LOẠI ĐỘC GIẢ";
            // 
            // fThemLoaiDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 143);
            this.Controls.Add(this.panel1);
            this.Name = "fThemLoaiDocGia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm Loại Độc Giả";
            this.Load += new System.EventHandler(this.fThemLoaiDocGia_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTenLoaiDocGia;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
    }
}