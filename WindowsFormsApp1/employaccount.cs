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
    public partial class employaccount : Form
    {
        public employaccount()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            chooseaccountstype cat = new chooseaccountstype();
            cat.Show();
        }

        private void addemploybutton_Click(object sender, EventArgs e)
        {
            addemploy ae = new addemploy();
            ae.ShowDialog();
        }
    }
}
