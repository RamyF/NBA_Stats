using CSC236_RFarah_Final.Classes.Centers;
using CSC236_RFarah_Final.Classes.Fowards;
using CSC236_RFarah_Final.Forms;
using System;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Diagnostics;

namespace CSC236_RFarah_Final
{
    public partial class frmHome : Form
    {
        // arrays to hold player objects
         ActiveCenter[] currentCenters = new ActiveCenter[12];
         ActiveFoward[] currentFowards = new ActiveFoward[18];
         ActiveGuard[] currentGuards = new ActiveGuard[26];

        // DB objects to open DB/Tables
        SqlConnection connection;
        string connectionString;
        string sqlCommand;
        SqlCommand command;
        SqlDataReader dataReader;

        // counter variable for list index to populate player arrays
        int i;

        // Methods to create players from DB
        private void LoadActiveCenters()
        {
            i = 0; // initialize counter variable

            // open DB
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                sqlCommand = "SELECT * FROM ActiveCenters"; // SQL Query
                using (command = new SqlCommand(sqlCommand, connection))
                using (dataReader = command.ExecuteReader()) // execute sql command
                {
                    // Active Center Constructor variables
                    int playerID, jerseyNum, draftYear, age, yearsExp, weight;
                    string name, height, college, team, videoLink;
                    double points, assists, freethrowPercent, twoPointPercent, threePointPercent, per,
                        offRating, defRating, defRebounds, offRebounds, blocks;

                    // Active Center Ordinals to recieve column values from Active Centers Table
                    int playerIDOrdinal, jerseyNumOrdinal, draftYearOrdinal, ageOrdinal, yearsExpOrdinal, nameOrdinal, heightOrdinal,
                        collegeOrdinal, teamOrdinal, videoLinkOrdinal, pointsOrdinal, assistsOrdinal, freethrowPercentOrdinal,
                        twoPointPercentOrdinal, threePointPercentOrdinal, perOrdinal, offRatingOrdinal, defRatingOrdinal,
                        defReboundsOrdinal, offReboundsOrdinal, blocksOrdinal, weightOrdinal;

                    // get Ordinal DB values
                    playerIDOrdinal = dataReader.GetOrdinal("PlayerID");
                    nameOrdinal = dataReader.GetOrdinal("Player Name");
                    jerseyNumOrdinal = dataReader.GetOrdinal("JerseyNumber");
                    heightOrdinal = dataReader.GetOrdinal("Height");
                    draftYearOrdinal = dataReader.GetOrdinal("DraftYear");
                    weightOrdinal = dataReader.GetOrdinal("Weight");
                    collegeOrdinal = dataReader.GetOrdinal("College ");
                    pointsOrdinal = dataReader.GetOrdinal("PPG");
                    assistsOrdinal = dataReader.GetOrdinal("Assists");
                    freethrowPercentOrdinal = dataReader.GetOrdinal("Freethrow %");
                    twoPointPercentOrdinal = dataReader.GetOrdinal("2 Point %");
                    threePointPercentOrdinal = dataReader.GetOrdinal("3 Point % ");
                    perOrdinal = dataReader.GetOrdinal("PER");
                    offRatingOrdinal = dataReader.GetOrdinal("Offensive Rating");
                    defRatingOrdinal = dataReader.GetOrdinal("Defensive Rating");
                    ageOrdinal = dataReader.GetOrdinal("age");
                    blocksOrdinal = dataReader.GetOrdinal("Blocks");
                    offReboundsOrdinal = dataReader.GetOrdinal("Offensive Rebounds");
                    defReboundsOrdinal = dataReader.GetOrdinal("Defensive Rebounds");
                    yearsExpOrdinal = dataReader.GetOrdinal("Years Exp");
                    teamOrdinal = dataReader.GetOrdinal("Team");
                    videoLinkOrdinal = dataReader.GetOrdinal("Video Link");

                    while (dataReader.Read())
                    {
                        // convert ordinal values to constructor variables
                        playerID = dataReader.GetInt32(playerIDOrdinal);
                        jerseyNum = dataReader.GetInt32(jerseyNumOrdinal);
                        draftYear = dataReader.GetInt32(draftYearOrdinal);
                        age = dataReader.GetInt32(ageOrdinal);
                        yearsExp = dataReader.GetInt32(yearsExpOrdinal);
                        name = dataReader.GetString(nameOrdinal);
                        height = dataReader.GetString(heightOrdinal);
                        college = dataReader.GetString(collegeOrdinal);
                        team = dataReader.GetString(teamOrdinal);
                        videoLink = dataReader.GetString(videoLinkOrdinal);
                        points = dataReader.GetDouble(pointsOrdinal);
                        assists = dataReader.GetDouble(assistsOrdinal);
                        freethrowPercent = dataReader.GetDouble(freethrowPercentOrdinal);
                        twoPointPercent = dataReader.GetDouble(twoPointPercentOrdinal);
                        threePointPercent = dataReader.GetDouble(threePointPercentOrdinal);
                        per = dataReader.GetDouble(perOrdinal);
                        offRating = dataReader.GetDouble(offRatingOrdinal);
                        defRating = dataReader.GetDouble(defRatingOrdinal);
                        defRebounds = dataReader.GetDouble(defReboundsOrdinal);
                        offRebounds = dataReader.GetDouble(offReboundsOrdinal);
                        blocks = dataReader.GetDouble(blocksOrdinal);
                        weight = dataReader.GetInt32(weightOrdinal);


                        // instantiate new player
                        currentCenters[i] = new ActiveCenter(playerID, name, jerseyNum, height, draftYear, weight, college, points, assists, freethrowPercent,
                            twoPointPercent, threePointPercent, per, offRating, defRating, age, blocks, offRebounds, defRebounds, yearsExp, team, videoLink);
                        i++;
                    }

                }

            }

        }
        private void LoadActiveFowards()
        {
            i = 0;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                sqlCommand = "SELECT * FROM ActiveFowards";
                using (command = new SqlCommand(sqlCommand, connection))
                using (dataReader = command.ExecuteReader())
                {
                    // Active Center Constructor variables
                    int playerID, jerseyNum, draftYear, age, yearsExp, weight;
                    string name, height, college, team, videoLink;
                    double points, assists, freethrowPercent, twoPointPercent, threePointPercent, per,
                        offRating, defRating, blocks, steals, turnovers, rebounds;

                    // Active Center Ordinals to recieve column values from Active Centers Table
                    int playerIDOrdinal, jerseyNumOrdinal, draftYearOrdinal, ageOrdinal, yearsExpOrdinal, nameOrdinal, heightOrdinal,
                        collegeOrdinal, teamOrdinal, videoLinkOrdinal, pointsOrdinal, assistsOrdinal, freethrowPercentOrdinal,
                        twoPointPercentOrdinal, threePointPercentOrdinal, perOrdinal, offRatingOrdinal, defRatingOrdinal,
                        blocksOrdinal, weightOrdinal, stealsOrdinal, turnoversOrdinal, reboundsOrdinal;

                    // get Ordinal DB values
                    playerIDOrdinal = dataReader.GetOrdinal("PlayerID");
                    nameOrdinal = dataReader.GetOrdinal("Player Name");
                    jerseyNumOrdinal = dataReader.GetOrdinal("JerseyNumber");
                    heightOrdinal = dataReader.GetOrdinal("Height");
                    draftYearOrdinal = dataReader.GetOrdinal("DraftYear");
                    weightOrdinal = dataReader.GetOrdinal("Weight");
                    collegeOrdinal = dataReader.GetOrdinal("College ");
                    pointsOrdinal = dataReader.GetOrdinal("PPG");
                    assistsOrdinal = dataReader.GetOrdinal("Assists");
                    freethrowPercentOrdinal = dataReader.GetOrdinal("Freethrow %");
                    twoPointPercentOrdinal = dataReader.GetOrdinal("2 Point %");
                    threePointPercentOrdinal = dataReader.GetOrdinal("3 Point % ");
                    perOrdinal = dataReader.GetOrdinal("PER");
                    offRatingOrdinal = dataReader.GetOrdinal("Offensive Rating");
                    defRatingOrdinal = dataReader.GetOrdinal("Defensive Rating");
                    ageOrdinal = dataReader.GetOrdinal("age");
                    blocksOrdinal = dataReader.GetOrdinal("Blocks");
                    yearsExpOrdinal = dataReader.GetOrdinal("Years Exp");
                    teamOrdinal = dataReader.GetOrdinal("Team");
                    videoLinkOrdinal = dataReader.GetOrdinal("Video Link");
                    stealsOrdinal = dataReader.GetOrdinal("Steals");
                    turnoversOrdinal = dataReader.GetOrdinal("Turnovers");
                    reboundsOrdinal = dataReader.GetOrdinal("Rebounds");
                    // counter variable for list index
                    int i = 0;
                    while (dataReader.Read())
                    {
                        // convert ordinal values to constructor variables
                        playerID = dataReader.GetInt32(playerIDOrdinal);
                        jerseyNum = dataReader.GetInt32(jerseyNumOrdinal);
                        draftYear = dataReader.GetInt32(draftYearOrdinal);
                        age = dataReader.GetInt32(ageOrdinal);
                        yearsExp = dataReader.GetInt32(yearsExpOrdinal);
                        name = dataReader.GetString(nameOrdinal);
                        height = dataReader.GetString(heightOrdinal);
                        college = dataReader.GetString(collegeOrdinal);
                        team = dataReader.GetString(teamOrdinal);
                        videoLink = dataReader.GetString(videoLinkOrdinal);
                        points = dataReader.GetDouble(pointsOrdinal);
                        assists = dataReader.GetDouble(assistsOrdinal);
                        freethrowPercent = dataReader.GetDouble(freethrowPercentOrdinal);
                        twoPointPercent = dataReader.GetDouble(twoPointPercentOrdinal);
                        threePointPercent = dataReader.GetDouble(threePointPercentOrdinal);
                        per = dataReader.GetDouble(perOrdinal);
                        offRating = dataReader.GetDouble(offRatingOrdinal);
                        defRating = dataReader.GetDouble(defRatingOrdinal);
                        blocks = dataReader.GetDouble(blocksOrdinal);
                        weight = dataReader.GetInt32(weightOrdinal);
                        steals = dataReader.GetDouble(stealsOrdinal);
                        rebounds = dataReader.GetDouble(reboundsOrdinal);
                        turnovers = dataReader.GetDouble(turnoversOrdinal);


                        currentFowards[i] = new ActiveFoward(playerID, name, jerseyNum, height, draftYear, weight, college, points, rebounds, assists,
                            freethrowPercent, twoPointPercent, threePointPercent, per, offRating, defRating, age, steals, turnovers, blocks, yearsExp, team,
                            videoLink);
                        i++;
                    }

                }

            }
        }
        private void LoadActiveGuards()
        {
            i = 0;
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();
                sqlCommand = "SELECT * FROM ActiveGuards";
                using (command = new SqlCommand(sqlCommand, connection))
                using (dataReader = command.ExecuteReader())
                {
                    // Active Center Constructor variables
                    int playerID, jerseyNum, draftYear, age, yearsExp, weight;
                    string name, height, college, team, videoLink;
                    double points, assists, freethrowPercent, twoPointPercent, threePointPercent, per,
                        offRating, defRating, steals, turnovers;

                    // Active Center Ordinals to recieve column values from Active Centers Table
                    int playerIDOrdinal, jerseyNumOrdinal, draftYearOrdinal, ageOrdinal, yearsExpOrdinal, nameOrdinal, heightOrdinal,
                        collegeOrdinal, teamOrdinal, videoLinkOrdinal, pointsOrdinal, assistsOrdinal, freethrowPercentOrdinal,
                        twoPointPercentOrdinal, threePointPercentOrdinal, perOrdinal, offRatingOrdinal, defRatingOrdinal,
                        weightOrdinal, stealsOrdinal, turnoversOrdinal;

                    // get Ordinal DB values
                    playerIDOrdinal = dataReader.GetOrdinal("PlayerID");
                    nameOrdinal = dataReader.GetOrdinal("Player Name");
                    jerseyNumOrdinal = dataReader.GetOrdinal("JerseyNumber");
                    heightOrdinal = dataReader.GetOrdinal("Height");
                    draftYearOrdinal = dataReader.GetOrdinal("DraftYear");
                    weightOrdinal = dataReader.GetOrdinal("Weight");
                    collegeOrdinal = dataReader.GetOrdinal("College ");
                    pointsOrdinal = dataReader.GetOrdinal("PPG");
                    assistsOrdinal = dataReader.GetOrdinal("Assists");
                    freethrowPercentOrdinal = dataReader.GetOrdinal("Freethrow %");
                    twoPointPercentOrdinal = dataReader.GetOrdinal("2 Point %");
                    threePointPercentOrdinal = dataReader.GetOrdinal("3 Point % ");
                    perOrdinal = dataReader.GetOrdinal("PER");
                    offRatingOrdinal = dataReader.GetOrdinal("Offensive Rating");
                    defRatingOrdinal = dataReader.GetOrdinal("Defensive Rating");
                    ageOrdinal = dataReader.GetOrdinal("age");
                    yearsExpOrdinal = dataReader.GetOrdinal("Years Exp");
                    teamOrdinal = dataReader.GetOrdinal("Team");
                    videoLinkOrdinal = dataReader.GetOrdinal("Video Link");
                    stealsOrdinal = dataReader.GetOrdinal("Steals");
                    turnoversOrdinal = dataReader.GetOrdinal("Turnovers");
                    // counter variable for list index
                    int i = 0;
                    while (dataReader.Read())
                    {
                        // convert ordinal values to constructor variables
                        playerID = dataReader.GetInt32(playerIDOrdinal);
                        jerseyNum = dataReader.GetInt32(jerseyNumOrdinal);
                        draftYear = dataReader.GetInt32(draftYearOrdinal);
                        age = dataReader.GetInt32(ageOrdinal);
                        yearsExp = dataReader.GetInt32(yearsExpOrdinal);
                        name = dataReader.GetString(nameOrdinal);
                        height = dataReader.GetString(heightOrdinal);
                        college = dataReader.GetString(collegeOrdinal);
                        team = dataReader.GetString(teamOrdinal);
                        videoLink = dataReader.GetString(videoLinkOrdinal);
                        points = dataReader.GetDouble(pointsOrdinal);
                        assists = dataReader.GetDouble(assistsOrdinal);
                        freethrowPercent = dataReader.GetDouble(freethrowPercentOrdinal);
                        twoPointPercent = dataReader.GetDouble(twoPointPercentOrdinal);
                        threePointPercent = dataReader.GetDouble(threePointPercentOrdinal);
                        per = dataReader.GetDouble(perOrdinal);
                        offRating = dataReader.GetDouble(offRatingOrdinal);
                        defRating = dataReader.GetDouble(defRatingOrdinal);
                        weight = dataReader.GetInt32(weightOrdinal);
                        steals = dataReader.GetDouble(stealsOrdinal);
                        turnovers = dataReader.GetDouble(turnoversOrdinal);


                        currentGuards[i] = new ActiveGuard(playerID, name, jerseyNum, height, draftYear, weight, college, points,
                            assists, freethrowPercent, twoPointPercent, threePointPercent, per, offRating,
                            defRating, age, steals, turnovers, yearsExp, team, videoLink);
                        i++;

                    }

                }

            }
        }

        public frmHome()
        {
            InitializeComponent();

            // DB connection path
            connectionString = ConfigurationManager.ConnectionStrings["CSC236_RFarah_Final.Properties.Settings.PlayerDBConnectionString"].ConnectionString;
        }

        protected override void OnLoad(EventArgs e)
        {
            string welcomeMessage = "Welcome! The 2018 - 2019 NBA season has offically started. Keep " +
                "up with your favorite players highlights or stats, see who is leading the league in points, and more.";
            lblAppDescription.Text = welcomeMessage;

            // populate player lists
            LoadActiveCenters();
            LoadActiveFowards();
            LoadActiveGuards();
        }

        private void btnPlayerSearch_Click(object sender, EventArgs e)
        {
            frmPlayerSearch playerSearchform = new frmPlayerSearch(currentGuards, currentFowards, currentCenters);
            playerSearchform.Show();
        }

        private void lnkStory1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://bleacherreport.com/articles/2809306-video-luka-doncic-drops-21-points-buries-trail-blazers-with-step-back-3");
        }

        private void lnkStory2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.forbes.com/sites/gordiejones/2018/12/04/76ers-have-improved-but-an-early-milepost-awaits-in-toronto/#6de3272415ff");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.boston.com/sports/boston-celtics/2018/12/02/gordon-hayward-kyrie-irving-jayson-tatum-celtics");
        }

        private void requestPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RequestPlayer requestPlayerForm = new RequestPlayer();
            requestPlayerForm.Show();
        }
    }

}







//pbNBALogo.ImageLocation = "https://asset-sports.abs-cbn.com/web/dev/articles/1499473094_nba-primary-logo-small.jpg";
//pbNBALogo.Load();
//base.OnLoad(e);
//var embed = "<html><head>" +
//"<meta http-equiv=\"X-UA-Compatible\" content=\"IE=Edge\"/>" +
//"</head><body>" +
//"<iframe width=\"500\" src=\"{0}\"" +
//"frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
//"</body></html>";
//var url = "https://www.youtube.com/embed/U9YIa4ASBck";
//this.webBrowser1.DocumentText = string.Format(embed, url);



