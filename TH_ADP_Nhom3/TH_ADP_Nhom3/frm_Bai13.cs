using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_ADP_Nhom3
{
    public partial class frm_Bai13 : Form
    {
        public frm_Bai13()
        {
            InitializeComponent();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main main = new frm_Main();
            main.Show();
            this.Hide();
        }

        private void txt_Ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Chuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tinh_Click(object sender, EventArgs e)
        {
            // Đọc chuỗi từ TextBox txt_Chuoi
            string input = txt_Chuoi.Text;

            // Tách các từ trong chuỗi và loại bỏ các khoảng trắng thừa
            string[] words = input.Trim().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Đếm số từ trong mảng words
            int wordCount = words.Length;

            // Hiển thị kết quả đếm trên TextBox txt_Ketqua
            txt_Ketqua.Text = $"Chuỗi đó có {wordCount} từ";
        }

    }
}
