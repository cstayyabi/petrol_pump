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
    public partial class expensesform : Form
    {
        public expensesform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            chooseaccountstype cat = new chooseaccountstype();
            cat.Show();
        }

        private void AE_Click(object sender, EventArgs e)
        {
            addexpenses ad = new addexpenses();
            ad.ShowDialog();
        }
    }
}
