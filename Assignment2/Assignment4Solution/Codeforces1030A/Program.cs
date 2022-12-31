int n = int.Parse(Console.ReadLine());
if (n >= 1 && n <= 100)
{
    string s = Console.ReadLine();
    if (s.Contains("1"))
    {
        Console.WriteLine("HARD");
    }
    else
    {
        Console.WriteLine("EASY");
    }
}
