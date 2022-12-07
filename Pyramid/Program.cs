// See https://aka.ms/new-console-template for more information

WriteLine("Hell'3, w0rld!");

static string ToBinaryString(int value)
{
    return Convert.ToString(value, toBase: 2).PadLeft(8, '0');
}

// Définition d'une fonction
void MainProgram()
{
    int a = 11;
    int b = 6;

    WriteLine($"a = {a}");
    WriteLine($"b = {b}");
    WriteLine($"bin(a): {ToBinaryString(a)}");
    WriteLine($"bin(b): {ToBinaryString(b)}");
    WriteLine($"a & b = {a & b}"); // 2-bit column only e.g. 00000010
    WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns e.g. 00001110
    WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns e.g. 00001100
}

WriteLine("The main program...");
MainProgram();
WriteLine("Done!");
