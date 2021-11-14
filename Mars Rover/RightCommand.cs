using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover
{
    public class RightCommand: ICommand
    {
        private Rover _rover { get; set; }

        public RightCommand(Rover rover)
        {
            this._rover = rover;
        }

        public void Execute()
        {
            if (this._rover.Heading == HeadingType.N)
            {
                this._rover.Heading = HeadingType.E;
            }
            else if (this._rover.Heading == HeadingType.W)
            {
                this._rover.Heading = HeadingType.N;

            }
            else if (this._rover.Heading == HeadingType.S)
            {
                this._rover.Heading = HeadingType.W;
            }
            else if (this._rover.Heading == HeadingType.E)
            {
                this._rover.Heading = HeadingType.S;
            }
        }
    }
}
