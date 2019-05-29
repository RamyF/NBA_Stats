using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_RFarah_Final.Classes.Fowards
{
    public abstract class Foward:Player
    {
        private double steals, turnovers, blocks, rebounds;

        public double Rebounds
        {
            get
            {
                return this.rebounds;
            }

            set
            {
                this.rebounds = value;
            }
        }
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
        public double Blocks
        {
            get
            {
                return blocks;
            }

            set
            {
                this.blocks = value;
            }
        }

        public Foward(int playerID, string name, int jerseyNum, string height, int draftYear, double weight, string college, double points,
            double rebounds, double assists, double freethrowPercent, double twoPointPercent, double threePointPercent, double per, double offRating,
            double defRating, int age, double steals, double turnovers, double blocks, string videoLink)
            : base(playerID, name, jerseyNum, height, draftYear, weight, college, points,
            assists, freethrowPercent, twoPointPercent, threePointPercent, per, offRating,
            defRating, age, videoLink)
        {
            this.Steals = steals;
            this.Turnovers = turnovers;
            this.Blocks = blocks;
            this.Rebounds = rebounds;
        }

    }
}
