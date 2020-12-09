using System;

namespace SOLID_Principles_Sample_Project.Open_Closed_Principle.After_OCP
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area()
        {
            return Radius * Radius * Math.PI;
        }
    }
}
