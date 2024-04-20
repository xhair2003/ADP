using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TH_ADP_Nhom3
{
    public partial class frm_Bai14 : Form
    {
        public frm_Bai14()
        {
            InitializeComponent();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main main = new frm_Main();
            main.Show();
            this.Hide();
        }

        private void txt_Chuoi_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Tinh_Click(object sender, EventArgs e)
        {
            // Đọc chuỗi từ TextBox txt_Chuoi
            string input = txt_Chuoi.Text;

            // Loại bỏ các khoảng trắng thừa và chuyển chuỗi thành dạng tiêu đề
            string result = NormalizeTitleCase(input);

            // Hiển thị kết quả sau khi chuyển đổi trên TextBox txt_Ketqua
            txt_Ketqua.Text = result;
        }

        // Hàm chuyển chuỗi thành dạng tiêu đề sau khi loại bỏ các ký tự thừa
        private string NormalizeTitleCase(string input)
        {
            // Loại bỏ các khoảng trắng thừa ở đầu và cuối chuỗi
            input = input.Trim();

            // Tạo đối tượng TextInfo để sử dụng các phương thức của lớp TextInfo
            TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;

            // Chuyển đổi chuỗi thành dạng title case (viết hoa chữ cái đầu của mỗi từ)
            string result = textInfo.ToTitleCase(input.ToLower());

            return result;
        }

    }
}
