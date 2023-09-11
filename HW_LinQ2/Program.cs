var player = new List<Player>()
{
    new("Mike", 10, 50),
    new("John", 20, 10),
    new("Alex", 30, 150),
    new("Todd", 40, 200),
    new("Ethan", 50, 250),
    new("Michael", 60, 300),
    new("Noah", 70, 350),
    new("Tobias", 80, 400),
    new("Mark", 90, 450),
    new("Fred", 100, 500)
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
    Console.ForegroundColor = ConsoleColor.Yellow;
    foreach (var p in findTopLevel!)
    {
        Console.WriteLine($"Player name: {p.Name} - his level is {p.Level}.");
    }

    Console.ResetColor();
}

void PrintByPower()
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    foreach (var p in findTopPower!)
    {
        Console.Write($"Player name: {p.Name} - has {p.Power} power.");
        Console.WriteLine();
    }

    Console.ResetColor();
}

record class Player(string Name, int Level, int Power);