using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace DBSecurity
{
    public partial class frmSuggestion : Form
    {
        public frmSuggestion()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
          
            string serverIP = txtServerIP.Text;
            string cs = "DATA SOURCE="+serverIP+";INITIAL CATALOG=HR;UID=SA;PWD=Password1;";
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string sql = "INSERT INTO SUGGESTION (NAMESURNAME,DATE_,SUGGESTIONTEXT)";
            sql = sql + " VALUES ('" + txtNameSurname.Text + "',GETDATE(),'" + txtSuggestion.Text + "');";
                sql = sql + "SELECT @@IDENTITY;";
            cmd.CommandText = sql;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);


            if (ds.Tables[0].Rows.Count>0)
            {
                string  id;
                id = ds.Tables[0].Rows[0][0].ToString();
                MessageBox.Show("Your suggestion has been posted. ID:" + id);
             
            }

         
          

        }
    }
}
