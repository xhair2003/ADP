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
    public partial class frm_Bai1 : Form
    {
        public frm_Bai1()
        {
            InitializeComponent();
        }

        private void frm_Bai1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Main main = new frm_Main();
            main.Show();
            this.Hide();
        }
    }
}
