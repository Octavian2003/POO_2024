using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace POO
{
    internal class MainClass
    {


        static string con_string = "datasource=localhost;port=3306;userid=root;password=123a;database=POOcatalog";
        public static MySqlConnection con = new MySqlConnection(con_string);

        public static void check() {
            con.Open();
            if (con.State == ConnectionState.Open)
            {
                // Connection was successful
                Console.WriteLine("Connection successful!");

           

            }
            else
            {
                // Connection failed
                Console.WriteLine("Connection failed!");
            }
            con.Close();

        }
        public static bool isValidUser(string user, string pass) {
         

            bool isValid = false;

            // string qry = @"Select * from users where username = '" +user+ "'and upass = '" +pass+ "' ";
            string qry = @"SELECT * FROM students WHERE first_name = @user AND password = @pass";
            MySqlCommand cmd = new MySqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@user", user);
            cmd.Parameters.AddWithValue("@pass", pass);

            con.Open();
            using (MySqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    isValid = true;                 
                    USER = reader["first_name"].ToString();
                }
            }
            con.Close();

            return isValid;
        }

    
        public static string user;

        public static string USER {

            get { return user; }
            private set { user = value; }
        }



        public static int SQl(string qry, Hashtable ht) {
            int res = 0;

            try
            {

                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.CommandType = CommandType.Text;

                foreach (DictionaryEntry item in ht) {
                    cmd.Parameters.AddWithValue(item.Key.ToString(), item.Value);
                }
                if (con.State == ConnectionState.Closed) { con.Open(); }
                res = cmd.ExecuteNonQuery();
                if (con.State == ConnectionState.Open) { con.Close(); }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                con.Close();
            }

            return res;
        }


        public static void LoadData(string qry, DataGridView gv, ListBox lb)
        {
            try
            {

                MySqlCommand cmd = new MySqlCommand(qry, con);
                cmd.CommandType=CommandType.Text;
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < lb.Items.Count; i++) {
                    string colNam1 = ((DataGridViewColumn)lb.Items[i]).Name;
                    gv.Columns[colNam1].DataPropertyName = dt.Columns[i].ToString();

                }
                gv.DataSource = dt;
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
                con.Close();
            }
        
         }

    }

}
