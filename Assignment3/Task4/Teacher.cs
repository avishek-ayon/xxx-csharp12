using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Teacher : CommonAbstract
    {
        

        public Teacher(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public override void GenerateId()
        {
            Id = "TE-" + DateTime.Now.Ticks.ToString();
        }
    }
}
