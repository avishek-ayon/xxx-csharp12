string n = Console.ReadLine();
string m = Console.ReadLine();
int i;


for (i = 0; i < n.Length; i++)
{
    Console.Write(n[i] ^ m[i]);
}