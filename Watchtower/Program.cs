int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());

string enpos = "";

if (x < 0 && y > 0)
{
    enpos = "northwest!";
}

if (x == 0 && y > 0)
{
    enpos = "north!";
}

if (x > 0 && y > 0)
{
    enpos = "northeast!";
}

if (x < 0 && y == 0)
{
    enpos = "west!";
}

if (x > 0 && y == 0)
{
    enpos = "east!";
}

if (x < 0 && y < 0)
{
    enpos = "southwest!";
}

if (x == 0 && y < 0)
{
    enpos = "south!";
}

if (x > 0 && y < 0)
{
    enpos = "southeast!";
}

if (x == 0 && y == 0)
{
    Console.WriteLine("The enemy is here!");
}
else
{
    Console.WriteLine($"The enemy is to the {enpos}");
}
