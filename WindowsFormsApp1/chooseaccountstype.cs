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
    public partial class chooseaccountstype : Form
    {
        public chooseaccountstype()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Hide();
            employaccount ea = new employaccount();
            ea.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            coustmer_Accounts a = new coustmer_Accounts();
            a.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            expensesform ef = new expensesform();
            ef.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Dashboard d = new Dashboard();
            d.Show();
        }
    }
}
