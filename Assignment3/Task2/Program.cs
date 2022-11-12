// See https://aka.ms/new-console-template for more informationz
using Task2;

public class Program
{
    public static void Main(String[] args)
    {
        Lock locks = new Lock();//object create
        locks.LockStatus = "OPen";//value sets
        Console.WriteLine(locks.LockStatus);

    }
}
