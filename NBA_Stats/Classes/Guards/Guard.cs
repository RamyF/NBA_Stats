using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_RFarah_Final
{
    public abstract class Guard:Player
    {
        // fields
        private double steals, turnovers;

        // constructor 
        public Guard (int playerID, string name, int jerseyNum, string height, int draftYear, double weight, string college, double points,
            double assists, double freethrowPercent, double twoPointPercent, double threePointPercent, double per, double offRating,
            double defRating, int age, double steals, double turnovers, string videoLink) 
            : base(playerID, name, jerseyNum, height, draftYear, weight, college, points,
            assists, freethrowPercent, twoPointPercent, threePointPercent, per, offRating,
            defRating, age, videoLink)
        {
            this.Steals = steals;
            this.Turnovers = turnovers;
        }

        // Properties
        public double Steals
        {
            get
            {
                return steals;
            }

            set
            {
                this.steals = value;
            }
        }
        public double Turnovers
        {
            get
            {
                return turnovers;
            }

            set
            {
                this.turnovers = value;
            }
        }
    }
}
