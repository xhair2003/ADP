﻿namespace TH_ADP_Nhom3
{
    partial class frm_Bai14
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quayLạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_Ketqua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Chuoi = new System.Windows.Forms.TextBox();
            this.txt_Tinh = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(521, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quayLạiToolStripMenuItem
            // 
            this.quayLạiToolStripMenuItem.Name = "quayLạiToolStripMenuItem";
            this.quayLạiToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.quayLạiToolStripMenuItem.Text = "Quay lại";
            this.quayLạiToolStripMenuItem.Click += new System.EventHandler(this.quayLạiToolStripMenuItem_Click);
            // 
            // txt_Ketqua
            // 
            this.txt_Ketqua.Location = new System.Drawing.Point(169, 213);
            this.txt_Ketqua.Name = "txt_Ketqua";
            this.txt_Ketqua.Size = new System.Drawing.Size(251, 20);
            this.txt_Ketqua.TabIndex = 52;
            this.txt_Ketqua.TextChanged += new System.EventHandler(this.txt_Ketqua_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 51;
            this.label1.Text = "Nhap chuoi";
            // 
            // txt_Chuoi
            // 
            this.txt_Chuoi.Location = new System.Drawing.Point(169, 163);
            this.txt_Chuoi.Name = "txt_Chuoi";
            this.txt_Chuoi.Size = new System.Drawing.Size(251, 20);
            this.txt_Chuoi.TabIndex = 50;
            this.txt_Chuoi.TextChanged += new System.EventHandler(this.txt_Chuoi_TextChanged);
            // 
            // txt_Tinh
            // 
            this.txt_Tinh.Location = new System.Drawing.Point(345, 264);
            this.txt_Tinh.Name = "txt_Tinh";
            this.txt_Tinh.Size = new System.Drawing.Size(75, 23);
            this.txt_Tinh.TabIndex = 49;
            this.txt_Tinh.Text = "Sua";
            this.txt_Tinh.UseVisualStyleBackColor = true;
            this.txt_Tinh.Click += new System.EventHandler(this.txt_Tinh_Click);
            // 
            // frm_Bai14
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 450);
            this.Controls.Add(this.txt_Ketqua);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Chuoi);
            this.Controls.Add(this.txt_Tinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Bai14";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai14";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.TextBox txt_Ketqua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Chuoi;
        private System.Windows.Forms.Button txt_Tinh;
    }
}