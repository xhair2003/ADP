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
    public partial class frm_Bai2 : Form
    {
        public frm_Bai2()
        {
            InitializeComponent();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main main = new frm_Main();
            main.Show();
            this.Hide();
        }

        private void frm_Bai2_Load(object sender, EventArgs e)
        {

        }

        private void txt_Tinh_Click(object sender, EventArgs e)
        {
            double num1, num2;
            string phepTinh = txt_Pheptinh.Text;
            double ketQua = 0;

            // Kiểm tra xem người dùng đã nhập đúng định dạng số cho a và b hay chưa
            if (double.TryParse(txt_a.Text, out num1) && double.TryParse(txt_b.Text, out num2))
            {
                // Thực hiện tính toán dựa trên phép tính được nhập
                switch (phepTinh)
                {
                    case "+":
                        ketQua = num1 + num2;
                        break;
                    case "-":
                        ketQua = num1 - num2;
                        break;
                    case "*":
                        ketQua = num1 * num2;
                        break;
                    case "/":
                        // Kiểm tra trường hợp chia cho 0
                        if (num2 != 0)
                        {
                            ketQua = num1 / num2;
                        }
                        else
                        {
                            MessageBox.Show("Không thể chia cho 0.");
                            return;
                        }
                        break;
                    default:
                        MessageBox.Show("Phép tính không hợp lệ. Vui lòng nhập +, -, * hoặc /.");
                        return;
                }

                // Hiển thị kết quả
                txt_Ketqua.Text = $"{num1} {phepTinh} {num2} = {ketQua}";
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đúng số cho a và b.");
            }
        }

        private void txt_a_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_b_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Pheptinh_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ketqua_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
