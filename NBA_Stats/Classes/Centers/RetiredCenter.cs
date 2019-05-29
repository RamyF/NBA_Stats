using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_RFarah_Final.Classes.Centers
{
    public class RetiredCenter:Center
    {
        private int yearRetired;

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

        public RetiredCenter(int playerID, string name, int jerseyNum, string height, int draftYear, double weight, string college, double points,
            double assists, double freethrowPercent, double twoPointPercent, double threePointPercent, double per, double offRating,
            double defRating, int age, double blocks, double offRebounds, double defRebounds, int yearRetired, string videoLink)
            : base(playerID, name, jerseyNum, height, draftYear, weight, college, points, assists, freethrowPercent,
                  twoPointPercent, threePointPercent, per, offRating, defRating, age, blocks, offRebounds, defRebounds, videoLink)
        {
            this.yearRetired = yearRetired;
        }
    }
}
