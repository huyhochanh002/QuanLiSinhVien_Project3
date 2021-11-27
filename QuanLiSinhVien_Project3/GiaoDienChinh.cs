using DevComponents.DotNetBar;
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
    public partial class GiaoDienChinh : Form
    {
        public GiaoDienChinh()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GiaoDienChinh_Load(object sender, EventArgs e)
        {
            timedate.Start();
        }

        private void timedate_Tick(object sender, EventArgs e)
        {
            lb_thoigian.Text = string.Format("{0:HH:mm:ss tt}", DateTime.Now);
        }
        #region Kiem Tra Tab
        private String tentabmo;
        private bool Kiemtramotab(string name)
        {
            for (int i = 0; i < tabcontrol_center.Tabs.Count; i++)
            {
                if (tabcontrol_center.Tabs[i].Text == name)
                {
                    return true;
                }
            }
            return false;
        }
        private void DongTab()
        {
            foreach (TabItem item in tabcontrol_center.Tabs)
            {
                if (item.IsSelected == true)
                {
                    tabcontrol_center.Tabs.Remove(item);
                    return;
                }
            }
        }
        #endregion
    }
}
