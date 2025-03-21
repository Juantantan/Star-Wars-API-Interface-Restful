
using RestSharp;
using Star_Wars_API_Interface_Restful.Classes;
using Newtonsoft.Json;
using RestSharp.Serializers;
using System.Windows.Forms;

namespace Star_Wars_API_Interface_Restful
{
    public partial class Form1 : Form
    {
        List<Film> films;
        List<FilmBase> filmBases;
        List<PersonHomeworld> personsHomeworlds;
        Film film;
        string crawlText = "";
        System.Windows.Forms.Timer _timer;
        int _offset = 0;

        public Form1()
        {
            InitializeComponent();
            lbxCharacters.Visible = false;
            lbxPlanets.Visible = false;
            listBoxPlanets.Visible = false;
            listBoxHomeworlPerson.Visible = false;
        }
        private void InitializeTimer()
        {
            _timer = new System.Windows.Forms.Timer();
            _timer.Interval = 40; // Adjust for speed
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            _offset += 2; // Adjust for speed
            Invalidate();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw the text
            using (Font font = new Font("Arial", 15, FontStyle.Bold))
            {
                RectangleF rect = new RectangleF(80, _offset + 420, ClientSize.Width - 50, ClientSize.Height + 20);
                using (StringFormat sf = new StringFormat())
                {
                    sf.Alignment = StringAlignment.Near;
                    sf.LineAlignment = StringAlignment.Near;
                    // e.Graphics.DrawString(lbxSelectedFilmCrawl.Text, font, Brushes.Orange, rect, sf);
                    e.Graphics.DrawString(crawlText, font, Brushes.Orange, rect, sf);
                }
            }

            // Check if the text has scrolled off the top
            if (_offset > ClientSize.Height)
            {
                _offset = 0;
            }
        }
        private void btnGetInitialAPIData_Click(object sender, EventArgs e)
        {
            films = RestfulMethods.GetDeserializedFilms();
            filmBases = new List<FilmBase>();
            foreach (Film film in films)
            {
                FilmBase filmBase = new FilmBase();
                filmBase.episode_id = film.episode_id;
                filmBase.title = film.title;
                filmBase.release_date = film.release_date;
                filmBase.opening_crawl = film.opening_crawl;
                filmBases.Add(filmBase);
            }
            dGVFilms.DataSource = filmBases;
        }
        private void dGVFilms_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                e.RowIndex >= 0)
            {
                lbxCharacters.Visible = true;
                lbxPlanets.Visible = true;
                listBoxPlanets.Visible = true;
                listBoxHomeworlPerson.Visible = true;

                listBoxPlanets.Items.Clear();
                listBoxHomeworlPerson.Items.Clear();

                film = films[e.RowIndex];

                // Set openiung crawl text for selected film

                // lbxSelectedFilmCrawl.Text = film.opening_crawl;
                crawlText = film.opening_crawl;
                InitializeTimer();

                //foreach (string s in film.planets)
                //{
                //    string planetId = s.Remove(0, 30);
                //    planetId = planetId.Replace("/", "");
                //    Planet planet = RestfulMethods.GetPlanet(planetId);

                //    listBoxPlanets.Items.Add(planet.name);
                //}

                //// Get Characters & Group by Homeworld
                //personsHomeworlds = new List<PersonHomeworld>();

                //foreach (string s in film.characters)
                //{
                //    string personId = s.Remove(0, 29);
                //    personId = personId.Replace("/", "");
                //    Person person = RestfulMethods.GetPerson(personId);

                //    string homeworld = person.homeworld;
                //    homeworld = homeworld.Remove(0, 30);
                //    homeworld = homeworld.Replace("/", "");
                //    Planet planet = RestfulMethods.GetPlanet(homeworld);

                //    PersonHomeworld personHomeworld = new PersonHomeworld();
                //    personHomeworld.Person = person.name;
                //    personHomeworld.Homeworld = planet.name;

                //    personsHomeworlds.Add(personHomeworld);
                //}

                //personsHomeworlds.Sort(delegate (PersonHomeworld pH1, PersonHomeworld pH2) { return pH1.Homeworld.CompareTo(pH2.Homeworld); });
                
                //string homeworldOrdered = ""; 
                //for (int i = 0; i < personsHomeworlds.Count; i++) 
                //{
                //    string spacer = new string(' ', 20 - personsHomeworlds[i].Homeworld.Length);
                //    string homeworldSpacer = new string(' ', personsHomeworlds[i].Homeworld.Length);

                //    if (i != 0 && personsHomeworlds[i].Homeworld != homeworldOrdered)
                //    {
                //        listBoxHomeworlPerson.Items.Add(Environment.NewLine);
                //    }
                    
                //    if (personsHomeworlds[i].Homeworld != homeworldOrdered)
                //    {
                //        listBoxHomeworlPerson.Items.Add($"{personsHomeworlds[i].Homeworld}{Environment.NewLine}{spacer}\t{personsHomeworlds[i].Person}");
                //    }
                //    else
                //    {
                //        listBoxHomeworlPerson.Items.Add($"{homeworldSpacer}{spacer}\t{personsHomeworlds[i].Person}");
                //    }
                //    homeworldOrdered = personsHomeworlds[i].Homeworld;
                //}

            }
        }

    }

}
