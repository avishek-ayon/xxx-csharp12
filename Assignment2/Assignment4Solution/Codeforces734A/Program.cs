int count = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
int d = 0, a = 0;
for (int i = 0; i < count; i++)
{
    if (input[i] == 'D')
    {
        d++;
    }
    else
    {
        a++;
    }
}
if (d > a)
{
    Console.WriteLine("Danik");
}
else if (d < a)
{
    Console.WriteLine("Anton");
}
else
{
    Console.WriteLine("Friendship");
}