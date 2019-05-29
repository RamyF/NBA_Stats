using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_RFarah_Final.Classes.Centers
{
    public class ActiveCenter:Center , ITeam
    {
        private int yearsExp;
        private string team;

        public int YearsExp
        {
            get
            {
                return yearsExp;
            }

            set
            {
                this.yearsExp = value;
            }
        }

        public string Team
        {
            get
            {
                return this.team;
            }

            set
            {
                this.team = value;
            }
        }

        public string ReturnTeam()
        {
            return this.team.ToString();
        }


        public ActiveCenter(int playerID, string name, int jerseyNum, string height, int draftYear, int weight, string college, double points,
            double assists, double freethrowPercent, double twoPointPercent, double threePointPercent, double per, double offRating,
            double defRating, int age, double blocks, double offRebounds, double defRebounds, int yearsExp, string team, string videoLink)
            : base (playerID, name, jerseyNum, height, draftYear, weight, college, points, assists, freethrowPercent,
                  twoPointPercent, threePointPercent, per, offRating, defRating, age, blocks, offRebounds, defRebounds, videoLink)
        {
            this.yearsExp = yearsExp;
            this.Team = team;
        }
    }
}
