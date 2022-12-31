int k = Int32.Parse(Console.ReadLine());
int l = Int32.Parse(Console.ReadLine());
int m = Int32.Parse(Console.ReadLine());
int n = Int32.Parse(Console.ReadLine());
int d = Int32.Parse(Console.ReadLine());
int j = 0;
for (int i = 1; i <= d; i++)
{
    if (i % k == 0 || i % l == 0 || i % m == 0 || i % n == 0)
       j = j + 1; 
}
Console.WriteLine(j);