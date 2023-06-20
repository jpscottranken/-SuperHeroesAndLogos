using System;
using System.Drawing;
using System.Windows.Forms;

namespace SportsLogos
{
    public partial class frmLogos : Form
    {
        public frmLogos()
        {
            InitializeComponent();
        }

        //  Global Arrays
        //  Holds values in the cboCityName ComboBox
        string[] cities =
        {
            "Select A City",
            "Atlanta",
            "Los Angeles",
            "Philadelphia"
        };

        //  Holds values in the Atlanta teams
        string[] atlantaTeams =
        {
            "Braves",
            "Hawks",
            "Falcons"
        };

        //  Holds values in the Los Angeles teams
        string[] losAngelesTeams =
        {
            "Dodgers",
            "Lakers",
            "Chargers"
        };

        //  Holds values in the Philadelphia teams
        string[] philadelphiaTeams =
        {
            "Phillies",
            "76ers",
            "Eagles"
        };

        //  Holds logos for the Atlanta teams
        string[] atlantaLogos =
        {
            @"C:\Users\jpscott\Desktop\SuperHeroesAndLogos\SuperHeroLogo\SportsLogos\images\mlb\braves.png",
            @"C:\Users\jpscott\Desktop\SuperHeroesAndLogos\SuperHeroLogo\SportsLogos\images\nba\hawks.png",
            @"C:\Users\jpscott\Desktop\SuperHeroesAndLogos\SuperHeroLogo\SportsLogos\images\nfl\falcons.png"
        };

        //  Holds logos for the Los Angeles teams
        string[] losangelesLogos =
        {
            @"C:\Users\jpscott\Desktop\SuperHeroesAndLogos\SuperHeroLogo\SportsLogos\images\mlb\dodgers.png",
            @"C:\Users\jpscott\Desktop\SuperHeroesAndLogos\SuperHeroLogo\SportsLogos\images\nba\lakers.png",
            @"C:\Users\jpscott\Desktop\SuperHeroesAndLogos\SuperHeroLogo\SportsLogos\images\nfl\chargers.png"
        };

        //  Holds logos for the Philadelphia teams
        string[] philadelphiaLogos =
        {
            @"C:\Users\jpscott\Desktop\SuperHeroesAndLogos\SuperHeroLogo\SportsLogos\images\mlb\phillies.png",
            @"C:\Users\jpscott\Desktop\SuperHeroesAndLogos\SuperHeroLogo\SportsLogos\images\nba\76ers.png",
            @"C:\Users\jpscott\Desktop\SuperHeroesAndLogos\SuperHeroLogo\SportsLogos\images\nfl\eagles.png"
        };

        private void frmLogos_Load(object sender, EventArgs e)
        {
            //for (int lcv = 0; lcv < cities.Length; lcv++)
            //{
            //    cboCityName.Items.Add(cities[lcv]);
            //}

            foreach (string city in cities)
            {
                cboCityName.Items.Add(city);
            }

            cboCityName.SelectedIndex = 0;

        }

        private void cboCityName_SelectedIndexChanged(object sender, EventArgs e)
        {
            AddCorrectLogosForCurrentCity();
        }

        private void AddCorrectLogosForCurrentCity()
        {
            cboTeamName.Text = "";

            int si = cboCityName.SelectedIndex;

            switch (si)
            {
                case 0:                 //  Select A City
                    SetHeaders();
                    break;

                case 1:                 //  City = Atlanta
                    SetHeaders();
                    FillAtlantaTeams();
                    break;

                case 2:                 //  City = Los Angeles
                    SetHeaders();
                    FillLosAngelesTeams();
                    break;

                case 3:                 //  City = Philadelphia
                    SetHeaders();
                    FillPhiladelphiaTeams();
                    break;

                default:
                    break;
            }
        }

        private void SetHeaders()
        {
            //  Clear the Team Name ComboBox
            cboTeamName.Items.Clear();
        }

        private void FillAtlantaTeams()
        {
            foreach (string a in atlantaTeams)
            {
                cboTeamName.Items.Add(a);
            }
        }

        private void FillLosAngelesTeams()
        {
            foreach (string l in losAngelesTeams)
            {
                cboTeamName.Items.Add(l);
            }
        }

        private void FillPhiladelphiaTeams()
        {
            foreach (string p in philadelphiaTeams)
            {
                cboTeamName.Items.Add(p);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            cboCityName.SelectedIndex = 0;
            cboTeamName.SelectedIndex = -1;
            pbLogo.Image = null;
        }


        private void cboTeamName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int si = cboCityName.SelectedIndex;

            switch (si)
            {
                case -1:
                case 0:
                    break;

                case 1:
                    pbLogo.Image =
                        System.Drawing.Image.FromFile(atlantaLogos[cboTeamName.SelectedIndex]);
                    break;

                case 2:
                    pbLogo.Image =
                        System.Drawing.Image.FromFile(losangelesLogos[cboTeamName.SelectedIndex]);
                    break;

                case 3:
                    pbLogo.Image =
                        System.Drawing.Image.FromFile(philadelphiaLogos[cboTeamName.SelectedIndex]);
                    break;
            }
        }

        private void chkShowStatistics_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowStatistics.Checked)
            {
                MessageBox.Show("The City Chosen Was: " + cboCityName.SelectedItem +
                              "\nThe Team Chosen Was: " + cboTeamName.SelectedItem,
                              "CITY NAME AND TEAM NAME SELECTED",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                   "Do You Really Want To Exit?",
                   "EXIT NOW?",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}
