// See https://aka.ms/new-console-template for more information
/*----------------------------------------------------------------------------------------------*/

Console.WriteLine("enter matrix no : m * n ");
Console.WriteLine("enter row no : m = ");
int n = int.Parse(Console.ReadLine()); //Row size of the array
Console.WriteLine("enter row no : n = ");
int m = int.Parse(Console.ReadLine());//Column size of the array

if(n<2 || m < 2)
{
    Console.WriteLine("Enter greater then 1 value");
}
else if (n > 1 && m > 1 && n == m)
{
    int[,] arr = new int[n, m];
    string[] lines = new string[n]; // so we could read the input from the user
    Console.WriteLine("enter value ");
    int i = 0, j = 0;



    for (i = 0; i < n; i++) // here we need to read more than one line
    {
        lines[i] = Console.ReadLine();
    }


    for (i = 0; i < n; i++)
    {
        string[] num = lines[i].Split(' ');
        for (j = 0; j < m; j++)
        {
            int z = Convert.ToInt32(num[j]);
            arr[i, j] = z;
        }
    }

    /* 2D Matrix display */
    Console.WriteLine();
    Console.WriteLine("The matrix is :\n");
    for (i = 0; i < n; i++)
    {
        for (j = 0; j < m; j++)
        {
           /* Console.Write(arr[i, j] + " ");*/
            Console.Write("{0} ", arr[i, j]);

        }
        Console.WriteLine();
    }


    //row & column & diagonal
    int leftDiagonal = 0, rightDiagonal = 0, c = 0, r = 0, array_max = int.MinValue; ;

    for (i = 0; i < n; i++)
    {
        c = 0;
        r = 0;
        m = m - 1;
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            c = c + arr[j, i];//column add
            /*        arr[j, i] = c;
            */
            r = r + arr[i, j];//row added
            /*        arr[i, j] = r;
            */

            if (i == j)//left diagonal
            {
                leftDiagonal = leftDiagonal + arr[i, j];
            }
            if (j == m)//right diagonal
            {
                rightDiagonal = rightDiagonal + arr[i, j];
            }


        }
        /*compare row and column to find maximum value of 2D Matrix*/

        if (array_max < c && c > r && c > leftDiagonal & c > rightDiagonal)
        {
            array_max = c;
        }
        else if (array_max < r && r > leftDiagonal & r > rightDiagonal)
        {
            array_max = r;
        }

        /* Row and Column display*/

        Console.WriteLine("row = " + r + " ");
        Console.WriteLine("column = " + c + " ");

    }

    /*compare left diagonal and right diagonal to find maximum value of 2D Matrix*/

    if (array_max < leftDiagonal && leftDiagonal > rightDiagonal)
    {
        array_max = leftDiagonal;
    }
    else if (array_max < rightDiagonal)
    {
        array_max = rightDiagonal;
    }


    Console.WriteLine();
    Console.WriteLine("Left diagonal = " + leftDiagonal + " ");

    Console.WriteLine();

    Console.Write("Right Diagonal :{0}\n", rightDiagonal);

    Console.WriteLine();

    Console.WriteLine("Maximum value  " + array_max);
}


/*--------------------------------- Test Case --------------------------------*/
/*
1 2 3 5 0
2 5 7 1 -4
1 6 2 0 3
3 6 4 8 9
1 1 1 1 -1

5 -1 -4
-5 -2 7
0 3 -3


1 -10 0
-4 -3 -2
-6 4 -7
 
 
 
 */