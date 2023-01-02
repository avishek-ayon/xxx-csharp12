using  Task3;

Stack<int> numbers = new Stack<int>();

var result = numbers.GetSum();
foreach(var number in numbers)
{
    Console.WriteLine(number);
}

