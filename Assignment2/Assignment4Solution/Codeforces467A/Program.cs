int total = int.Parse(Console.ReadLine());

int input1, input2;
int ans = 0;



for (int i = 0; i < total; i++)
{
    var x = Console.ReadLine().Split(' ');

    input1 = int.Parse(x[0]);
    input2 = int.Parse(x[1]);

    if (input2 - input1 >= 2)
        ans++;
}

Console.WriteLine(ans);
