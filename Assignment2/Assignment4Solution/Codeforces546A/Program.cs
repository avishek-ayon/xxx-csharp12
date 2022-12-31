string[] s = Console.ReadLine().Split(' ');
int input1 = int.Parse(s[0]);
int input2 = int.Parse(s[1]);
int input3 = int.Parse(s[2]);
int amount = 0;
for (int i = 1; i <= input3; i++)
{
    amount += i * input1;
}
int result = amount - input2;
if (result < 0)
    Console.WriteLine(0);
else
    Console.WriteLine(result);