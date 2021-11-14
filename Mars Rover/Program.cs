using Mars_Rover;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***********Test Input*************");

        Console.Write("Max:");
        string Max=   Console.ReadLine();
        Planet.init(Max);

        Console.Write("Start Location:");
        string location = Console.ReadLine();
        Rover rover = new Rover(location);


        Console.Write("Command Line:");
        string line = Console.ReadLine();
        CommandFactory commandFactory = new CommandFactory();
        var listcommand =  commandFactory.GetListCommand(line, rover);

        foreach (var command in listcommand)
        {
            command.Execute();
        }


        Console.WriteLine("Expected Output:");
        Console.WriteLine(rover.GetLocation());

        Console.ReadLine();
    }
}



