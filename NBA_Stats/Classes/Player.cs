using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC236_RFarah_Final
{
    public abstract class Player
    {
        // fields
        private string name, height, college, videoLink;
        private int draftYear, playerID, jerseyNum, age;
        private double weight, points, assists, freethrowPercent, twoPointPercent, threepointPercent, per, offRating, defRating;

        // base constructor for subclasses
        public Player(int playerID, string name, int jerseyNum, string height, int draftYear, double weight, string college, double points, 
            double assists, double freethrowPercent, double twoPointPercent, double threePointPercent, double per, double offRating,
            double defRating, int age, string videoLink)
        {
            this.PlayerID = playerID;
            this.Name = name;
            this.JerseyNum = jerseyNum;
            this.Height = height;
            this.College = college;
            this.DraftYear = draftYear;
            this.Weight = weight;
            this.Points = points;
            this.Assists = assists;
            this.FreethrowPercent = freethrowPercent;
            this.TwoPointPercent = twoPointPercent;
            this.ThreePointPercent = threePointPercent;
            this.Per = per;
            this.OffRating = offRating;
            this.DefRating = defRating;
            this.Age = age; 
            this.VideoLink = videoLink;
        }

        // properties
        public int PlayerID
        {
            get
            {
                return playerID;
            }

            set
            {
                this.playerID = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                this.name = value;
            }
        }

        public int JerseyNum
        {
            get
            {
                return this.jerseyNum;
            }

            set
            {
                this.jerseyNum = value;
            }
        }

        public string Height
        {
            get
            {
                return height;
            }

            set
            {
                this.height = value;
            }
        }

        public string College
        {
            get
            {
                return college;
            }

            set
            {
                this.college = value;
            }
        }

        public int DraftYear
        {
            get
            {
                return draftYear;
            }

            set
            {
                this.draftYear = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                this.weight = value;
            }
        }

        public double Points
        {
            get
            {
                return points;
            }

            set
            {
                this.points = value;
            }
        }

        public double Assists
        {
            get
            {
                return assists;
            }

            set
            {
                this.assists = value;
            }
        }

        public double FreethrowPercent
        {
            get
            {
                return freethrowPercent;
            }

            set
            {
                this.freethrowPercent = value;
            }
        }
        public double TwoPointPercent
        {
            get
            {
                return twoPointPercent;
            }

            set
            {
                this.twoPointPercent = value;
            }
        }
        public double ThreePointPercent
        {
            get
            {
                return threepointPercent;
            }

            set
            {
                this.threepointPercent = value;
            }
        }

        public double Per
        {
            get
            {
                return per;
            }

            set
            {
                this.per = value;
            }
        }

        public double OffRating
        {
            get
            {
                return offRating;
            }

            set
            {
                this.offRating = value;
            }
        }
        public double DefRating
        {
            get
            {
                return defRating;
            }

            set
            {
                this.defRating = value;
            }
        }
        
        public int Age
        {
            get
            {
                return this.age;
            }

            set
            {
                this.age = value;
            }
        }

        public string VideoLink
        {
            get
            {
                return this.videoLink;
            }

            set
            {
                this.videoLink = value;
            }
        }
    }
}