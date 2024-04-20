namespace TH_ADP_Nhom3
{
    partial class frm_Bai1
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
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Chieudai = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Chieurong = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Ketqua = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.homeToolStripMenuItem.Text = "Quay lại";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(296, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Chieudai
            // 
            this.txt_Chieudai.Location = new System.Drawing.Point(154, 90);
            this.txt_Chieudai.Name = "txt_Chieudai";
            this.txt_Chieudai.Size = new System.Drawing.Size(217, 20);
            this.txt_Chieudai.TabIndex = 2;
            this.txt_Chieudai.TextChanged += new System.EventHandler(this.txt_Chieudai_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Chieu dai";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Chieu Rong";
            // 
            // txt_Chieurong
            // 
            this.txt_Chieurong.Location = new System.Drawing.Point(154, 141);
            this.txt_Chieurong.Name = "txt_Chieurong";
            this.txt_Chieurong.Size = new System.Drawing.Size(217, 20);
            this.txt_Chieurong.TabIndex = 4;
            this.txt_Chieurong.TextChanged += new System.EventHandler(this.txt_Chieurong_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Dien tich hinh chu nhat";
            // 
            // txt_Ketqua
            // 
            this.txt_Ketqua.Location = new System.Drawing.Point(208, 194);
            this.txt_Ketqua.Name = "txt_Ketqua";
            this.txt_Ketqua.Size = new System.Drawing.Size(163, 20);
            this.txt_Ketqua.TabIndex = 6;
            this.txt_Ketqua.TextChanged += new System.EventHandler(this.txt_Ketqua_TextChanged);
            // 
            // frm_Bai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 380);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Ketqua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Chieurong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Chieudai);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Bai1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai1";
            this.Load += new System.EventHandler(this.frm_Bai1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Chieudai;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Chieurong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Ketqua;
    }
}