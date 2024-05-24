using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Temperature
    {
        private double celsius;

        public double Celsius
        {
            get{return celsius;}
            set{celsius = value;}
        }

        public double Fahrenheit
        {
            get{return celsius * 9/5 + 32;}
            set {celsius = (value - 32) * 5/9;}
        }
    }
}


// Temperature temp = new();
// temp.Celsius = 31;
// Console.WriteLine(temp.Fahrenheit);
// temp.Fahrenheit = 89;
// Console.WriteLine(temp.Celsius);