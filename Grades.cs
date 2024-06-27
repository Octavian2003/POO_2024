using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace POO
{
    public partial class Grades : Form
    {
        private MySqlConnection connection;
        string query;
        int sum = 0;

        public Grades()
        {
            InitializeComponent();
            label2.Visible = false;
            label3.Visible = false;

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
            LoadData();
        }

        private void Grades_Load(object sender, EventArgs e)
        {
        }
        private void LoadData()
        {
            query = "SELECT Nume, Date, Score, Credits FROM Grades";
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
            placeColumn.DataPropertyName = "Score";
            placeColumn.HeaderText = "Score";
            guna2DataGridView1.Columns.Add(placeColumn);

            DataGridViewTextBoxColumn creditsColumn = new DataGridViewTextBoxColumn();
            creditsColumn.DataPropertyName = "Credits";
            creditsColumn.HeaderText = "Credits";
            guna2DataGridView1.Columns.Add(creditsColumn);

            guna2DataGridView1.DataSource = dataTable;

            sum = 0;
            foreach (DataRow row in dataTable.Rows)
            {
                int credits = Convert.ToInt32(row["Credits"]);
                sum += credits;
            }
        }

    private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void guna2DataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnRestanta_Click(object sender, EventArgs e)
        {
            label1.Text = "Nr Credite: " + sum.ToString();
            if (sum >= 40)
            {
                label3.Visible = true;
            }
            else
            {
                label2.Visible = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }
    }
}
