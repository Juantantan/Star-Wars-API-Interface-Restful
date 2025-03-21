namespace Star_Wars_API_Interface_Restful
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            btnGetInitialAPIData = new Button();
            dGVFilms = new DataGridView();
            colEpisode_id = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colReleaseDate = new DataGridViewTextBoxColumn();
            btnColumn = new DataGridViewButtonColumn();
            colOpening_crawl = new DataGridViewTextBoxColumn();
            listBoxPlanets = new ListBox();
            lbxPlanets = new Label();
            lbxCharacters = new Label();
            lbxFilms = new Label();
            filmBaseBindingSource = new BindingSource(components);
            filmBaseBindingSource1 = new BindingSource(components);
            homeworldDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            personHomeworldBindingSource = new BindingSource(components);
            listBoxHomeworlPerson = new ListBox();
            lbxSelectedFilmCrawl = new Label();
            timerCrawlScroller = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dGVFilms).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBaseBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)filmBaseBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)personHomeworldBindingSource).BeginInit();
            SuspendLayout();
            // 
            // btnGetInitialAPIData
            // 
            btnGetInitialAPIData.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGetInitialAPIData.Location = new Point(12, 12);
            btnGetInitialAPIData.Name = "btnGetInitialAPIData";
            btnGetInitialAPIData.Size = new Size(174, 35);
            btnGetInitialAPIData.TabIndex = 0;
            btnGetInitialAPIData.Text = "Get Star Wars Films";
            btnGetInitialAPIData.UseVisualStyleBackColor = true;
            btnGetInitialAPIData.Click += btnGetInitialAPIData_Click;
            // 
            // dGVFilms
            // 
            dGVFilms.AllowUserToAddRows = false;
            dGVFilms.AllowUserToOrderColumns = true;
            dGVFilms.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dGVFilms.Columns.AddRange(new DataGridViewColumn[] { colEpisode_id, colTitle, colReleaseDate, btnColumn, colOpening_crawl });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dGVFilms.DefaultCellStyle = dataGridViewCellStyle4;
            dGVFilms.Location = new Point(15, 84);
            dGVFilms.Name = "dGVFilms";
            dGVFilms.Size = new Size(469, 326);
            dGVFilms.TabIndex = 1;
            dGVFilms.CellContentClick += dGVFilms_CellContentClick;
            // 
            // colEpisode_id
            // 
            colEpisode_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colEpisode_id.DataPropertyName = "episode_id";
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            colEpisode_id.DefaultCellStyle = dataGridViewCellStyle1;
            colEpisode_id.HeaderText = "Episode";
            colEpisode_id.Name = "colEpisode_id";
            colEpisode_id.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitle.DataPropertyName = "title";
            colTitle.HeaderText = "Title";
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            colTitle.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colReleaseDate
            // 
            colReleaseDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colReleaseDate.DataPropertyName = "release_date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            colReleaseDate.DefaultCellStyle = dataGridViewCellStyle2;
            colReleaseDate.HeaderText = "Release Date";
            colReleaseDate.Name = "colReleaseDate";
            colReleaseDate.ReadOnly = true;
            // 
            // btnColumn
            // 
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            btnColumn.DefaultCellStyle = dataGridViewCellStyle3;
            btnColumn.HeaderText = "View Details";
            btnColumn.Name = "btnColumn";
            btnColumn.ReadOnly = true;
            btnColumn.Text = "Expand";
            // 
            // colOpening_crawl
            // 
            colOpening_crawl.DataPropertyName = "opening_crawl";
            colOpening_crawl.HeaderText = "";
            colOpening_crawl.Name = "colOpening_crawl";
            colOpening_crawl.ReadOnly = true;
            colOpening_crawl.Resizable = DataGridViewTriState.False;
            colOpening_crawl.Visible = false;
            // 
            // listBoxPlanets
            // 
            listBoxPlanets.FormattingEnabled = true;
            listBoxPlanets.ItemHeight = 15;
            listBoxPlanets.Location = new Point(504, 84);
            listBoxPlanets.Name = "listBoxPlanets";
            listBoxPlanets.Size = new Size(151, 319);
            listBoxPlanets.TabIndex = 2;
            // 
            // lbxPlanets
            // 
            lbxPlanets.AutoSize = true;
            lbxPlanets.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbxPlanets.ForeColor = Color.White;
            lbxPlanets.Location = new Point(504, 65);
            lbxPlanets.Name = "lbxPlanets";
            lbxPlanets.Size = new Size(53, 17);
            lbxPlanets.TabIndex = 4;
            lbxPlanets.Text = "Planets";
            // 
            // lbxCharacters
            // 
            lbxCharacters.AutoSize = true;
            lbxCharacters.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbxCharacters.ForeColor = Color.White;
            lbxCharacters.Location = new Point(674, 65);
            lbxCharacters.Name = "lbxCharacters";
            lbxCharacters.Size = new Size(167, 17);
            lbxCharacters.TabIndex = 5;
            lbxCharacters.Text = "Characters by Homeworld";
            // 
            // lbxFilms
            // 
            lbxFilms.AutoSize = true;
            lbxFilms.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbxFilms.ForeColor = Color.White;
            lbxFilms.Location = new Point(15, 64);
            lbxFilms.Name = "lbxFilms";
            lbxFilms.Size = new Size(103, 17);
            lbxFilms.TabIndex = 6;
            lbxFilms.Text = "Star Wars Films";
            // 
            // homeworldDataGridViewTextBoxColumn
            // 
            homeworldDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            homeworldDataGridViewTextBoxColumn.DataPropertyName = "Homeworld";
            homeworldDataGridViewTextBoxColumn.HeaderText = "Homeworld";
            homeworldDataGridViewTextBoxColumn.Name = "homeworldDataGridViewTextBoxColumn";
            // 
            // personDataGridViewTextBoxColumn
            // 
            personDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            personDataGridViewTextBoxColumn.DataPropertyName = "Person";
            personDataGridViewTextBoxColumn.HeaderText = "Person";
            personDataGridViewTextBoxColumn.Name = "personDataGridViewTextBoxColumn";
            // 
            // listBoxHomeworlPerson
            // 
            listBoxHomeworlPerson.FormattingEnabled = true;
            listBoxHomeworlPerson.ItemHeight = 15;
            listBoxHomeworlPerson.Location = new Point(674, 84);
            listBoxHomeworlPerson.Name = "listBoxHomeworlPerson";
            listBoxHomeworlPerson.Size = new Size(299, 319);
            listBoxHomeworlPerson.TabIndex = 10;
            // 
            // lbxSelectedFilmCrawl
            // 
            lbxSelectedFilmCrawl.AutoSize = true;
            lbxSelectedFilmCrawl.BackColor = SystemColors.ActiveCaptionText;
            lbxSelectedFilmCrawl.Font = new Font("Segoe UI", 11F);
            lbxSelectedFilmCrawl.ForeColor = Color.FromArgb(255, 128, 0);
            lbxSelectedFilmCrawl.Location = new Point(866, 12);
            lbxSelectedFilmCrawl.Name = "lbxSelectedFilmCrawl";
            lbxSelectedFilmCrawl.Size = new Size(107, 20);
            lbxSelectedFilmCrawl.TabIndex = 11;
            lbxSelectedFilmCrawl.Text = "Opening Crawl";
            lbxSelectedFilmCrawl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1013, 878);
            Controls.Add(lbxSelectedFilmCrawl);
            Controls.Add(listBoxHomeworlPerson);
            Controls.Add(lbxFilms);
            Controls.Add(lbxCharacters);
            Controls.Add(lbxPlanets);
            Controls.Add(listBoxPlanets);
            Controls.Add(dGVFilms);
            Controls.Add(btnGetInitialAPIData);
            Name = "Form1";
            Text = "Star Wars movie details from swapi web api";
            ((System.ComponentModel.ISupportInitialize)dGVFilms).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBaseBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)filmBaseBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)personHomeworldBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetInitialAPIData;
        private DataGridView dGVFilms;
        private ListBox listBoxPlanets;
        private Label lbxPlanets;
        private Label lbxCharacters;
        private Label lbxFilms;
        private BindingSource filmBaseBindingSource;
        private BindingSource filmBaseBindingSource1;
        private BindingSource personHomeworldBindingSource;
        private DataGridViewTextBoxColumn homeworldDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn personDataGridViewTextBoxColumn;
        private ListBox listBoxHomeworlPerson;
        private Label lbxSelectedFilmCrawl;
        private System.Windows.Forms.Timer timerCrawlScroller;
        private DataGridViewTextBoxColumn colEpisode_id;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colReleaseDate;
        private DataGridViewButtonColumn btnColumn;
        private DataGridViewTextBoxColumn colOpening_crawl;
    }
}
