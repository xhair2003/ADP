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
    public partial class frm_Bai15 : Form
    {
        public frm_Bai15()
        {
            InitializeComponent();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main main = new frm_Main();
            main.Show();
            this.Hide();
        }

        private void txt_Mang_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt_Ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tinh_Click(object sender, EventArgs e)
        {
            // Đọc chuỗi nhập vào từ TextBox txt_Mang
            string input = txt_Mang.Text;

            // Tách chuỗi thành các phần tử (số nguyên) dựa trên dấu phẩy
            string[] parts = input.Split(',');

            // Khởi tạo mảng để lưu các số nguyên từ chuỗi
            int[] numbers = new int[parts.Length];

            // Đếm số lẻ trong mảng
            int oddCount = 0;

            // Chuyển các phần tử từ chuỗi sang số nguyên và đếm số lẻ
            for (int i = 0; i < parts.Length; i++)
            {
                if (int.TryParse(parts[i].Trim(), out numbers[i]))
                {
                    if (numbers[i] % 2 != 0) // Kiểm tra số lẻ
                    {
                        oddCount++;
                    }
                }
                else
                {
                    MessageBox.Show($"Phần tử thứ {i + 1} không phải là số nguyên hợp lệ.");
                    return;
                }
            }

            // Hiển thị kết quả đếm số lẻ trên TextBox txt_Ketqua
            txt_Ketqua.Text = $"Mảng đã cho có {oddCount} số lẻ";
        }

    }
}
