using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Admin:CommonAbstract
    {


        public Admin(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }

        public override void GenerateId()
        {
            Id = "AD-" + Guid.NewGuid().ToString();
        }
    }
}
