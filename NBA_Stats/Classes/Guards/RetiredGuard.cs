using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_RFarah_Final
{
    public class RetiredGuard:Guard
    {
        // fields
        private int yearRetired;

        // properties
        public int YearRetired
        {
            get
            {
                return yearRetired;
            }

            set
            {
                this.yearRetired = value;
            }
        }

        public RetiredGuard(int playerID, string name, int jerseyNum, string height, int draftYear, double weight, string college, double points,
            double assists, double freethrowPercent, double twoPointPercent, double threePointPercent, double per, double offRating,
            double defRating, int age, double steals, double turnovers, int yearRetired, string videoLink)
            : base(playerID, name, jerseyNum, height, draftYear, weight, college, points, assists, freethrowPercent, twoPointPercent,
                  threePointPercent, per, offRating, defRating, age, steals, turnovers, videoLink)
        {
            this.YearRetired = yearRetired;
        }
    }
}
