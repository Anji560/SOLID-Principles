
namespace SOLID_Principles_Sample_Project.Open_Closed_Principle.After_OCP
{
    public class Rectangle : Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public override double Area()
        {
            return Height * Width;
        }
    }
}
