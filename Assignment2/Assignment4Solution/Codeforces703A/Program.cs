int n = int.Parse(Console.ReadLine());
int mishka=0, chris=0;

for(int i = 0; i <n; i++)

{
    string[] m = Console.ReadLine().Split(" ");
    int input1 = int.Parse(m[0]);
    int input2 = int.Parse(m[1]);

    if(input1>input2)
    {
        mishka++;

    }
    else if(input1<input2)
    {
        chris++;
    }
}

if(mishka>chris)
{
    Console.WriteLine("Mishka");
}
else if (mishka < chris)
{
    Console.WriteLine("Chris");
}
else
{
    Console.WriteLine("Friendship is magic!^^");
}
