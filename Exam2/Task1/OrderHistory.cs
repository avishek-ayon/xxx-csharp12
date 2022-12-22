using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1
{
    public class OrderHistory
    {
        /*       (string name, int age)[] persons = new (string name, int age)[]
               {
                           ("jalaluddin", 41),
                           ("tareq", 33),
                           ("hasan", 52),
                           ("rashed", 21),
                           ("monir", 45)
               };*/

        object[] persons = new[]
            {
                new{name = "jalaluddin", age = 41 },
                new { name = "tareq", age = 33 },
                new { name = "hasan", age = 52 },
                new { name = "rashed", age = 21 },
                new { name = "monir", age = 45 }
        
    };


    object[] orders = new[]
    {
                 
                new { name = "monir", amount = 300.5 },
                new { name = "rashed", amount = 20.5 },
                new { name = "tareq", amount = 29.9 },
                new { name = "hasan", amount = 17.7 },
                new{name = "jalaluddin", amount = 30.2 }
        
    };

/*object[] orders = new { name = name, amount = amount, }[]
        {
            ("monir", 300.5),
            ("rashed", 20.5),
            ("tareq", 29.9),
            ("hasan", 17.7),
            ("jalaluddin", 30.2)
        };*/

        public List<(string, double)> GetOrders()
        {
            var result = new List<(string, double)>();

            foreach (dynamic person in persons)
            {
                foreach(dynamic order in orders)
                {
                    if(person.name == order.name)
                    {
                        result.Add((person.name, order.amount));
                    }
                }
            }

            return result;
        }
    }
}
