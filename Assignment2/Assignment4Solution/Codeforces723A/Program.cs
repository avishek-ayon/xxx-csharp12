string[] n = Console.ReadLine().Split(" ");
int input1 = int.Parse(n[0]);
int input2 = int.Parse(n[1]);
int input3 = int.Parse(n[2]);

int[] intArray = new int[3];
intArray[0] = input1;
intArray[1] = input2;
intArray[2] = input3;

Array.Sort(intArray);
int result = intArray[2] - intArray[0];
Console.WriteLine(result);

