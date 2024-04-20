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
    public partial class frm_Bai5 : Form
    {
        public frm_Bai5()
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

        private void txt_Ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tinh_Click(object sender, EventArgs e)
        {
            int a;
            if (int.TryParse(txt_a.Text, out a))
            {
                if (IsPrime(a))
                {
                    txt_Ketqua.Text = $"{a} là số nguyên tố";
                }
                else
                {
                    txt_Ketqua.Text = $"{a} không phải là số nguyên tố";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.");
            }
        }
        // Hàm kiểm tra số nguyên tố
        private bool IsPrime(int number)
        {
            if (number <= 1)
                return false;
            if (number <= 3)
                return true;
            if (number % 2 == 0 || number % 3 == 0)
                return false;
            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0)
                    return false;
            }
            return true;
        }

        private void frm_Bai5_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }

}
