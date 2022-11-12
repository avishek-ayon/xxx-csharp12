using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class Product
    {
        private int v1;
        private string v2;
        private string v3;

        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }

        /*Contructors create*/

        /* Constructor with different parameter*/
        public Product(string name, double price, string description, string color):this(name,price, description)
        {
        
            this.Color = color;

        }

        /*Constructor with different parameter*/

        public Product(string name, double price, string description) :this()
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            /*Console.WriteLine(this.Name);*/

        }


       


        /*empty Constructor*/
        public Product()
        {
            
        }



        public string GetDetails()
        {
            string details = Name + " " + Price + " " + Description + " " + Color;
            return details.ToString();
        }


    }
}
