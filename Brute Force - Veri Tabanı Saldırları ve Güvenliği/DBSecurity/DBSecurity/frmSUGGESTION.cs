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
    public partial class frmSUGGESTION : Form
    {
        public frmSUGGESTION()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cs = "DATA SOURCE = 192.168.0.29;INITAL CATALOG=HRTEST;UID=SA;PWD=Password1;";
            SqlConnection conn = new SqlConnection(cs);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            string sql = "INSERT INTO SUGGESTION (NAMESURNAME,SUGGESTIONTEST,DATE_)";
            sql = sql + "VALUES('" + txtNameSurname.Text + "','" + txtSuggestion.Text + "',GETDATE());";
            sql = sql + "SELECT @@IDENTITY;";
            cmd.CommandText = sql;


            SqlDataAdapter data = new SqlDataAdapter(cmd);
            DataSet dataset = new DataSet();
            data.Fill(dataset);


            if (dataset.Tables[0].Rows.Count > 0)
            {
                int id;
                id = Convert.ToInt16(dataset.Tables[0].Rows[0][0]);
                MessageBox.Show("Your suggestion has beeen posted." + id.ToString());
            }
        }
    }
}
