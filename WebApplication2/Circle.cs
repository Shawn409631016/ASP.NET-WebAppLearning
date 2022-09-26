using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Circle
    {
        private double radius;
        public double Radius
        {
            get
            {
                return radius;
            }
            set
            {
                radius = value;
            }
        }

        public double Area()
        {
            return Math.PI * radius * radius;
        }

        public double Circumferece()
        {
            return Math.PI * 2 * radius;
        }
    }
}