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
    public partial class frm_Bai9 : Form
    {
        public frm_Bai9()
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
            if (int.TryParse(input, out int number))
            {
                // Gọi hàm để đảo ngược số và lưu kết quả vào biến reversed
                string reversed = ReverseNumber(number);

                // Hiển thị kết quả đảo ngược trên TextBox txt_Ketqua
                txt_Ketqua.Text = reversed;
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.");
            }
        }

        // Hàm đảo ngược số nguyên
        private string ReverseNumber(int number)
        {
            // Chuyển số nguyên thành chuỗi
            string str = number.ToString();

            // Chuyển chuỗi thành mảng ký tự và đảo ngược mảng
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);

            // Chuyển mảng ký tự thành chuỗi và trả về
            return new string(charArray);
        }

    }
}
