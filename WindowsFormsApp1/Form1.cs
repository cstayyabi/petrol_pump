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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void account_Click(object sender, EventArgs e)
        {
            this.Hide();
            chooseaccountstype ac = new chooseaccountstype();
            ac.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Stock_Click(object sender, EventArgs e)
        {
            this.Hide();
            Stock ST = new Stock();
            ST.Show();
        }

        private void Sale_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sale S = new Sale();
            S.Show();
        }

        private void Admin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Admin a = new Admin();
            a.Show();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            reports r = new reports();
            r.Show();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
