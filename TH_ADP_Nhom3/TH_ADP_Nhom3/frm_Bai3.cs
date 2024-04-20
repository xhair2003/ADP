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
    public partial class frm_Bai3 : Form
    {
        public frm_Bai3()
        {
            InitializeComponent();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main main = new frm_Main();
            main.Show();
            this.Hide();
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tinh_Click(object sender, EventArgs e)
        {
            // Đọc hệ số a từ TextBox txt_a
            if (!double.TryParse(txt_a.Text, out double a))
            {
                MessageBox.Show("Vui lòng nhập hệ số a là một số hợp lệ.");
                return;
            }

            // Đọc hệ số b từ TextBox txt_b
            if (!double.TryParse(txt_b.Text, out double b))
            {
                MessageBox.Show("Vui lòng nhập hệ số b là một số hợp lệ.");
                return;
            }

            // Giải phương trình bậc nhất ax + b = 0
            if (a == 0)
            {
                if (b == 0)
                {
                    txt_Ketqua.Text = "Phương trình vô số nghiệm";
                }
                else
                {
                    txt_Ketqua.Text = "Phương trình vô nghiệm";
                }
            }
            else
            {
                double x = -b / a;
                txt_Ketqua.Text = $"Phương trình {a}x + {b} = 0 có nghiệm là: x = {x}";
            }
        }

    }
}
