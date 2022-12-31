int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    var word = Console.ReadLine();
    if (word.Length > 10)
    {
        Console.Write(word.First());
        Console.Write(word.Length - 2);
        Console.WriteLine(word.Last());
    }
    else
    {
        Console.WriteLine(word);
    }
}                     