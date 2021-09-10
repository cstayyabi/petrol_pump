using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Stock : Form
    {
        public Stock()
        {
            InitializeComponent();
        }

        private void ADD_HSD_STOCK_Click(object sender, EventArgs e)
        {
            ADDStock ad = new ADDStock();
            ad.ShowDialog();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard();
            f.Show();
        }
    }
}
