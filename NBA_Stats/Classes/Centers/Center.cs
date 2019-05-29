using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_RFarah_Final.Classes.Centers
{
    public abstract class Center:Player
    {
        // Fields
        private double blocks, offRebounds, defRebounds;

        // Properties
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

        public double OffRebounds
        {
            get
            {
                return offRebounds;
            }

            set
            {
                this.offRebounds = value;
            }
        }

        public double DefRebounds
        {
            get
            {
                return defRebounds;
            }

            set
            {
                this.defRebounds = value;
            }
        }

        // Constructors
        public Center(int playerID, string name, int jerseyNum, string height, int draftYear, double weight, string college, double points,
            double assists, double freethrowPercent, double twoPointPercent, double threePointPercent, double per, double offRating,
            double defRating, int age, double blocks, double offRebounds, double defRebounds, string videoLink) 
            : base(playerID, name, jerseyNum, height, draftYear, weight, college, points, assists, 
                  freethrowPercent, twoPointPercent, threePointPercent, per, offRating, defRating, age, videoLink)
        {
            this.blocks = blocks;
            this.offRebounds = offRebounds;
            this.defRebounds = defRebounds;
        }

    }
}
