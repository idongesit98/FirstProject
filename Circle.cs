using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject
{
    public class Circle
    {
        private double radius; //field

        public Circle(double radius) //constructor
        {
            this.radius = radius;
            // you could use this or a backing property
            //_radius
        }

        public double Radius //property
        {
            get{return radius;}
        }

        public double Area // property
        {
            get{return 3.14159 * radius *radius;}
        }
    }
    
// //another way of instantiation
// Circle ball = new Circle(5);
// Console.WriteLine(ball.Radius);
// Console.WriteLine(ball.Area);
}