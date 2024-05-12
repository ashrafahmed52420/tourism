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
    public partial class tr2 : Form
    {
        public tr2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void tr2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new booktr2().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new bandarban().Show();
            this.Hide();
        }
    }
}
