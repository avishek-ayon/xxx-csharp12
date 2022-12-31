int n = int.Parse(Console.ReadLine());

int b = 0, position = 0;

for (int i = 0; i < n; i++)
{
    int a = int.Parse(Console.ReadLine());

    if (b != a)
        position++;

    b = a;
}

Console.WriteLine(position);

Console.ReadLine();