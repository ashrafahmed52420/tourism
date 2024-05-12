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
    public partial class booktr2 : Form
    {
        public booktr2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "update info set mobile ='" + this.phntxt.Text + "' where username='" + this.usertxt.Text + "';";
            SqlConnection sqlcon = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\semester 6\\final\\database\\database.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=false");
            sqlcon.Open();// open connection
            SqlCommand sqlCom = new SqlCommand(sql, sqlcon);//query command and connection string
            SqlDataAdapter sda = new SqlDataAdapter(sqlCom); // query run , query command as parameter
            DataSet ds = new DataSet();//store query result
            sda.Fill(ds);
            sqlcon.Close();
            //calculate price
            try
            {
                int pint = int.Parse(pvaluetxt.Text);//string input to integer
                // Use integerValue
                string net = (pint * 15000).ToString(); // Convert result to string
                price p = new price(net);
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input for pvaluetxt. Please enter a valid integer.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new login().Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new tr1().Show();
            this.Hide();
        }

        private void booktr2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
