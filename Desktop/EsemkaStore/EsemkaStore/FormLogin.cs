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

namespace EsemkaStore
{
    public partial class FormLogin : Form
    {
        SqlConnection _Conn = new SqlConnection();
        string query;

        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            if(TxtEmail.Text == "" || TxtPassword.Text == "")
            {
                MessageBox.Show("Value can't be empty");
            }
            else
            {
                _Conn.Open();
                query = "SELECT * FROM Users WHERE Email = " + TxtEmail.Text + " AND Password = " + TxtPassword.Text;
                SqlDataAdapter SDA = new SqlDataAdapter(query, _Conn);
                DataTable DT = new DataTable();
                SDA.Fill(DT);
                if(DT.Rows.Count > 0)
                {
                    foreach(DataRow DR in DT.Rows)
                    {
                        if (DR["Role"].ToString() == "Admin")
                        {

                        } else
                        {

                        }
                    }
                }
                _Conn.Close();
            }
        }
    }
}
