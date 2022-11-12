// See https://aka.ms/new-console-template for more information
using System.Drawing;
using System.Xml.Linq;
using Task1;

public class Program
{
    public static void Main(String[] args)
    {
        Product product = new Product();
        Product product1 = new Product(name:"dev", price:55, description: "Though he is not so", color: "red");
        Product product2 = new Product( "skill", 55, "Though hgjhdf ");



        Console.WriteLine(product.GetDetails());
       

        Console.WriteLine(product1.GetDetails());
        Console.WriteLine(product2.GetDetails());

    }
}
