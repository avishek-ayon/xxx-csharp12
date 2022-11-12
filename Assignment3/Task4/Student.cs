using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Student : CommonAbstract
    {
       

        public Student(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }


        public override void GenerateId()
        {
            Id = "ST-" + DateTime.Now.Ticks.ToString();
        }


        



    }
}
