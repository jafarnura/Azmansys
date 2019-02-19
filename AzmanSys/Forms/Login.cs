using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AzmanSys
{
    public partial class Login : Form
    {
        customerDbConn mysqlConn;
        public Login()
        {
            InitializeComponent();
            mysqlConn = new customerDbConn();
            mysqlConn.connect();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int r = 0;
            string sql = "SELECT count(*) FROM `tblLogin` WHERE Email='" + tbEmail.Text +"' AND Password ='"+ tbPassword.Text +"' ";

            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlConn.conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            r = Convert.ToInt32(dt.Rows[0][0].ToString());
            if(r == 1)
            {
                MessageBox.Show("Successful!!");
                Close();
                (new MainForm()).Show();
            } else
            {// This button show if you type correct password
                MessageBox.Show("Sorry Boss!!");
            }
        } // this button shows if you type incorrect password

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
