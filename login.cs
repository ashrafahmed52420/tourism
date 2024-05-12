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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string sql = "select * from info where username = '" + this.usernametxt.Text + "' and pass= '" + this.passtxt.Text + "';";
            SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\semester 6\\final\\database\\database.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            sqlcon.Open();// open connection
            SqlCommand sqlCom = new SqlCommand(sql, sqlcon);//query command and connection string
            SqlDataAdapter sda = new SqlDataAdapter(sqlCom); // query run , query command as parameter
            DataSet ds = new DataSet();//store query result
            sda.Fill(ds);
            if (ds.Tables[0].Rows.Count == 1)
            {
                string username = ds.Tables[0].Rows[0]["username"].ToString();
                myprofile m = new myprofile(username);//passs username in form myprofile
                new homepage().Show();
                this.Visible = false;//hide login form
                
                
            }
            
            else { MessageBox.Show("invalid user"); }
            sqlcon.Close();
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            reg r= new reg();
            r.Show();//same as new reg().show();
            this.Visible=false;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (check.Checked==true)
            {
                // If checkbox is checked, show the password
                passtxt.UseSystemPasswordChar = false;
            }
            else
            {
                // If checkbox is unchecked, hide the password
                passtxt.UseSystemPasswordChar=true;
            }
        }

        private void login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
