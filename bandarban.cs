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
    public partial class bandarban : Form
    {
        public bandarban()
        {
            InitializeComponent();
        }

        private void bandarbanbtn_Click(object sender, EventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void bandarban_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void t1btn_Click(object sender, EventArgs e)
        {
            new tr1().Show();
            this.Hide();
        }

        private void t2btn_Click(object sender, EventArgs e)
        {
            new tr2().Show();
            this.Hide();
        }

        private void t3btn_Click(object sender, EventArgs e)
        {
            new tr3().Show();
            this.Hide();
        }
    }
}
