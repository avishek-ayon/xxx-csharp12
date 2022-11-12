using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public abstract class CommonAbstract
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Id { get;  set; }
        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        public abstract void GenerateId();
    }
}
