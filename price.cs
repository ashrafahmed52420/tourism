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
    public partial class price : Form
    {
        public price()
        {
            InitializeComponent();
        }
        public price(string a)
        {
            InitializeComponent();
            MessageBox.Show(a);
        }

        private void price_Load(object sender, EventArgs e)
        {

        }

        private void price_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
