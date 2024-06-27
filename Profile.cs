using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POO
{
    public partial class Profile : Form
    {
        private MySqlConnection connection;
        public Profile()
        {
            InitializeComponent();
            LoadData();
         
        }

        private  void LoadData() {

            try
            {
                string connectionString = "datasource=localhost;port=3306;userid=root;password=123a;database=POOcatalog";
                connection = new MySqlConnection(connectionString);

                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    // Connection was successful
                    Console.WriteLine("Connection successful!");



                }
                else
                {
                    // Connection failed
                    Console.WriteLine("Connection failed!");
                }
                

                string query = "SELECT * FROM students";
                MySqlCommand command = new MySqlCommand(query, connection);

                // Execute the command and retrieve the data
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        // Populate the form fields with the retrieved data
                        label1.Text = reader["first_name"].ToString();
                        label2.Text = reader["last_name"].ToString();
                        email_adress.Text = reader["email"].ToString();
                        Country.Text = reader["country"].ToString();
                        Faculty.Text = reader["faculty"].ToString();
                        Grupa.Text = reader["grupa"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }


      
        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Country_Click(object sender, EventArgs e)
        {

        }

        private void email_adress_Click(object sender, EventArgs e)
        {

        }

        private void Faculty_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
