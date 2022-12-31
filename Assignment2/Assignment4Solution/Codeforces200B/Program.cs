int n = int.Parse(Console.ReadLine());
string[] numbers = Console.ReadLine().Split(' ');
double sum = 0;
for (int i = 0; i < n; i++)
{
    sum = sum + double.Parse(numbers[i]);
}
double r = sum / n;
Console.WriteLine(r);