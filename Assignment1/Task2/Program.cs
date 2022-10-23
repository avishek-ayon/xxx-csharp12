// See https://aka.ms/new-console-template for more information
/*--------------------------Task 2 -------------------------------------------------*/

Console.WriteLine("Finding 3rd Largest number");
Console.WriteLine("-------------------- &&&&&&&&&&&&&& ------------------------");

int first = Int32.MinValue, second = Int32.MinValue, third = Int32.MinValue;
Console.WriteLine("How many test case ");
int counter = int.Parse(Console.ReadLine());
if (counter < 3)
{
    Console.WriteLine("Give 3 value at least");
}

else if (counter >= 3)
{
    Console.WriteLine("Give input : ");

    for (int i = 0; i < counter; i++)
    {
        int testNumber = int.Parse(Console.ReadLine());

        /* for finding Largest Number */

        if (testNumber > first)
        {
            third = second;
            second = first;
            first = testNumber;

        }

        /* for finding 2nd largest Number */

        else if (testNumber > second && testNumber <= first)
        {
            third = second;
            second = testNumber;
        }

        /* for finding 3rd Number */

        else if (testNumber <= second && testNumber > third)
        {
            third = testNumber;
        }


    }
    Console.WriteLine("3rd largest NUmber : ");

    Console.WriteLine(third);
}

