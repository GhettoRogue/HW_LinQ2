var player = new List<Player>()
{
    new Player("Mike", 10, 50),
    new Player("John", 20, 10),
    new Player("Alex", 30, 150),
    new Player("Todd", 40, 200),
    new Player("Ethan", 50, 250),
    new Player("Michael", 60, 300),
    new Player("Noah", 70, 350),
    new Player("Tobias", 80, 400),
    new Player("Mark", 90, 450),
    new Player("Fred", 100, 500)
};

var findTopLevel = (
    from p in player
    orderby p.Level descending
    select p
).Take(3);

var findTopPower = (
    from p in player
    orderby p.Power descending
    select p
).Take(3);

PrintByPower();
PrintByLevel();

return;

void PrintByLevel()
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Yellow;
    foreach (var p in findTopLevel!)
    {
        Console.WriteLine($"Player name: {p.Name} - his level is {p.Level}.");
    }
    Console.ResetColor();
    Console.WriteLine();
}

void PrintByPower()
{
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Cyan;
    foreach (var p in findTopPower!)
    {
        Console.Write($"Player name: {p.Name} - has {p.Power} power.");
        Console.WriteLine();
    }

    Console.ResetColor();
    Console.WriteLine();
}

record class Player(string Name, int Level, int Power);