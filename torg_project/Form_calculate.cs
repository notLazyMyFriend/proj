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
using System.Text.RegularExpressions;

namespace torg_project
{
    public partial class Form_calculate : Form
    {
        public Form_calculate()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = torg_project; Integrated Security = True");
        
        private void Form_calculate_Load(object sender, EventArgs e)
        {
            con.Open();
            
            var com = new SqlCommand($"select * from rate where id_personal = '{Properties.Settings.Default.id_manager.ToString()}'", con);
            var reader = com.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["id_personal"].ToString(), reader["Name"].ToString(), reader["Junior_min"], reader["Middle_min"] ,reader["Senior_min"],
                         reader["Коэффициент_для_Анализ_и_проектирование"].ToString(), reader["Коэффициент_для_Установка_оборудования"].ToString(), reader["Коэффициент_для_Техническое_обслуживание_и_сопровождение"].ToString(),
                         reader["Коэффициент_времени"].ToString(), reader["Коэффициент_сложности"].ToString(), reader["Коэффициент_для_перевода_в_денежный_эквивалент"].ToString());
                }
            }
            con.Close();
        }

        private void button_saveChanges_Click(object sender, EventArgs e)
        {
            con.Open();
            var d = dataGridView1;
            var com = new SqlCommand($"update rate set Junior_min = {d[2,0].Value.ToString()}, Middle_min = {d[3,0].Value.ToString()}, Senior_min = {d[4,0].Value.ToString()}," +
                $"Коэффициент_для_Анализ_и_проектирование = {d[5,0].Value.ToString()}, Коэффициент_для_Установка_оборудования = {d[6, 0].Value.ToString()}," +
                $"Коэффициент_для_Техническое_обслуживание_и_сопровождение = {d[7, 0].Value.ToString()}, Коэффициент_времени = {d[8, 0].Value.ToString()}," +
                $"Коэффициент_сложности = {d[9, 0].Value.ToString()}, Коэффициент_для_перевода_в_денежный_эквивалент = {d[10, 0].Value.ToString()} where id_personal = {d[0,0].Value.ToString()}", con);
            int count = com.ExecuteNonQuery();
            MessageBox.Show("Затронуто строк: "+count);
            con.Close();
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            
        }

        private void dataGridView1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            var reg = new Regex("^[0][.,][0-9]+$|^[1][.,][0]+$|^[0]+$|^[1]+$");
            if (e.ColumnIndex == 5 || e.ColumnIndex == 6 || e.ColumnIndex == 7 || e.ColumnIndex == 8 || e.ColumnIndex == 9 || e.ColumnIndex == 10)
            {
                if (!reg.IsMatch(dataGridView1[e.ColumnIndex,e.RowIndex].Value.ToString()))
                {
                    Validater(e.ColumnIndex);
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Диапазон: 0- 1";
                    MessageBox.Show("Диапазон: 0 - 1");
                }
            }
        }
        private void Validater(int index)
        {
            dataGridView1[index, 0].Value = "";
        }
    }
}
