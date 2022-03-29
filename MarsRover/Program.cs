// See https://aka.ms/new-console-template for more information
using MarsRover;
using MarsRover.Command;
using MarsRover.Model;
using MarsRover.Types;

string input =
@"5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM";


var list = input.Split("\r\n").ToList();

var plateauXY = list[0].Split(' ').Select(x => Convert.ToInt32(x)).ToList();

Plateau plateau = new(plateauXY[0], plateauXY[1]);
for (int i = 1; i < list.Count; i += 2)
{
    var roverXYD = list[i].Split(" ").ToList();
    Rover rover = new(Convert.ToInt32(roverXYD[0]), Convert.ToInt32(roverXYD[1]), Helper.GetCharToEnum<DirectionType>(roverXYD[2]), plateau);

    var commandList = list[i + 1].ToList();

    foreach (var commandChar in commandList)
    {
        ICommand command = Invoker.GetCommand(Helper.GetCharToEnum<CommandType>(commandChar.ToString()));
        command.Execute(rover);
    }
    Console.WriteLine(rover.ToString());
}
Console.ReadLine();
