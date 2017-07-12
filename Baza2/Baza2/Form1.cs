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
    public partial class Form1 : Form
    {
        private string conString = "Data Source=LAPTOPSZAFIRKA;Initial Catalog=projekt;Integrated Security=True";   
        SqlConnection connection;
        SqlCommand cmd;
        SqlDataAdapter sda;
        DataTable data;
        Form2 form_insert;
        Form3 form_insert2;
        Form4 form_insert3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*polaczenie*/
            connection = new SqlConnection(conString);
            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                label1.ForeColor = Color.Green;
                dataGridView1.ReadOnly = true;
                label1.Text = "ON";
            }
            else
            {
                label1.ForeColor = Color.Red;
                label1.Text = "OFF";
            }
           
        }


        private void button_view_Click(object sender, EventArgs e)
        {
            /* wyswietlanie danych */
            try
            {
                connection = new SqlConnection(conString);
                connection.Open();
                cmd = new SqlCommand("SELECT * FROM employer INNER JOIN data ON employer.id = data.emp_id", connection);
            
                sda = new SqlDataAdapter(cmd);

                data = new DataTable();
                sda.Fill(data);
                dataGridView1.DataSource = data;

                cmd.ExecuteNonQuery();
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

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                form_insert = new Form2();
                form_insert.Show();
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            try
            {
                form_insert2 = new Form3();
                form_insert2.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            try
            {
                form_insert3 = new Form4();
                form_insert3.Show();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(conString);
                connection.Open();

                cmd = new SqlCommand("DELETE FROM employer WHERE employer.id = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' ", connection);
                cmd.ExecuteNonQuery();
                
                
                cmd = new SqlCommand("DELETE FROM data WHERE data.emp_id = '" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "' ", connection);
                cmd.ExecuteNonQuery();
               

              
                connection.Close();
                MessageBox.Show("Usunieto zamowienie!");


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
