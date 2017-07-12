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

namespace Baza2
{
    public partial class Form2 : Form
    {
        private string conString = "Data Source=LAPTOPSZAFIRKA;Initial Catalog=projekt;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataReader rd;

        public Form2()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(conString);
                connection.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM employer ", connection);
                rd = cmd.ExecuteReader();
                
               


                if (String.IsNullOrEmpty(textBox_name.Text) || String.IsNullOrEmpty(textBox_surname.Text) || String.IsNullOrEmpty(comboBox_gender.Text) || String.IsNullOrEmpty(dateTimePicker_data.Text))
                {
                    MessageBox.Show("Nie uzupełniono wszystkich pól!");
                }
                else if (rd.Read())
                {
                    if (MessageBox.Show("Czy na pewno chcesz wykonać tę czynność?", "Pytanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        connection.Close();
                        connection.Open();
                        cmd = new SqlCommand("INSERT INTO employer (name, surname, gender, data) VALUES ('" + textBox_name.Text + "','" + textBox_surname.Text + "','" + comboBox_gender.Text + "', '" + Convert.ToDateTime(dateTimePicker_data.Text) + "')", connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dodano nowego pracownika!");
                    }
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
