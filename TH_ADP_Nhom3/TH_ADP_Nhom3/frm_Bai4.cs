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
    public partial class frm_Bai4 : Form
    {
        public frm_Bai4()
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
            int? a = string.IsNullOrWhiteSpace(txt_a.Text) ? null : int.TryParse(txt_a.Text, out int tempA) ? (int?)tempA : null;
            int? b = string.IsNullOrWhiteSpace(txt_b.Text) ? null : int.TryParse(txt_b.Text, out int tempB) ? (int?)tempB : null;
            int? c = string.IsNullOrWhiteSpace(txt_c.Text) ? null : int.TryParse(txt_c.Text, out int tempC) ? (int?)tempC : null;

            if (a == null && b == null && c == null)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một số.");
                return;
            }

            int max = int.MinValue;
            string resultText = "Số lớn nhất của ";

            if (a.HasValue)
            {
                max = a.Value;
                resultText += a.Value.ToString();
            }
            if (b.HasValue)
            {
                if (!string.IsNullOrEmpty(resultText.Trim('S', 'ố', ' ', 'l', 'ớ', 'n', 'h', 'ấ', 't', 'c', 'ủ', 'a')))
                {
                    resultText += ", ";
                }
                max = Math.Max(max, b.Value);
                resultText += b.Value.ToString();
            }
            if (c.HasValue)
            {
                if (!string.IsNullOrEmpty(resultText.Trim('S', 'ố', ' ', 'l', 'ớ', 'n', 'h', 'ấ', 't', 'c', 'ủ', 'a')))
                {
                    resultText += ", ";
                }
                max = Math.Max(max, c.Value);
                resultText += c.Value.ToString();
            }

            resultText += $" là {max}";
            txt_Ketqua.Text = resultText;
        }
    }
}
