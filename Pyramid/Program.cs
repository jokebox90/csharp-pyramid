// See https://aka.ms/new-console-template for more information

Main(args);

static void Main(string[] args)
{
    Console.WriteLine($"Hell'O, w0rld!");
    Console.WriteLine($"Ma carte postale de pyramide.");
    Console.WriteLine();
    Console.WriteLine($"Colonnes : {args[0]}");
    Console.WriteLine($"Lignes   : {args[1]}");
    Console.WriteLine();

    try
    {
        int x = Int32.Parse(args[0]);
        int y = Int32.Parse(args[1]);

        DoStep(x, y);
    }
    catch (FormatException)
    {
        Console.WriteLine($"Unable to parse '{args}'");
    }
}

static void DoStep(int x, int y, int stepX = 0, int stepY = 0)
{
    if (stepX < x)
    {
        DoColumn(x, y, stepX, stepY);
    }
    else if (stepX == x && stepY < y)
    {
        DoLine(x, y, stepX, stepY);
    }
    else
    {
        DoStop();
    }
}

static void DoColumn(int x, int y, int stepX = 0, int stepY = 0)
{
    if (stepY > 2 && stepY < y && (stepX == (x / 2) + (stepY - 1) * 2) || (stepX == (x / 2) - (stepY - 1) * 2))
    {
        Console.Write("+");
    }
    else if (stepY == 0 || stepY == (y) || stepX == 0 || stepX == (x - 1))
    {
        Console.Write("o");
    }
    else
    {
        Console.Write("-");
    }

    DoStep(x, y, stepX + 1, stepY);
}

static void DoLine(int x, int y, int stepX = 0, int stepY = 0)
{
    Console.Write("\r\n");
    DoStep(x, y, 0, stepY + 1);
}

static void DoStop()
{
    Console.WriteLine("\r\nDone!");
}