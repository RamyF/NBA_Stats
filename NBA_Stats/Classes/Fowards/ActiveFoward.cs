using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_RFarah_Final.Classes.Fowards
{
    public class ActiveFoward:Foward
    {
        // field
        private int yearsExp;
        private string team;

        // property
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


        // constructor
        public ActiveFoward(int playerID, string name, int jerseyNum, string height, int draftYear, int weight, string college, double points,
            double rebounds, double assists, double freethrowPercent, double twoPointPercent, double threePointPercent, double per, double offRating,
            double defRating, int age, double steals, double turnovers, double blocks, int yearsExp, string team, string videoLink) :
            base (playerID, name, jerseyNum, height, draftYear, weight, college, points, rebounds, assists, freethrowPercent, twoPointPercent,
                threePointPercent, per, offRating, defRating, age, steals, turnovers, blocks, videoLink)
        {
            this.YearsExp = yearsExp;
            this.team = team;
        }

    }
}
