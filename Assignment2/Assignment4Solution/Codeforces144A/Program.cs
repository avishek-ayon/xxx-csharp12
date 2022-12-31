int n = int.Parse(Console.ReadLine());
string[] ss = Console.ReadLine().Split(' ');
int max = int.Parse(ss[0]);
int min = int.Parse(ss[0]);
int maxIndex = 0;
int minIndex = 0;
int count = 0;
for (int i = 0; i < n; i++)
{
    if (max < int.Parse(ss[i]))
    {
        max = int.Parse(ss[i]);
        maxIndex = i;
    }
    else if (min >= int.Parse(ss[i]))
    {
        min = int.Parse(ss[i]);
        minIndex = i;
    }

}

if (maxIndex < minIndex)
{
    count = maxIndex + n - 1 - minIndex;
}
else if (minIndex < maxIndex)
{
    count = maxIndex + n - 2 - minIndex;
}
Console.WriteLine(count);