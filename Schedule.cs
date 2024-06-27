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
    public partial class Schedule : Form
    {
        private MySqlConnection connection;
        public Schedule()
        {
           
            InitializeComponent();

            string connectionString = "datasource=localhost;port=3306;userid=root;password=123a;database=POOcatalog";
            connection = new MySqlConnection(connectionString);

            connection.Open();
            if (connection.State == ConnectionState.Open)
            {
                Console.WriteLine("Connection successful!");
            }
            else
            {
                Console.WriteLine("Connection failed!");
            }
            connection.Close();

            LoadData();
        }

        private void Schedule_Load(object sender, EventArgs e)
        {
        }
        private void LoadData()
        {
            string query = "SELECT `Interval`, tip, course, locatie, profesor FROM Schedule";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            guna2DataGridView1.Columns.Clear(); 

            DataGridViewTextBoxColumn numeColumn = new DataGridViewTextBoxColumn();
            numeColumn.DataPropertyName = "Interval"; 
            numeColumn.HeaderText = "Interval"; 
            guna2DataGridView1.Columns.Add(numeColumn);
            
            DataGridViewTextBoxColumn dueColumn = new DataGridViewTextBoxColumn();
            dueColumn.DataPropertyName = "Tip";
            dueColumn.HeaderText = "Tip";
            guna2DataGridView1.Columns.Add(dueColumn);

            DataGridViewTextBoxColumn placeColumn = new DataGridViewTextBoxColumn();
            placeColumn.DataPropertyName = "Course";
            placeColumn.HeaderText = "Course";
            guna2DataGridView1.Columns.Add(placeColumn);

            DataGridViewTextBoxColumn creditsColumn = new DataGridViewTextBoxColumn();
            creditsColumn.DataPropertyName = "Locatie";
            creditsColumn.HeaderText = "Locatie";
            guna2DataGridView1.Columns.Add(creditsColumn);

            DataGridViewTextBoxColumn ProfesorColumn = new DataGridViewTextBoxColumn();
            creditsColumn.DataPropertyName = "Profesor";
            creditsColumn.HeaderText = "Profesor";
            guna2DataGridView1.Columns.Add(ProfesorColumn);

            guna2DataGridView1.DataSource = dataTable;

        }
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
