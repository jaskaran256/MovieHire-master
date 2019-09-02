using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieHire
{
    public partial class Form1 : Form
    {

        private int CustomerRowID = 0;
        private int CustomerRowIndex;

        private int MovieRowID = 0;
        private int MovieRowIndex;

        private int RentalsRowID = 0;
        private int RentalsRowIndex;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetCustomersList();
            GetMoviesList();
            GetRentalsList();

            RentFromField.Value = DateTime.Now;
            RentTillField.Value = RentFromField.Value.AddDays(1);

            MovieGenreField.Items.Clear();
            MovieGenreField.Items.Add("Action");
            MovieGenreField.Items.Add("Adventure");
            MovieGenreField.Items.Add("Medieval");
            MovieGenreField.Items.Add("Historic");
            MovieGenreField.Items.Add("Comedy");
            MovieGenreField.Items.Add("Romance");
            MovieGenreField.Items.Add("Drama");

            MovieGenreField.SelectedIndex = 0;
        }

        /**************************************************************/
        // Customers

        private void GetCustomersList()
        {
            Helpers.AddToDataGrid("Customers", dataGridView1);
        }

        private void AddCustomer_Click(object sender, EventArgs e)
        {
            if (firstNameField.Text != "" || lastNameField.Text != "" || addressField.Text != "" || phoneNumberField.Text != "")
            {
                Dictionary<string, object> inputs = new Dictionary<string, object>()
                {
                    { "FirstName", firstNameField.Text.ToString() },
                    { "LastName", lastNameField.Text.ToString() },
                    { "Address", addressField.Text.ToString() },
                    { "PhoneNumber", phoneNumberField.Text.ToString() }
                };
                Helpers.Insert("Customers", inputs);

                Helpers.DisplayMessage(firstNameField.Text + " " + lastNameField.Text + " has been added!");

                // Sync customers list with database
                GetCustomersList();
                ResetCustomerFields();
            }
            else
            {
                Helpers.DisplayMessage("One or more fields are empty!");
            }
        }

        private void UpdateCustomer_Click(object sender, EventArgs e)
        {
            if (firstNameField.Text != "" || lastNameField.Text != "" || addressField.Text != "" || phoneNumberField.Text != "")
            {
                Dictionary<string, object> inputs = new Dictionary<string, object>()
                {
                    { "FirstName", firstNameField.Text },
                    { "LastName", lastNameField.Text },
                    { "Address", addressField.Text },
                    { "PhoneNumber", phoneNumberField.Text }
                };

                if (CustomerRowID > 0)
                {

                    Helpers.Update("Customers", "CustomerID", CustomerRowID.ToString(), inputs);

                    // Sync customers list with database
                    GetCustomersList();
                    ResetCustomerFields();
                }
                else
                {
                    Helpers.DisplayMessage("User not Selected!");
                }
            }
        }

        private void DeleteCustomer_Click(object sender, EventArgs e)
        {
            if (Helpers.ItemCount("Rentals", "CustomerID", CustomerRowID) > 0)
            {
                Helpers.DisplayMessage("Cannot delete customer who have rented store items!");
            }
            else
            {
                string[] arr = { "CustomerID", "=", CustomerRowID.ToString() };
                Helpers.Action("DELETE", "Customers", arr);

                // Sync Customers List with Database
                GetCustomersList();
                ResetCustomerFields();
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CustomerRowIndex = e.RowIndex;

            if(this.CustomerRowIndex < 0)
            {
                Console.WriteLine("Incorrect Index");
                ResetCustomerFields();
            }
            else
            {
                DataGridViewRow row = dataGridView1.Rows[this.CustomerRowIndex];
                if(row.Selected)
                {
                    if (CustomerRowIndex < dataGridView1.Rows.Count - 1)
                    {
                        DeleteCustomer.Enabled = true;
                        UpdateCustomer.Enabled = true;

                        // Set Values
                        CustomerRowID = Convert.ToInt32(row.Cells[0].Value.ToString());
                        firstNameField.Text = row.Cells[1].Value.ToString();
                        lastNameField.Text = row.Cells[2].Value.ToString();
                        addressField.Text = row.Cells[3].Value.ToString();
                        phoneNumberField.Text = row.Cells[4].Value.ToString();
                    }
                    else
                    {
                        DeleteCustomer.Enabled = false;
                        UpdateCustomer.Enabled = false;
                        ResetCustomerFields();
                    }
                }
                else
                {
                    // Reset all the fields
                    ResetCustomerFields();
                }
            }
        }

        private void ResetCustomerFields()
        {
            firstNameField.Text = "";
            lastNameField.Text = "";
            addressField.Text = "";
            phoneNumberField.Text = "";
        }

        /**************************************************************/
        // Movies

        private void GetMoviesList()
        {
            Helpers.AddToDataGrid("StoreMovies", dataGridView2);
        }

        private void AddMovie_Click(object sender, EventArgs e)
        {
            if(movieTitleField.Text != "" || MovieRentingCostField.Text != "")
            {
                Dictionary<string, object> inputs = new Dictionary<string, object>()
                {
                    { "MovieTitle", movieTitleField.Text },
                    { "MovieRatings", Convert.ToDecimal(MovieRatingsField.Value) },
                    { "MovieReleaseDate", MovieReleaseDateField.Value },
                    { "MovieCopies", Convert.ToInt32(MovieCopiesField.Value) },
                    { "MovieRentingPrice", MovieRentingCostField.Text },
                    { "MovieGenre", MovieGenreField.SelectedItem.ToString() }
                };

                Helpers.Insert("StoreMovies", inputs);

                Helpers.DisplayMessage(movieTitleField.Text + " has been added");

                GetMoviesList();
                ResetMovieFields();
            }
            else
            {
                Helpers.DisplayMessage("One or more Fields are empty");
            }
        }

        private void UpdateMovie_Click(object sender, EventArgs e)
        {
            if (movieTitleField.Text != "" || MovieRentingCostField.Text != "")
            {
                Dictionary<string, object> inputs = new Dictionary<string, object>()
                {
                    { "MovieTitle", movieTitleField.Text },
                    { "MovieRatings", Convert.ToDecimal(MovieRatingsField.Value) },
                    { "MovieReleaseDate", MovieReleaseDateField.Value },
                    { "MovieCopies", Convert.ToInt32(MovieCopiesField.Value) },
                    { "MovieRentingPrice", MovieRentingCostField.Text },
                    { "MovieGenre", MovieGenreField.SelectedItem.ToString() }
                };

                Helpers.Update("StoreMovies", "MovieID", MovieRowID.ToString(), inputs);

                GetMoviesList();
                ResetMovieFields();
            }
            else
            {
                Helpers.DisplayMessage("One or more Fields are empty");
            }
        }

        private void DeleteMovie_Click(object sender, EventArgs e)
        {
            if (Helpers.ItemCount("Rentals", "MovieID", MovieRowID) > 0)
            {
                Helpers.DisplayMessage("Copies of the selected movie are currently rented");
            }
            else
            {
                string[] arr = { "MovieID", "=", MovieRowID.ToString() };
                Helpers.Action("Delete", "StoreMovies", arr);
                GetMoviesList();
                ResetMovieFields();
            }
        }

        private void DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.MovieRowIndex = e.RowIndex;

            if (this.MovieRowIndex < 0)
            {
                Console.WriteLine("Incorrect Index");
                ResetMovieFields();
            }
            else
            {
                DataGridViewRow row = dataGridView2.Rows[this.MovieRowIndex];
                if (row.Selected)
                {
                    if (MovieRowIndex < dataGridView2.Rows.Count - 1)
                    {
                        DeleteMovie.Enabled = true;
                        UpdateMovie.Enabled = true;

                        // Set Values
                        MovieRowID = Convert.ToInt32(row.Cells[0].Value.ToString());
                        movieTitleField.Text = row.Cells[1].Value.ToString();
                        MovieRatingsField.Value = Convert.ToDecimal(row.Cells[2].Value);
                        MovieReleaseDateField.Value = Convert.ToDateTime(row.Cells[3].Value);
                        MovieCopiesField.Value = Convert.ToInt32(row.Cells[4].Value);
                        MovieRentingCostField.Text = row.Cells[5].Value.ToString();
                        if (MovieGenreField.Items.Contains(row.Cells[6].Value.ToString()))
                        {
                            MovieGenreField.SelectedItem = row.Cells[6].Value.ToString();
                        }
                        else
                        {
                            MovieGenreField.SelectedIndex = 0;
                        }
                    }
                    else
                    {
                        DeleteMovie.Enabled = false;
                        UpdateMovie.Enabled = false;
                        ResetMovieFields();
                    }
                }
                else
                {
                    // Reset all the fields
                    ResetMovieFields();
                }
            }
        }

        private void ResetMovieFields()
        {
            MovieRowID = 0;
            movieTitleField.Text = "";
            MovieRatingsField.Value = Convert.ToDecimal(0.1);
            MovieReleaseDateField.Value = DateTime.Now;
            MovieCopiesField.Value = 1;
            MovieRentingCostField.Text = "";
            MovieGenreField.SelectedIndex = 0;

        }

        /**************************************************************/
        // Renting

        private void GetRentalsList()
        {
            Helpers.AddToDataGrid("Rentals", dataGridView3);
        }

        private void IssueMovie_Click(object sender, EventArgs e)
        {
            if(CustomerRowID > 0 && MovieRowID > 0)
            {
                if (MovieCopiesField.Value > 0)
                {
                    Dictionary<string, object> inputs = new Dictionary<string, object>()
                    {
                        { "MovieCopies",  Convert.ToInt32(MovieCopiesField.Value - 1)}
                    };
                    Helpers.Update("StoreMovies", "MovieID", MovieRowID.ToString(), inputs);

                    // Sync Movies Table
                    GetMoviesList();

                    Dictionary<string, object> rented = new Dictionary<string, object>()
                    {
                        { "CustomerID", CustomerRowID },
                        { "MovieID", MovieRowID },
                        { "RentFrom", RentFromField.Value.ToString() },
                        { "RentTill", RentTillField.Value.ToString() }
                    };
                    Helpers.Insert("Rentals", rented);
                    GetRentalsList();
                    ResetRentalsFields();

                    // Display Pop Up message letting User know for which movie is rented by whom
                    Helpers.DisplayMessage(firstNameField.Text + " " + lastNameField.Text + " has rented " + movieTitleField.Text);
                }
                else
                {
                    Helpers.DisplayMessage("All copies of " + movieTitleField.Text + " are rented!");
                }
            }
            else
            {
                if (CustomerRowID <= 0 && MovieRowID > 0)
                {
                    Helpers.DisplayMessage("Please select a customer whom you want to issue a movie");
                }
                else if (MovieRowID <= 0 && CustomerRowID > 0)
                {
                    Helpers.DisplayMessage("Please select a movie to issue");
                }
                else
                {
                    Helpers.DisplayMessage("Movie cannot be issues if Customer or Movies are not selected.");
                }
            }
        }

        private void ReturnMovie_Click(object sender, EventArgs e)
        {
            string[] arr = { "MovieID", "=", MovieRowID.ToString() };
            Helpers.Action("DELETE", "Rentals", arr);
            GetRentalsList();

            // Get the current copies
            using(SqlConnection conn = new SqlConnection(Helpers.HostConfig()))
            {
                conn.Open();

                // Execute Query
                using (SqlCommand _cmd = new SqlCommand("UPDATE StoreMovies SET MovieCopies=@copies WHERE MovieID=@id", conn))
                {
                    int copies = 0;
                    SqlCommand _getCopies = new SqlCommand("SELECT MovieCopies FROM StoreMovies WHERE MovieID=@id", conn);
                    _getCopies.Parameters.AddWithValue("@id", MovieRowID);
                    SqlDataReader reader = _getCopies.ExecuteReader();
                    while (reader.Read())
                    {
                        copies = Convert.ToInt32(reader["MovieCopies"]);
                    }
                    reader.Close();

                    _cmd.Parameters.AddWithValue("@copies", copies + 1);
                    _cmd.Parameters.AddWithValue("@id", MovieRowID);
                    _cmd.ExecuteNonQuery();
                }
                GetRentalsList();
            }

            GetMoviesList();
        }

        private void RentFromField_ValueChanged(object sender, EventArgs e)
        {
            if (RentFromField.Value.Date >= RentTillField.Value.Date)
            {
                RentTillField.Value = RentFromField.Value.AddDays(1);
            }
        }

        private void RentTillField_ValueChanged(object sender, EventArgs e)
        {
            if (RentTillField.Value.Date <= RentFromField.Value.Date)
            {
                RentTillField.Value = RentFromField.Value.AddDays(1);
            }
        }

        private void DataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.RentalsRowIndex = e.RowIndex;

            if (this.RentalsRowIndex < 0)
            {
                ResetRentalsFields();
            }
            else
            {
                DataGridViewRow row = dataGridView3.Rows[RentalsRowIndex];
                if (row.Selected)
                {
                    // Avoid Error from selecting empty auto generated row
                    if (this.RentalsRowIndex < dataGridView3.Rows.Count - 1)
                    {
                        ReturnMovie.Enabled = true;
                        RentalsRowID = Convert.ToInt32(row.Cells[0].Value);
                        MovieRowID = Convert.ToInt32(row.Cells[2].Value);
                        RentFromField.Value = Convert.ToDateTime(row.Cells[3].Value);
                        RentTillField.Value = Convert.ToDateTime(row.Cells[4].Value);
                    }
                    else
                    {
                        ReturnMovie.Enabled = false;
                        ResetRentalsFields();
                    }
                }
                else
                {
                    ResetRentalsFields();
                }
            }
        }

        private void ResetRentalsFields()
        {
            RentFromField.Value = DateTime.Now;
            RentTillField.Value = RentFromField.Value.AddDays(1);
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
