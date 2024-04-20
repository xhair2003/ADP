namespace TH_ADP_Nhom3
{
    partial class frm_Bai2
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Pheptinh = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_b = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_a = new System.Windows.Forms.TextBox();
            this.txt_Tinh = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Ketqua = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quayLạiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(522, 24);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Phep tinh";
            // 
            // txt_Pheptinh
            // 
            this.txt_Pheptinh.Location = new System.Drawing.Point(192, 213);
            this.txt_Pheptinh.Name = "txt_Pheptinh";
            this.txt_Pheptinh.Size = new System.Drawing.Size(40, 20);
            this.txt_Pheptinh.TabIndex = 13;
            this.txt_Pheptinh.TextChanged += new System.EventHandler(this.txt_Pheptinh_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "So b";
            // 
            // txt_b
            // 
            this.txt_b.Location = new System.Drawing.Point(153, 174);
            this.txt_b.Name = "txt_b";
            this.txt_b.Size = new System.Drawing.Size(251, 20);
            this.txt_b.TabIndex = 11;
            this.txt_b.TextChanged += new System.EventHandler(this.txt_b_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "So a";
            // 
            // txt_a
            // 
            this.txt_a.Location = new System.Drawing.Point(153, 123);
            this.txt_a.Name = "txt_a";
            this.txt_a.Size = new System.Drawing.Size(251, 20);
            this.txt_a.TabIndex = 9;
            this.txt_a.TextChanged += new System.EventHandler(this.txt_a_TextChanged);
            // 
            // txt_Tinh
            // 
            this.txt_Tinh.Location = new System.Drawing.Point(329, 304);
            this.txt_Tinh.Name = "txt_Tinh";
            this.txt_Tinh.Size = new System.Drawing.Size(75, 23);
            this.txt_Tinh.TabIndex = 8;
            this.txt_Tinh.Text = "Solve";
            this.txt_Tinh.UseVisualStyleBackColor = true;
            this.txt_Tinh.Click += new System.EventHandler(this.txt_Tinh_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ket qua";
            // 
            // txt_Ketqua
            // 
            this.txt_Ketqua.Location = new System.Drawing.Point(168, 253);
            this.txt_Ketqua.Name = "txt_Ketqua";
            this.txt_Ketqua.Size = new System.Drawing.Size(236, 20);
            this.txt_Ketqua.TabIndex = 15;
            this.txt_Ketqua.TextChanged += new System.EventHandler(this.txt_Ketqua_TextChanged);
            // 
            // frm_Bai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_Ketqua);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Pheptinh);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_b);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_a);
            this.Controls.Add(this.txt_Tinh);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Bai2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bai2";
            this.Load += new System.EventHandler(this.frm_Bai2_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quayLạiToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Pheptinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_b;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_a;
        private System.Windows.Forms.Button txt_Tinh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Ketqua;
    }
}