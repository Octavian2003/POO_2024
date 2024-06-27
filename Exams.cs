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
    public partial class Exams : Form
    {
        private MySqlConnection connection;
        public Exams()
        {
            InitializeComponent();
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
            connection.Close();
            LoadData();
        }

        private void Exams_Load(object sender, EventArgs e)
        {

        }
        private void LoadData()
        {
           
            string query = "SELECT Nume, Due, Place, Credits FROM Examene";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            guna2DataGridView1.Columns.Clear(); 

            DataGridViewTextBoxColumn numeColumn = new DataGridViewTextBoxColumn();
            numeColumn.DataPropertyName = "Nume"; 
            numeColumn.HeaderText = "Nume"; 
            guna2DataGridView1.Columns.Add(numeColumn);

            DataGridViewTextBoxColumn dueColumn = new DataGridViewTextBoxColumn();
            dueColumn.DataPropertyName = "Due";
            dueColumn.HeaderText = "Due";
            guna2DataGridView1.Columns.Add(dueColumn);

            DataGridViewTextBoxColumn placeColumn = new DataGridViewTextBoxColumn();
            placeColumn.DataPropertyName = "Place";
            placeColumn.HeaderText = "Place";
            guna2DataGridView1.Columns.Add(placeColumn);

            DataGridViewTextBoxColumn creditsColumn = new DataGridViewTextBoxColumn();
            creditsColumn.DataPropertyName = "Credits";
            creditsColumn.HeaderText = "Credits";
            guna2DataGridView1.Columns.Add(creditsColumn);

            guna2DataGridView1.DataSource = dataTable;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
