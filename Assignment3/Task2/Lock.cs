using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Lock
    {
        public string lockStatus;

        // Correct lock status are: Open & Close
        public string LockStatus { 
            get { return lockStatus; }
            set { lockStatus = value; }
            
             } 
    }
}
