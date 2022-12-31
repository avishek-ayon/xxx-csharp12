var input = Console.ReadLine();
int count = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == '4' || input[i] == '7')
        count=count + 1;
}
if (count == 4 || count == 7)
    Console.WriteLine("YES");
else Console.WriteLine("NO");
