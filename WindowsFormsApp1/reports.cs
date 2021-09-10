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
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard f = new Dashboard();
            f.Show();
        }

        private void MO_R_Click(object sender, EventArgs e)
        {
            this.Hide();
            getmoreport gmr = new getmoreport();
            gmr.Show();
        }

        private void cdr_Click(object sender, EventArgs e)
        {

        }
    }
}
