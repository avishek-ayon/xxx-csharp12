string[] a = Console.ReadLine().Split(' ');
string[] n = Console.ReadLine().Split(' ');
int x = Convert.ToInt32(n[0]);
int y = Convert.ToInt32(n[1]);
int year = 0;
for (int i = 0; x <= y; i++)
{
    x = x * 3;
    y = y * 2;
    if (x > y)
        year = i + 1;
}
Console.WriteLine(year);