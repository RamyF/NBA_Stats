using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_RFarah_Final.Classes.Fowards
{
    public class RetiredFoward:Foward
    {
        // field
        private int yearRetired;

        // property
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

        // constructor
        public RetiredFoward(int playerID, string name, int jerseyNum, string height, int draftYear, double weight, string college, double points,
            double rebounds, double assists, double freethrowPercent, double twoPointPercent, double threePointPercent, double per, double offRating,
            double defRating, int age, double steals, double turnovers, double blocks, int yearRetired, string videoLink) :
            base(playerID, name, jerseyNum, height, draftYear, weight, college, points,
            rebounds, assists, freethrowPercent, twoPointPercent, threePointPercent, per, offRating,
            defRating, age, steals, turnovers, blocks, videoLink)
        {
            this.YearRetired = yearRetired;
        }
    }
}
