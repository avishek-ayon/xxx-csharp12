int[] array = { 100, 20, 10, 5, 1 };
int n = int.Parse(Console.ReadLine());
int m = 0;
for (int i = 0; i < array.Length; i++)
{
    m += n / array[i];
    n = n % array[i];


}
Console.WriteLine(m);
