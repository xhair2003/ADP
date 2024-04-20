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
    public partial class frm_Bai6 : Form
    {
        public frm_Bai6()
        {
            InitializeComponent();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main main = new frm_Main();
            main.Show();
            this.Hide();
        }

        private void txt_Tinh_Click(object sender, EventArgs e)
        {
            string thangNhap = txt_thang.Text.ToLower(); // Lấy tháng nhập từ người dùng và chuyển thành chữ thường

            int nam = 0; // Mặc định năm là 0 nếu không nhập năm
            bool nhapNam = int.TryParse(txt_nam.Text, out nam); // Kiểm tra người dùng có nhập năm hay không

            int soNgay = 0;

            // Kiểm tra tháng nhập và tính số ngày tương ứng
            switch (thangNhap)
            {
                case "1":
                case "tháng 1":
                case "january":
                    soNgay = 31;
                    break;
                case "2":
                case "tháng 2":
                case "february":
                    if (nhapNam && nam % 4 == 0 && (nam % 100 != 0 || nam % 400 == 0))
                    {
                        soNgay = 29; // Năm nhuận có 29 ngày trong tháng 2
                    }
                    else
                    {
                        soNgay = 28; // Năm không nhuận có 28 ngày trong tháng 2
                    }
                    break;
                case "3":
                case "tháng 3":
                case "march":
                    soNgay = 31;
                    break;
                case "4":
                case "tháng 4":
                case "april":
                    soNgay = 30;
                    break;
                case "5":
                case "tháng 5":
                case "may":
                    soNgay = 31;
                    break;
                case "6":
                case "tháng 6":
                case "june":
                    soNgay = 30;
                    break;
                case "7":
                case "tháng 7":
                case "july":
                    soNgay = 31;
                    break;
                case "8":
                case "tháng 8":
                case "august":
                    soNgay = 31;
                    break;
                case "9":
                case "tháng 9":
                case "september":
                    soNgay = 30;
                    break;
                case "10":
                case "tháng 10":
                case "october":
                    soNgay = 31;
                    break;
                case "11":
                case "tháng 11":
                case "november":
                    soNgay = 30;
                    break;
                case "12":
                case "tháng 12":
                case "december":
                    soNgay = 31;
                    break;
                default:
                    MessageBox.Show("Tháng không hợp lệ. Vui lòng nhập lại.");
                    return;
            }

            // Hiển thị kết quả
            txt_Ketqua.Text = $"{thangNhap} năm {nam} có {soNgay} ngày.";
        }


        private void txt_Ketqua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_thang_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_nam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
