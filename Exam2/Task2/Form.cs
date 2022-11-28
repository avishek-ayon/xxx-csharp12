using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public partial class Form
    {
        int _value1;
        string _value2;
        double _value3;
       

        public int Value1 { get { return _value1; } set { _value1 = value; } }
        public string Value2 { get { return _value2; } set { _value2 = value; } }
        public double Value3 { get { return _value3; } set { _value3 = value; } }

    }
}
