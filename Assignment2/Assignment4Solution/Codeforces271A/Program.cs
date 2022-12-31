int n = int.Parse(Console.ReadLine());
int a = 0;
if (n >= 1000 && n <= 9000)
{
    for (int i = n + 1; i < 9999; i++)
    {
        string s = Convert.ToString(i);
        for (int j = 0; j < s.Length; j++)
        {
            for (int k = 0; k < s.Length; k++)

                if (s[j] == s[k])
                    a++;

        }
        if (a == 4)
        {
            Console.WriteLine(s);
            break;

        }
        a = 0;
    }
}