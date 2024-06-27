
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
    public partial class Courses : Form
    {
        private MySqlConnection connection;

        public Courses()
        {
            InitializeComponent();

            // Conectarea la baza de date
            string connectionString = "datasource=localhost;port=3306;userid=root;password=123a;database=POOcatalog";
            connection = new MySqlConnection(connectionString);

            // Încercare de deschidere a conexiunii
            try
            {
                connection.Open();
                if (connection.State == ConnectionState.Open)
                {
                    Console.WriteLine("Conexiunea a fost stabilită cu succes!");
                }
                else
                {
                    Console.WriteLine("Conexiunea a eșuat!");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Eroare la conectare: " + ex.Message);
            }
            finally
            {
                connection.Close(); // Închide conexiunea după ce verificarea s-a încheiat
            }

            // Incarcarea datelor în DataGridView
            LoadData();
        }

        private void LoadData()
        {

            string query = "SELECT Name, Place, Professor FROM Courses";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            // Define columns for the DataGridView
            guna2DataGridView1.Columns.Clear(); // Clear existing columns if any

            // Define column for "Name"
            DataGridViewTextBoxColumn numeColumn = new DataGridViewTextBoxColumn();
            numeColumn.DataPropertyName = "Name"; // Specify the corresponding column name in the DataTable
            numeColumn.HeaderText = "Name"; // Header text for the column
            guna2DataGridView1.Columns.Add(numeColumn);

            // Define column for "Place"
            DataGridViewTextBoxColumn placeColumn = new DataGridViewTextBoxColumn();
            placeColumn.DataPropertyName = "Place";
            placeColumn.HeaderText = "Place";
            guna2DataGridView1.Columns.Add(placeColumn);

            // Define column for "Professor"
            DataGridViewTextBoxColumn professorColumn = new DataGridViewTextBoxColumn();
            professorColumn.DataPropertyName = "Professor";
            professorColumn.HeaderText = "Professor";
            guna2DataGridView1.Columns.Add(professorColumn);

            // Set the data source and refresh the DataGridView
            guna2DataGridView1.DataSource = dataTable;
        }

      //  private void dataGridViewCourses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
            // Aici poți trata evenimentul de click pe celule, dacă este necesar
        //}

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
