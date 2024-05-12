using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class reg : Form
    {
        public reg()
        {
            InitializeComponent();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            if (this.passtxt.Text == this.conpasstxt.Text)
            {

                string sql = "insert into info(username,name, pass) values('" + this.usernametxt.Text + "','" + this.nametxt.Text + "', '" + this.passtxt.Text + "');";

                SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\semester 6\\final\\database\\database.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
                sqlcon.Open();// open connection
                SqlCommand sqlCom = new SqlCommand(sql, sqlcon);//query command and connection string
                SqlDataAdapter sda = new SqlDataAdapter(sqlCom); // query run , query command as parameter
                DataSet ds = new DataSet();//store query result
                sda.Fill(ds);
                sqlcon.Close();
                new login().Show();
                this.Visible = false;

            }
            else { MessageBox.Show("Please enter your information correctly"); }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Visible = false;
        }

        private void reg_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();//close window
        }
    }
}
