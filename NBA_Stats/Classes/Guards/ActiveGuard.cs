using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_RFarah_Final
{
    public class ActiveGuard:Guard
    {
        private int yearsExp;
        private string team;

        public ActiveGuard(int playerID, string name, int jerseyNum, string height, int draftYear, double weight, string college, double points,
            double assists, double freethrowPercent, double twoPointPercent, double threePointPercent, double per, double offRating,
            double defRating, int age, double steals, double turnovers, int yearsExp, string team, string videoLink)
            : base(playerID, name, jerseyNum, height, draftYear, weight, college, points, assists, freethrowPercent, twoPointPercent,
                  threePointPercent, per, offRating, defRating, age, steals, turnovers, videoLink)
        {
            this.Team = team;
            this.YearsExp = yearsExp;
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

    }
}
