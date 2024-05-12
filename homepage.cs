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
    public partial class homepage : Form
    {
        public homepage()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new bandarban().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new bandarban().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            new bandarban().Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new bandarban().Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            login log= new login();
            log.Show();
            this.Visible = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new myprofile().Show();
            this.Hide();
        }

        private void sajekbtn_Click(object sender, EventArgs e)
        {
            new bandarban().Show();
            this.Hide();
        }

        private void shylbtn_Click(object sender, EventArgs e)
        {
            new bandarban().Show();
            this.Hide();
        }
    }
}
