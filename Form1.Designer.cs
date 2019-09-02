namespace MovieHire
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteCustomer = new System.Windows.Forms.Button();
            this.UpdateCustomer = new System.Windows.Forms.Button();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNameField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.DeleteMovie = new System.Windows.Forms.Button();
            this.UpdateMovie = new System.Windows.Forms.Button();
            this.AddMovie = new System.Windows.Forms.Button();
            this.MovieGenreField = new System.Windows.Forms.ComboBox();
            this.MovieRentingCostField = new System.Windows.Forms.TextBox();
            this.MovieCopiesField = new System.Windows.Forms.NumericUpDown();
            this.MovieReleaseDateField = new System.Windows.Forms.DateTimePicker();
            this.MovieRatingsField = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.movieTitleField = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MovieID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieRatings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieReleaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieCopies = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieRentingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MovieGenre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ReturnMovie = new System.Windows.Forms.Button();
            this.IssueMovie = new System.Windows.Forms.Button();
            this.RentTillField = new System.Windows.Forms.DateTimePicker();
            this.RentFromField = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.RentalID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Customer_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Movie_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentTill = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieCopiesField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieRatingsField)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 557);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DeleteCustomer);
            this.tabPage1.Controls.Add(this.UpdateCustomer);
            this.tabPage1.Controls.Add(this.AddCustomer);
            this.tabPage1.Controls.Add(this.phoneNumberField);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.addressField);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lastNameField);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.firstNameField);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 531);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteCustomer
            // 
            this.DeleteCustomer.Enabled = false;
            this.DeleteCustomer.Location = new System.Drawing.Point(453, 485);
            this.DeleteCustomer.Name = "DeleteCustomer";
            this.DeleteCustomer.Size = new System.Drawing.Size(215, 38);
            this.DeleteCustomer.TabIndex = 11;
            this.DeleteCustomer.Text = "Delete Customer";
            this.DeleteCustomer.UseVisualStyleBackColor = true;
            this.DeleteCustomer.Click += new System.EventHandler(this.DeleteCustomer_Click);
            // 
            // UpdateCustomer
            // 
            this.UpdateCustomer.Enabled = false;
            this.UpdateCustomer.Location = new System.Drawing.Point(232, 486);
            this.UpdateCustomer.Name = "UpdateCustomer";
            this.UpdateCustomer.Size = new System.Drawing.Size(215, 38);
            this.UpdateCustomer.TabIndex = 10;
            this.UpdateCustomer.Text = "Update Customer";
            this.UpdateCustomer.UseVisualStyleBackColor = true;
            this.UpdateCustomer.Click += new System.EventHandler(this.UpdateCustomer_Click);
            // 
            // AddCustomer
            // 
            this.AddCustomer.Location = new System.Drawing.Point(11, 486);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(215, 38);
            this.AddCustomer.TabIndex = 9;
            this.AddCustomer.Text = "Add New Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.Location = new System.Drawing.Point(750, 458);
            this.phoneNumberField.MaxLength = 32;
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(204, 20);
            this.phoneNumberField.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(746, 435);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Phone Number";
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(437, 459);
            this.addressField.MaxLength = 32;
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(307, 20);
            this.addressField.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 435);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            // 
            // lastNameField
            // 
            this.lastNameField.Location = new System.Drawing.Point(232, 458);
            this.lastNameField.MaxLength = 32;
            this.lastNameField.Name = "lastNameField";
            this.lastNameField.Size = new System.Drawing.Size(199, 20);
            this.lastNameField.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 435);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Last Name";
            // 
            // firstNameField
            // 
            this.firstNameField.Location = new System.Drawing.Point(11, 459);
            this.firstNameField.MaxLength = 32;
            this.firstNameField.Name = "firstNameField";
            this.firstNameField.Size = new System.Drawing.Size(215, 20);
            this.firstNameField.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 435);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.FirstName,
            this.LastName,
            this.Address,
            this.PhoneNumber});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(954, 425);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "ID";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.DataPropertyName = "FirstName";
            this.FirstName.HeaderText = "First Name";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            this.FirstName.Width = 150;
            // 
            // LastName
            // 
            this.LastName.DataPropertyName = "LastName";
            this.LastName.HeaderText = "Last Name";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            this.LastName.Width = 150;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 360;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.DataPropertyName = "PhoneNumber";
            this.PhoneNumber.HeaderText = "Phone Number";
            this.PhoneNumber.Name = "PhoneNumber";
            this.PhoneNumber.ReadOnly = true;
            this.PhoneNumber.Width = 150;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.DeleteMovie);
            this.tabPage2.Controls.Add(this.UpdateMovie);
            this.tabPage2.Controls.Add(this.AddMovie);
            this.tabPage2.Controls.Add(this.MovieGenreField);
            this.tabPage2.Controls.Add(this.MovieRentingCostField);
            this.tabPage2.Controls.Add(this.MovieCopiesField);
            this.tabPage2.Controls.Add(this.MovieReleaseDateField);
            this.tabPage2.Controls.Add(this.MovieRatingsField);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.movieTitleField);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 531);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(776, 437);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(667, 437);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Price";
            // 
            // DeleteMovie
            // 
            this.DeleteMovie.Location = new System.Drawing.Point(453, 486);
            this.DeleteMovie.Name = "DeleteMovie";
            this.DeleteMovie.Size = new System.Drawing.Size(215, 38);
            this.DeleteMovie.TabIndex = 27;
            this.DeleteMovie.Text = "Delete Movie";
            this.DeleteMovie.UseVisualStyleBackColor = true;
            this.DeleteMovie.Click += new System.EventHandler(this.DeleteMovie_Click);
            // 
            // UpdateMovie
            // 
            this.UpdateMovie.Location = new System.Drawing.Point(232, 487);
            this.UpdateMovie.Name = "UpdateMovie";
            this.UpdateMovie.Size = new System.Drawing.Size(215, 38);
            this.UpdateMovie.TabIndex = 26;
            this.UpdateMovie.Text = "Update Movie";
            this.UpdateMovie.UseVisualStyleBackColor = true;
            this.UpdateMovie.Click += new System.EventHandler(this.UpdateMovie_Click);
            // 
            // AddMovie
            // 
            this.AddMovie.Location = new System.Drawing.Point(11, 487);
            this.AddMovie.Name = "AddMovie";
            this.AddMovie.Size = new System.Drawing.Size(215, 38);
            this.AddMovie.TabIndex = 25;
            this.AddMovie.Text = "Add New Movie";
            this.AddMovie.UseVisualStyleBackColor = true;
            this.AddMovie.Click += new System.EventHandler(this.AddMovie_Click);
            // 
            // MovieGenreField
            // 
            this.MovieGenreField.FormattingEnabled = true;
            this.MovieGenreField.Location = new System.Drawing.Point(780, 461);
            this.MovieGenreField.Name = "MovieGenreField";
            this.MovieGenreField.Size = new System.Drawing.Size(174, 21);
            this.MovieGenreField.TabIndex = 24;
            // 
            // MovieRentingCostField
            // 
            this.MovieRentingCostField.Location = new System.Drawing.Point(671, 461);
            this.MovieRentingCostField.Name = "MovieRentingCostField";
            this.MovieRentingCostField.Size = new System.Drawing.Size(103, 20);
            this.MovieRentingCostField.TabIndex = 23;
            // 
            // MovieCopiesField
            // 
            this.MovieCopiesField.Location = new System.Drawing.Point(591, 462);
            this.MovieCopiesField.Name = "MovieCopiesField";
            this.MovieCopiesField.Size = new System.Drawing.Size(74, 20);
            this.MovieCopiesField.TabIndex = 22;
            // 
            // MovieReleaseDateField
            // 
            this.MovieReleaseDateField.Location = new System.Drawing.Point(336, 461);
            this.MovieReleaseDateField.Name = "MovieReleaseDateField";
            this.MovieReleaseDateField.Size = new System.Drawing.Size(249, 20);
            this.MovieReleaseDateField.TabIndex = 21;
            // 
            // MovieRatingsField
            // 
            this.MovieRatingsField.DecimalPlaces = 1;
            this.MovieRatingsField.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MovieRatingsField.Location = new System.Drawing.Point(233, 461);
            this.MovieRatingsField.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.MovieRatingsField.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.MovieRatingsField.Name = "MovieRatingsField";
            this.MovieRatingsField.Size = new System.Drawing.Size(96, 20);
            this.MovieRatingsField.TabIndex = 20;
            this.MovieRatingsField.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(587, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 19;
            this.label5.Text = "Copies";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(332, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "ReleaseDate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(228, 437);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Ratings";
            // 
            // movieTitleField
            // 
            this.movieTitleField.Location = new System.Drawing.Point(11, 461);
            this.movieTitleField.MaxLength = 32;
            this.movieTitleField.Name = "movieTitleField";
            this.movieTitleField.Size = new System.Drawing.Size(215, 20);
            this.movieTitleField.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 437);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Movie Title";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MovieID,
            this.MovieTitle,
            this.MovieRatings,
            this.MovieReleaseDate,
            this.MovieCopies,
            this.MovieRentingPrice,
            this.MovieGenre});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(954, 425);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView2_CellClick);
            // 
            // MovieID
            // 
            this.MovieID.DataPropertyName = "MovieID";
            this.MovieID.HeaderText = "ID";
            this.MovieID.Name = "MovieID";
            this.MovieID.ReadOnly = true;
            // 
            // MovieTitle
            // 
            this.MovieTitle.DataPropertyName = "MovieTitle";
            this.MovieTitle.HeaderText = "Movie Title";
            this.MovieTitle.Name = "MovieTitle";
            this.MovieTitle.ReadOnly = true;
            // 
            // MovieRatings
            // 
            this.MovieRatings.DataPropertyName = "MovieRatings";
            this.MovieRatings.HeaderText = "Ratings";
            this.MovieRatings.Name = "MovieRatings";
            this.MovieRatings.ReadOnly = true;
            // 
            // MovieReleaseDate
            // 
            this.MovieReleaseDate.DataPropertyName = "MovieReleaseDate";
            this.MovieReleaseDate.HeaderText = "Release Date";
            this.MovieReleaseDate.Name = "MovieReleaseDate";
            this.MovieReleaseDate.ReadOnly = true;
            // 
            // MovieCopies
            // 
            this.MovieCopies.DataPropertyName = "MovieCopies";
            this.MovieCopies.HeaderText = "Copies";
            this.MovieCopies.Name = "MovieCopies";
            this.MovieCopies.ReadOnly = true;
            // 
            // MovieRentingPrice
            // 
            this.MovieRentingPrice.DataPropertyName = "MovieRentingPrice";
            this.MovieRentingPrice.HeaderText = "Price";
            this.MovieRentingPrice.Name = "MovieRentingPrice";
            this.MovieRentingPrice.ReadOnly = true;
            // 
            // MovieGenre
            // 
            this.MovieGenre.DataPropertyName = "MovieGenre";
            this.MovieGenre.HeaderText = "Genre";
            this.MovieGenre.Name = "MovieGenre";
            this.MovieGenre.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.ReturnMovie);
            this.tabPage3.Controls.Add(this.IssueMovie);
            this.tabPage3.Controls.Add(this.RentTillField);
            this.tabPage3.Controls.Add(this.RentFromField);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(960, 531);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "On Rent";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ReturnMovie
            // 
            this.ReturnMovie.Location = new System.Drawing.Point(739, 486);
            this.ReturnMovie.Name = "ReturnMovie";
            this.ReturnMovie.Size = new System.Drawing.Size(215, 38);
            this.ReturnMovie.TabIndex = 27;
            this.ReturnMovie.Text = "Return Movie";
            this.ReturnMovie.UseVisualStyleBackColor = true;
            this.ReturnMovie.Click += new System.EventHandler(this.ReturnMovie_Click);
            // 
            // IssueMovie
            // 
            this.IssueMovie.Location = new System.Drawing.Point(9, 486);
            this.IssueMovie.Name = "IssueMovie";
            this.IssueMovie.Size = new System.Drawing.Size(215, 38);
            this.IssueMovie.TabIndex = 26;
            this.IssueMovie.Text = "Issue Movie";
            this.IssueMovie.UseVisualStyleBackColor = true;
            this.IssueMovie.Click += new System.EventHandler(this.IssueMovie_Click);
            // 
            // RentTillField
            // 
            this.RentTillField.Location = new System.Drawing.Point(401, 451);
            this.RentTillField.Name = "RentTillField";
            this.RentTillField.Size = new System.Drawing.Size(251, 20);
            this.RentTillField.TabIndex = 21;
            this.RentTillField.ValueChanged += new System.EventHandler(this.RentTillField_ValueChanged);
            // 
            // RentFromField
            // 
            this.RentFromField.Location = new System.Drawing.Point(9, 452);
            this.RentFromField.Name = "RentFromField";
            this.RentFromField.Size = new System.Drawing.Size(251, 20);
            this.RentFromField.TabIndex = 20;
            this.RentFromField.ValueChanged += new System.EventHandler(this.RentFromField_ValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(397, 428);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 20);
            this.label12.TabIndex = 19;
            this.label12.Text = "ReleaseDate";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(5, 428);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "Rent From";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RentalID,
            this.Customer_ID,
            this.Movie_ID,
            this.RentFrom,
            this.RentTill});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(960, 425);
            this.dataGridView3.TabIndex = 13;
            this.dataGridView3.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView3_CellClick);
            // 
            // RentalID
            // 
            this.RentalID.DataPropertyName = "RentalID";
            this.RentalID.HeaderText = "ID";
            this.RentalID.Name = "RentalID";
            this.RentalID.ReadOnly = true;
            // 
            // Customer_ID
            // 
            this.Customer_ID.DataPropertyName = "CustomerID";
            this.Customer_ID.HeaderText = "Customer ID";
            this.Customer_ID.Name = "Customer_ID";
            this.Customer_ID.ReadOnly = true;
            // 
            // Movie_ID
            // 
            this.Movie_ID.DataPropertyName = "MovieID";
            this.Movie_ID.HeaderText = "MovieID";
            this.Movie_ID.Name = "Movie_ID";
            this.Movie_ID.ReadOnly = true;
            // 
            // RentFrom
            // 
            this.RentFrom.DataPropertyName = "RentFrom";
            this.RentFrom.HeaderText = "Rent From";
            this.RentFrom.Name = "RentFrom";
            this.RentFrom.ReadOnly = true;
            this.RentFrom.Width = 307;
            // 
            // RentTill
            // 
            this.RentTill.DataPropertyName = "RentTill";
            this.RentTill.HeaderText = "Rent Till";
            this.RentTill.Name = "RentTill";
            this.RentTill.ReadOnly = true;
            this.RentTill.Width = 307;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 561);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovieCopiesField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovieRatingsField)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNameField;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneNumberField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button UpdateCustomer;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.Button DeleteCustomer;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox movieTitleField;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.NumericUpDown MovieRatingsField;
        private System.Windows.Forms.DateTimePicker MovieReleaseDateField;
        private System.Windows.Forms.NumericUpDown MovieCopiesField;
        private System.Windows.Forms.TextBox MovieRentingCostField;
        private System.Windows.Forms.Button DeleteMovie;
        private System.Windows.Forms.Button UpdateMovie;
        private System.Windows.Forms.Button AddMovie;
        private System.Windows.Forms.ComboBox MovieGenreField;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker RentTillField;
        private System.Windows.Forms.DateTimePicker RentFromField;
        private System.Windows.Forms.Button ReturnMovie;
        private System.Windows.Forms.Button IssueMovie;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieID;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieRatings;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieReleaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieCopies;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieRentingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn MovieGenre;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Customer_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Movie_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentTill;
    }
}

