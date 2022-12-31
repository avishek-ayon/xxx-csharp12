int x = 0;
int y = 0;
string n = Console.ReadLine();
foreach (var item in n)
{
    if (item.ToString() == item.ToString().ToLower())
    {
        x++;
    }
    else
    {
        y++;
    }
}


if (x >= y)
    Console.WriteLine(n.ToLower());
else
    Console.WriteLine(n.ToUpper());
