using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover
{
    public class Rover
    {
        public int X { get; set; }
        public int Y { get; set; }
        public HeadingType Heading { get; set; }
        public Rover(string str)
        {
            var data =  str.Split(' ');
            this.X = Convert.ToInt32(data[0]);
            this.Y = Convert.ToInt32(data[1]);

            var headinhstr = data[2].ToString();
            if (headinhstr == "N")
            {
                this.Heading = HeadingType.N;
            }
            else if (headinhstr == "S")
            {
                this.Heading = HeadingType.S;
            }
            else if (headinhstr == "E")
            {
                this.Heading = HeadingType.E;
            }
            else if (headinhstr == "W")
            {
                this.Heading = HeadingType.W;
            }
        }

        public string GetLocation()
        {
           return this.X + " " + this.Y + " " + this.Heading.ToString();
        }
    }
    public enum HeadingType
    {
        N, 
        S,
        E,
        W
    }
}
