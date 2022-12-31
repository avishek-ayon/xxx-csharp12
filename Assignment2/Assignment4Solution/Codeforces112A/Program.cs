string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
int comparison = String.Compare(s1, s2, comparisonType: StringComparison.OrdinalIgnoreCase);

if (comparison < 0)
{
    Console.WriteLine(-1);
}
            
else if (comparison > 0)
{
    Console.WriteLine(1);
}
           
else
{
    Console.WriteLine(0);
}
           
