using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover
{
    public class MCommand: ICommand
    {
        private Rover _rover { get; set; }

        public MCommand(Rover rover)
        {
            this._rover = rover;
        }

        public void Execute()
        {
           if(_rover.Heading == HeadingType.N)
            {
                _rover.Y++;
            }
            else if (_rover.Heading == HeadingType.S)
            {
                _rover.Y--;
            }
            else if (_rover.Heading == HeadingType.W)
            {
                _rover.X--;
            }
            else if (_rover.Heading == HeadingType.E)
            {
                _rover.X++;
            }
            _rover.X = _rover.X % (Planet.GetPlanet().XMax + 1);
            _rover.Y = _rover.Y % (Planet.GetPlanet().YMax + 1);

            if (_rover.X < 0)
            {
                _rover.X = _rover.X + Planet.GetPlanet().XMax + 1;
            }

            if (_rover.Y < 0)
            {
                _rover.Y = _rover.Y + Planet.GetPlanet().YMax + 1;
            }

        }
    }
}
