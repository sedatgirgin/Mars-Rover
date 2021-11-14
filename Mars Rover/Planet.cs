using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover
{
    public class Planet
    {
        public int XMax { get; set; }
        public int YMax { get; set; }

        private static Planet instance = null;

        public static void init(string max)
        {
            if(instance == null)
            {
                instance = new Planet(max);
            }
        }

        private Planet(string max)
        {
            var data = max.Split(' ');

            this.XMax = Convert.ToInt32(data[0]);
            this.YMax = Convert.ToInt32(data[1]);
        }
        public static Planet GetPlanet()
        {
            return instance;
        }

    }
}
