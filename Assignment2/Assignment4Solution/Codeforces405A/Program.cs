int n = int.Parse(Console.ReadLine());
string[] inputs = Console.ReadLine().Split(' ');

int[] numbers = Array.ConvertAll(inputs, int.Parse);
Array.Sort(numbers);
foreach (int number in numbers)
{
    Console.Write(number + " ");
}
Console.WriteLine();
