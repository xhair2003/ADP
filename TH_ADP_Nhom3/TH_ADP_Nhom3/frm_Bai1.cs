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
    public partial class frm_Bai1 : Form
    {
        public frm_Bai1()
        {
            InitializeComponent();
        }

        private void frm_Bai1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main main = new frm_Main();
            main.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float chieuDai;
            float chieuRong;

            // Kiểm tra người dùng nhập vào chiều dài và chiều rộng có phải là số và lớn hơn 0
            if (float.TryParse(txt_Chieudai.Text, out chieuDai) && chieuDai > 0 &&
                float.TryParse(txt_Chieurong.Text, out chieuRong) && chieuRong > 0)
            {
                // Tính diện tích
                float dienTich = chieuDai * chieuRong;

                // Hiển thị kết quả
                txt_Ketqua.Text = dienTich.ToString();
            }
            else
            {
                MessageBox.Show("Nhập sai");
                txt_Chieudai.Clear();
                txt_Chieurong.Clear();
                txt_Ketqua.Clear();
            }

        }

        private void txt_Chieudai_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Chieurong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
