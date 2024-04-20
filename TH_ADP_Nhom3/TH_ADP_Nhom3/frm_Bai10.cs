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
    public partial class frm_Bai10 : Form
    {
        public frm_Bai10()
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
            // Đọc số nguyên từ TextBox txt_a
            string input = txt_a.Text;

            // Kiểm tra xem người dùng đã nhập số nguyên hay chưa
            if (long.TryParse(input, out long number))
            {
                // Gọi hàm để kiểm tra số có đối xứng hay không và lưu kết quả vào biến isPalindrome
                bool isPalindrome = IsPalindromeNumber(number);

                // Hiển thị kết quả kiểm tra trên TextBox txt_Ketqua
                if (isPalindrome)
                {
                    txt_Ketqua.Text = $"Số {input} là số đối xứng";
                }
                else
                {
                    txt_Ketqua.Text = $"Số {input} không đối xứng";
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.");
            }
        }

        // Hàm kiểm tra số có đối xứng hay không
        private bool IsPalindromeNumber(long number)
        {
            string str = number.ToString();
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }

            return true;
        }

    }
}
