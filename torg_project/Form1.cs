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

namespace torg_project
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=torg_project;Integrated Security=True");
        private void button_login_Click(object sender, EventArgs e)
        {
            con.Open();
            if (login.Text == password.Text)
            {
                var com = new SqlCommand($"select * from personal where Login = '{login.Text}'", con);
                var reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    if (reader[3].ToString() == "")
                    {
                        var f1 = new Form_calculate();
                        Properties.Settings.Default.id_manager = reader[0].ToString();
                        Properties.Settings.Default.Save();
                        f1.Show();
                    }
                    else
                    {
                        var f2 = new Form_worker();
                        f2.Show();
                    }

                }
                else
                    MessageBox.Show("login is bad");
            }
            else
                MessageBox.Show("not");
            con.Close();
        }
    }
}
