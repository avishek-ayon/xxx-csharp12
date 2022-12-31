string[] str = Console.ReadLine().Split();
long x = long.Parse(str[0]);
long y = long.Parse(str[1]);
long z = long.Parse(str[2]);
Console.WriteLine(((x + z - 1) / z) * ((y + z - 1) / z));