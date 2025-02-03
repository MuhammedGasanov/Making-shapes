Console.WriteLine("How many rows?");
int rows = int.Parse(Console.ReadLine());

Console.WriteLine("Which symbol?");
string symbol = Console.ReadLine();


for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < rows - i - 1; j++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < 2 * i + 1; j++)
    {
        Console.Write(symbol);
    }

    Console.WriteLine();
}


for (int i = rows - 2  ; i >= 0 ; i--)
{
    for (int j = 0; j < rows - i - 1; j++)
    {
        Console.Write(" ");

    }

    for (int j = 0; j <  2 * i + 1; j++)
    {
        Console.Write(symbol);
    }

    Console.WriteLine();   
}