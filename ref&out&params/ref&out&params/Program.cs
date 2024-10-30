using System.Formats.Tar;

internal class Program
{
    static void Mymethod(int a, ref int b, out int c)
    {
        a = 3; b = 4; c = 5;
    }
    static void Main(string[] args)
    {
        int x = 1; int y = 2; int z;
        Mymethod(x, ref y, out z);
        Console.WriteLine($"x:{x},y:{y},z:{z}");
        Console.ReadLine();
    }
}
