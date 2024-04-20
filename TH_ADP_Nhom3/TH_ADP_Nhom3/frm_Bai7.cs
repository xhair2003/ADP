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
    public partial class frm_Bai7 : Form
    {
        public frm_Bai7()
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

        private void txt_c_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tinh_Click(object sender, EventArgs e)
        {
            // Khai báo và khởi tạo mảng để lưu ba số
            int[] numbers = new int[3];

            // Đọc giá trị từ các TextBox và chuyển đổi thành số nguyên
            if (int.TryParse(txt_a.Text, out numbers[0]) &&
                int.TryParse(txt_b.Text, out numbers[1]) &&
                int.TryParse(txt_c.Text, out numbers[2]))
            {
                // Sắp xếp mảng số theo thứ tự tăng dần
                Array.Sort(numbers);

                // Hiển thị kết quả trên TextBox txt_Ketqua
                txt_Ketqua.Text = $"{numbers[0]}, {numbers[1]}, {numbers[2]}";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập ba số nguyên hợp lệ.");
            }
        }

    }
}
