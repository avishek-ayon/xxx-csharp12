using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Machine<T> where T : class, new()
    {
       /* public delegate void Starter(params T[] args);*/


        public event Action<T> OnStart;

        public void Start(Action<T> Starter)
/*        public void Start(params T[] args)*/
        {
            OnStart.Invoke("hhh");
        }
    }
}
