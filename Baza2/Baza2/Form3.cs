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
    public partial class Form3 : Form
    {
        private string conString = "Data Source=LAPTOPSZAFIRKA;Initial Catalog=projekt;Integrated Security=True";
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable data;
        SqlDataReader rd;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(conString);
                connection.Open();
                cmd = new SqlCommand("SELECT id FROM employer", connection);

                sda = new SqlDataAdapter(cmd);

                DataSet data = new DataSet();
                sda.Fill(data);

                for (int i = 0; i < data.Tables[0].Rows.Count; i++)
                {
                    comboBox_emp.Items.Add(data.Tables[0].Rows[i][0].ToString());
                }

                cmd.ExecuteNonQuery();
                connection.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            finally
            {
                connection.Close();
            }
        }

        private void button_insert2_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(conString);
                connection.Open();
                cmd = new SqlCommand("SELECT COUNT(*) FROM data ", connection);
                rd = cmd.ExecuteReader();




                if (String.IsNullOrEmpty(textBox_adress.Text)  || String.IsNullOrEmpty(dateTimePicker_data2.Text))
                {
                    MessageBox.Show("Nie uzupełniono wszystkich pól!");
                }
                else if (rd.Read())
                {
                    if (MessageBox.Show("Czy na pewno chcesz wykonać tę czynność?", "Pytanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        connection.Close();
                        connection.Open();
                        cmd = new SqlCommand("INSERT INTO data (emp_id, adress, data) VALUES ('" + comboBox_emp.Text + "','" + textBox_adress.Text + "', '" + Convert.ToDateTime(dateTimePicker_data2.Text) + "')", connection);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dodano nowe zgłoszenie!");
                    }
                }
                connection.Close();
            }
            catch (Exception ex)
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
