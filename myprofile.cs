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
    public partial class myprofile : Form
    {
        string u;
        public myprofile()
        {
            InitializeComponent();
        }
        public myprofile(string text)
        {
            InitializeComponent();
             u = text;
            MessageBox.Show("constructor called"+text);
        }

        private void myprofile_Load(object sender, EventArgs e)
        {
            this.lbloutput.Text = u;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "select * from info where username = '" + this.userbtn.Text + "' and pass= '" + this.passbtn.Text + "';";
            SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\semester 6\\final\\database\\database.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            sqlcon.Open();// open connection
            SqlCommand sqlCom = new SqlCommand(sql, sqlcon);//query command and connection string
            SqlDataAdapter sda = new SqlDataAdapter(sqlCom); // query run , query command as parameter
            DataSet ds = new DataSet();//store query result
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                if(newpasstxt.Text != "")
                {
                    string cp = "update info set pass ='" + this.newpasstxt.Text + "' where username='" + this.userbtn.Text + "';";
                    SqlCommand sqlComcp = new SqlCommand(cp, sqlcon);//query command and connection string
                    SqlDataAdapter sdacp = new SqlDataAdapter(sqlComcp); // query run , query command as parameter
                    DataSet dscp = new DataSet();//store query result
                    sdacp.Fill(dscp);
                    MessageBox.Show("update complete");
                    
                }
                else if(changeusertxt.Text != "")
                {
                    string cp = "update info set username ='" + this.changeusertxt.Text + "' where username='" + this.userbtn.Text + "';";
                    SqlCommand sqlComcp = new SqlCommand(cp, sqlcon);//query command and connection string
                    SqlDataAdapter sdacp = new SqlDataAdapter(sqlComcp); // query run , query command as parameter
                    DataSet dscp = new DataSet();//store query result
                    sdacp.Fill(dscp);
                    MessageBox.Show("update complete");
                }
                else if (phntxt.Text != "")
                {
                    string cp = "update info set mobile ='" + this.phntxt.Text + "' where username='" + this.userbtn.Text + "';";
                    SqlCommand sqlComcp = new SqlCommand(cp, sqlcon);//query command and connection string
                    SqlDataAdapter sdacp = new SqlDataAdapter(sqlComcp); // query run , query command as parameter
                    DataSet dscp = new DataSet();//store query result
                    sdacp.Fill(dscp);
                    MessageBox.Show("update complete");
                }


            }
            sqlcon.Close();
            //sucessful but little prob

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new homepage().Show();
            this.Hide();
        }

        private void myprofile_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void lbloutput_Click(object sender, EventArgs e)
        {
            lbloutput.Text = u;
        }
    }
}
