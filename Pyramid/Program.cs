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
    if(stepX < x)
    {
        if (stepY == 0 || stepY == (y) || stepX == 0 || stepX == (x - 1))
        {
            Console.Write("o");
        }
        else
        {
            Console.Write("-");         
        }

        DoStep(x, y, stepX + 1, stepY);   
    }
    else if (stepX == x && stepY < y)
    {
        Console.Write("\r\n");
        DoStep(x, y, 0, stepY + 1);
    }
    else {
        Console.WriteLine("\r\nDone!");
    }    
}