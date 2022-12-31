int n = int.Parse(Console.ReadLine());
var input = Console.ReadLine();

int count = 0;
for (int i = 1; i < n; i++)
{
    if (input[i - 1] == input[i])
        count++;
}

Console.WriteLine(count);
