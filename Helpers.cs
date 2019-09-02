using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieHire
{
    public class Helpers
    {
        //private static string ServerName = @"DESKTOP-P9388SN\SQLEXPRESS";
        //private static string DatabaseName = @"Movies_Rentals";

        public static string HostConfig()
        {
            return @"Data Source=DESKTOP-POQE336\SQLEXPRESS;Initial Catalog=Movies_Rentals;Integrated Security=True";
        }

        public string TestConfig()
        {
            return HostConfig();
        }

        private static string[] GetDictionaryKeys(Dictionary<string, object> dict)
        {
            return dict.Keys.ToArray();
        }

        // Insert into table
        public static void Insert(string table, Dictionary<string, object> fields)
        {
            string keys = "";
            string values = "";
            var x = 1;

            foreach (KeyValuePair<string, object> entry in fields)
            {
                values += $"'{entry.Value}'";
                keys += $"{entry.Key}";
                if (x < fields.Count)
                {
                    values += ", ";
                    keys += ", ";
                }
                x++;
            }

            using (SqlConnection conn = new SqlConnection(HostConfig()))
            {
                // Establish Connection
                conn.Open();

                using (SqlCommand _cmd = new SqlCommand("INSERT INTO " + table + "(" + keys + ") VALUES(" + values + ")", conn))
                {
                    _cmd.ExecuteNonQuery();
                }
            }
        }

        // Update Table
        public static void Update(string table, string idType, string id, Dictionary<string, object> fields)
        {
            var val = "";
            var x = 1;

            foreach (KeyValuePair<string, object> entry in fields)
            {
                val += $"{entry.Key}='{entry.Value}'";
                if (x < fields.Count)
                {
                    val += ", ";
                }
                x++;
            }

            using (SqlConnection conn = new SqlConnection(HostConfig()))
            {
                // Establish Connection
                conn.Open();

                string sql = "UPDATE " + table + " SET " + val + " WHERE " + idType + "=@id";
                using (SqlCommand _cmd = new SqlCommand(sql, conn))
                {
                    _cmd.Parameters.AddWithValue("@id", id);
                    _cmd.ExecuteNonQuery();
                }
            }
        }

        // Normal Actions
        public static void Action(string action, string table, string[] where)
        {
            if (where.Length == 3)
            {
                ArrayList operators = new ArrayList();
                operators.Add("=");
                operators.Add("<=");
                operators.Add(">=");
                operators.Add(">");
                operators.Add("<");

                var field = where[0];
                var opera = where[1];
                var value = where[2];

                if (operators.Contains(opera))
                {
                    string sql = action + " FROM " + table + " WHERE " + field + "" + opera + " @value";
                    using (SqlConnection conn = new SqlConnection(HostConfig()))
                    {
                        conn.Open();

                        using (SqlCommand _cmd = new SqlCommand(sql, conn))
                        {
                            _cmd.Parameters.AddWithValue("@value", value);
                            _cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static void DisplayMessage(string message)
        {
            MessageBox.Show(message);
        }

        public static void AddToDataGrid(string table, DataGridView view)
        {
            using (SqlConnection conn = new SqlConnection(HostConfig()))
            {

                DataTable dataTable = new DataTable();
                dataTable.Clear();
                string query = "SELECT * FROM " + table;
                using (SqlDataAdapter _data = new SqlDataAdapter(query, conn))
                {
                    conn.Open();
                    _data.Fill(dataTable);

                    view.AutoGenerateColumns = false;
                    view.DataSource = dataTable;
                }
            }
        }

        public int CountList(string table, string column, int id)
        {
            return ItemCount(table, column, id);
        }

        public static int ItemCount(string table, string column, int id)
        {
            List<string> ItemsList = new List<string>();
            using (SqlConnection conn = new SqlConnection(HostConfig()))
            {
                // Open Connection
                conn.Open();

                string query = "SELECT * FROM " + table + " WHERE " + column + "=@id";
                using (SqlCommand _cmd = new SqlCommand(query, conn))
                {
                    _cmd.Parameters.AddWithValue("@id", id.ToString());
                    SqlDataReader reader = _cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        ItemsList.Add(reader[column].ToString());
                    }
                    reader.Close();
                    return ItemsList.Count;
                }
            }
        }

    }
}
