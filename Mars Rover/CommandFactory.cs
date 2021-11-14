using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mars_Rover
{
    public class CommandFactory
    {
        public ICommand GetCommand(char commandstr, Rover rover)
        {
            if(commandstr == 'L')
            {
                return new LeftCommand(rover);
            }
            else if(commandstr == 'R')
            {
                return new RightCommand(rover);

            }
            else if(commandstr == 'M')
            {
                return new MCommand(rover);

            }
            return null;
        }

        public IList<ICommand> GetListCommand(string line, Rover rover)
        {
            var list =  new List<ICommand>();

            foreach (var item in line)
            {
                var command = GetCommand(item, rover);
                if(command != null)
                {
                    list.Add(command);
                }
            }

            return list;
        }
    }
}
