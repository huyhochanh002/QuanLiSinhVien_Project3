using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLiSinhVien_Project3
{
    public partial class Frm_QuanLyDiemSV : Form
    {
        public Frm_QuanLyDiemSV()
        {
            InitializeComponent();
        }

        public GiaoDienChinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;
        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
