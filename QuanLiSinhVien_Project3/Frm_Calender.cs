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
    public partial class Frm_Calender : Form
    {
        public Frm_Calender()
        {
            InitializeComponent();
        }

        public GiaoDienChinh frm;
        public delegate void _dongTap();
        public _dongTap DongTap;

        private void btnNext_Click(object sender, EventArgs e)
        {

        }

        private void dtkpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSaturday_Click(object sender, EventArgs e)
        {

        }

        private void btnFriday_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Calender_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DongTap();
        }
    }
}
