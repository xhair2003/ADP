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
    public partial class frm_Bai11 : Form
    {
        public frm_Bai11()
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
                // Gọi hàm để đếm số lần xuất hiện của chữ số '2' và lưu kết quả vào biến count
                int count = CountDigit2(number);

                // Hiển thị kết quả đếm trên TextBox txt_Ketqua
                txt_Ketqua.Text = $"Số {input} có {count} số 2";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên hợp lệ.");
            }
        }

        // Hàm đếm số lần xuất hiện của chữ số '2' trong số nguyên
        private int CountDigit2(long number)
        {
            // Chuyển số nguyên thành chuỗi
            string str = number.ToString();

            // Khởi tạo biến đếm
            int count = 0;

            // Duyệt qua từng ký tự trong chuỗi số
            foreach (char c in str)
            {
                // Kiểm tra nếu ký tự là '2' thì tăng biến đếm lên 1
                if (c == '2')
                {
                    count++;
                }
            }

            // Trả về số lần xuất hiện của chữ số '2'
            return count;
        }

        private void frm_Bai11_Load(object sender, EventArgs e)
        {

        }
    }
}
