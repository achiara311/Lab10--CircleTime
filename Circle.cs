using System;
using System.Collections.Generic;
using System.Text;

namespace CircleTime
{
    public class Circle
    {
        #region fields
        private double radius;


        #endregion

        #region properties
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

        #endregion

        #region Constructors

        public Circle()
        {

        }

        public Circle(double _radius, double _formatString)
        {
            radius = _radius;
        }
        #endregion

        public double FormatCalculateArea()
        {
            return Math.Round(CalculateArea(), 2);
        }

        public double FormatCalculateCircumference()
        {
            return Math.Round(CalculateCircumference(), 2);
        }
        public double CalculateArea()
        {   
            return Math.PI * (radius * radius); 
        }

        public double CalculateCircumference()
        {
            
            return (2d * radius) * Math.PI;
        }
        public void PrintInfo()
        {
            Console.WriteLine("The area of the circle is " + FormatCalculateArea());
            Console.WriteLine("\nThe Circumference of is " + FormatCalculateCircumference());
        }


    }

}


