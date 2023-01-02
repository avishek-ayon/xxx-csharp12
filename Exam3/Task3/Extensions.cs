using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public static class Extensions
    {
        public static Stack<int> GetSum(this Stack<int> stack)
        {
            Stack<int> result = new Stack<int>();
            int sum = 0;
            foreach(var item in stack)
            {
                sum += item;
                result.Push(item);
            }
        }
    }
}
