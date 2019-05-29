using CSC236_RFarah_Final.Classes.Centers;
using CSC236_RFarah_Final.Classes.Fowards;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_RFarah_Final.Forms
{
    public partial class frmPlayerInfo : Form
    {
        delegate void GuardPictures(ActiveGuard player);
        delegate void FowardPictures(ActiveFoward player);
        delegate void CenterPictures(ActiveCenter player);
        public frmPlayerInfo()
        {
            InitializeComponent();
        }

        public frmPlayerInfo(ActiveGuard tag)
        {
            InitializeComponent();
            ActiveGuard guard = tag;
            lblName.Text = guard.Name; // name property from player class
            lblPlayerPoints.Text = guard.Points.ToString();
            lblRebounds.Text = "Steals:";
            lblPlayerRebounds.Text = guard.Steals.ToString();
            lblPlayerAssists.Text = guard.Assists.ToString();
            lblPlayerPER.Text = guard.Per.ToString();
            lblPlayerOffRating.Text = guard.OffRating.ToString();
            lblPlayerDefRating.Text = guard.DefRating.ToString();
            lblAge.Text = guard.Age.ToString();
            lblExperience.Text = guard.YearsExp.ToString() + " Years";
            lblYearDrafted.Text = guard.DraftYear.ToString();
            lblTeam.Text = guard.Team.ToString();

            var embed = "<html><head>" +
            "<meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\"/>" +
            "</head><body>" +
            "<iframe width=\"640\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = guard.VideoLink.ToString();
            this.browser.DocumentText = string.Format(embed, url);

            GuardPictures guardPics = ShowGuardPic; // delegate assignment
            guardPics.Invoke(guard);

        }

        void ShowGuardPic(ActiveGuard guard)
        {
            if (guard.PlayerID == 13)
                pbxPlayer.Image = Resources.Resource1.Stephen_Curry;
            else if (guard.PlayerID == 14)
                pbxPlayer.Image = Resources.Resource1.James_Harden;
            else if (guard.PlayerID == 15)
                pbxPlayer.Image = Resources.Resource1.Chris_Paul;
            else if (guard.PlayerID == 16)
                pbxPlayer.Image = Resources.Resource1.Klay_Thompson;
            else if (guard.PlayerID == 17)
                pbxPlayer.Image = Resources.Resource1.CJ_Mccollum;
            else if (guard.PlayerID == 18)
                pbxPlayer.Image = Resources.Resource1.Damian_Lillard;
            else if (guard.PlayerID == 19)
                pbxPlayer.Image = Resources.Resource1.Russell_Westbrook;
            else if (guard.PlayerID == 20)
                pbxPlayer.Image = Resources.Resource1.Donovan_Mitchell;
            else if (guard.PlayerID == 21)
                pbxPlayer.Image = Resources.Resource1.Tony_Parker;
            else if (guard.PlayerID == 22)
                pbxPlayer.Image = Resources.Resource1.Jimmy_Butler;
            else if (guard.PlayerID == 23)
                pbxPlayer.Image = Resources.Resource1.Kyle_Lowry;
            else if (guard.PlayerID == 24)
                pbxPlayer.Image = Resources.Resource1.Demar_DeRozan;
            else if (guard.PlayerID == 25)
                pbxPlayer.Image = Resources.Resource1.Kyrie_Irving;
            else if (guard.PlayerID == 26)
                pbxPlayer.Image = Resources.Resource1.Victor_Oladipo;
            else if (guard.PlayerID == 27)
                pbxPlayer.Image = Resources.Resource1.Goran_Dragic;
            else if (guard.PlayerID == 28)
                pbxPlayer.Image = Resources.Resource1.Dwayne_Wade;
            else if (guard.PlayerID == 29)
                pbxPlayer.Image = Resources.Resource1.John_Wall;
            else if (guard.PlayerID == 30)
                pbxPlayer.Image = Resources.Resource1.Bradely_Beal;
            else if (guard.PlayerID == 31)
                pbxPlayer.Image = Resources.Resource1.Kemba_Walker;
            else if (guard.PlayerID == 32)
                pbxPlayer.Image = Resources.Resource1.Lou_Williams;
            else if (guard.PlayerID == 33)
                pbxPlayer.Image = Resources.Resource1.Isaiah_Thomas;
            else if (guard.PlayerID == 34)
                pbxPlayer.Image = Resources.Resource1.Mike_Conley;
            else if (guard.PlayerID == 35)
                pbxPlayer.Image = Resources.Resource1.Devin_Booker;
            else if (guard.PlayerID == 36)
                pbxPlayer.Image = Resources.Resource1.Jrue_Holiday;
            else if (guard.PlayerID == 37)
                pbxPlayer.Image = Resources.Resource1.JJ_Redick;
            else if (guard.PlayerID == 38)
                pbxPlayer.Image = Resources.Resource1.Eric_Gordon;
        }

        public frmPlayerInfo(ActiveFoward tag)
        {
            InitializeComponent();
            ActiveFoward foward = tag;
            lblName.Text = foward.Name;
            lblPlayerPoints.Text = foward.Points.ToString();
            lblPlayerRebounds.Text = foward.Rebounds.ToString();
            lblPlayerAssists.Text = foward.Assists.ToString();
            lblPlayerPER.Text = foward.Per.ToString();
            lblPlayerOffRating.Text = foward.OffRating.ToString();
            lblPlayerDefRating.Text = foward.DefRating.ToString();
            lblAge.Text = foward.Age.ToString();
            lblExperience.Text = foward.YearsExp.ToString() + " Years";
            lblYearDrafted.Text = foward.DraftYear.ToString();
            lblTeam.Text = foward.Team.ToString();


            var embed = "<html><head>" +
            "<meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\"/>" +
            "</head><body>" +
            "<iframe width=\"640\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = foward.VideoLink.ToString();
            this.browser.DocumentText = string.Format(embed, url);
            FowardPictures fPics = ShowFowardPic; // delegate assignment
            fPics.Invoke(foward);
            
        }

        void ShowFowardPic(ActiveFoward foward)
        {
            if (foward.PlayerID == 39)
                pbxPlayer.Image = Resources.Resource1.Kevin_Durant;
            else if (foward.PlayerID == 40)
                pbxPlayer.Image = Resources.Resource1.Draymond_Green;
            else if (foward.PlayerID == 41)
                pbxPlayer.Image = Resources.Resource1.Paul_George;
            else if (foward.PlayerID == 42)
                pbxPlayer.Image = Resources.Resource1.Carmelo_Anthony;
            else if (foward.PlayerID == 43)
                pbxPlayer.Image = Resources.Resource1.Lamarcus_Aldridge;
            else if (foward.PlayerID == 44)
                pbxPlayer.Image = Resources.Resource1.Kawhi_Leonard;
            else if (foward.PlayerID == 45)
                pbxPlayer.Image = Resources.Resource1.Gordon_Hayward;
            else if (foward.PlayerID == 46)
                pbxPlayer.Image = Resources.Resource1.Jason_Tatum;
            else if (foward.PlayerID == 47)
                pbxPlayer.Image = Resources.Resource1.Ben_Simmons;
            else if (foward.PlayerID == 48)
                pbxPlayer.Image = Resources.Resource1.Lebron_James;
            else if (foward.PlayerID == 49)
                pbxPlayer.Image = Resources.Resource1.Kevin_Love;
            else if (foward.PlayerID == 50)
                pbxPlayer.Image = Resources.Resource1.GreekFreek;
            else if (foward.PlayerID == 51)
                pbxPlayer.Image = Resources.Resource1.Blake_Griffin;
            else if (foward.PlayerID == 52)
                pbxPlayer.Image = Resources.Resource1.Paul_Millsap;
            else if (foward.PlayerID == 53)
                pbxPlayer.Image = Resources.Resource1.Vince_Carter;
            else if (foward.PlayerID == 54)
                pbxPlayer.Image = Resources.Resource1.Dirk;
            else if (foward.PlayerID == 55)
                pbxPlayer.Image = Resources.Resource1.Nicolas_Batum;
            else if (foward.PlayerID == 56)
                pbxPlayer.Image = Resources.Resource1.Andre_Iguodala;
        }

        public frmPlayerInfo(ActiveCenter tag)
        {
            InitializeComponent();
            ActiveCenter center = tag;
            lblName.Text = center.Name;
            lblPlayerPoints.Text = center.Points.ToString();
            lblPlayerRebounds.Text = Convert.ToString(center.OffRebounds + center.DefRebounds);
            lblPlayerAssists.Text = center.Assists.ToString();
            lblPlayerPER.Text = center.Per.ToString();
            lblPlayerOffRating.Text = center.OffRating.ToString();
            lblPlayerDefRating.Text = center.DefRating.ToString();
            lblAge.Text = center.Age.ToString();
            lblExperience.Text = center.YearsExp.ToString() + " Years";
            lblYearDrafted.Text = center.DraftYear.ToString();
            lblTeam.Text = center.ReturnTeam(); // use of ITeam
            CenterPictures cPics = ShowCenterPic; // delegate assignment
            cPics.Invoke(center);

            var embed = "<html><head>" +
            "<meta http-equiv=\"x-ua-compatible\" content=\"ie=edge\"/>" +
            "</head><body>" +
            "<iframe width=\"640\" src=\"{0}\"" +
            "frameborder = \"0\" allow = \"autoplay; encrypted-media\" allowfullscreen></iframe>" +
            "</body></html>";
            var url = center.VideoLink.ToString();
            this.browser.DocumentText = string.Format(embed, url);
        }

        void ShowCenterPic(ActiveCenter center)
        {
            if (center.PlayerID == 1)
                pbxPlayer.Image = Resources.Resource1.Demarcus_Cousins;
            else if (center.PlayerID == 2)
                pbxPlayer.Image = Resources.Resource1.Rudy_Gobert;
            else if (center.PlayerID == 3)
                pbxPlayer.Image = Resources.Resource1.Anthony_Davis;
            else if (center.PlayerID == 4)
                pbxPlayer.Image = Resources.Resource1.Pau_Gasol;
            else if (center.PlayerID == 5)
                pbxPlayer.Image = Resources.Resource1.KAT;
            else if (center.PlayerID == 6)
                pbxPlayer.Image = Resources.Resource1.Al_Horford;
            else if (center.PlayerID == 7)
                pbxPlayer.Image = Resources.Resource1.Joel_Embiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiid;
            else if (center.PlayerID == 8)
                pbxPlayer.Image = Resources.Resource1.Nikola_Jokic;
            else if (center.PlayerID == 9)
                pbxPlayer.Image = Resources.Resource1.Kristaps;
            else if (center.PlayerID == 10)
                pbxPlayer.Image = Resources.Resource1.Marc_Gasol;
            else if (center.PlayerID == 11)
                pbxPlayer.Image = Resources.Resource1.Steven_Adams;
            else if (center.PlayerID == 12)
                pbxPlayer.Image = Resources.Resource1.Clint_Capela;
        }
    }
}
