string x = Console.ReadLine();
string[] arr = x.Split(' ');
int[] ints = Array.ConvertAll(arr, s => int.Parse(s));

Array.Sort(ints);

int c = ints[3] - ints[0];
int b = ints[1] - c;
int a = ints[2] - c;


Console.WriteLine(a + " " + b + " " + c);





