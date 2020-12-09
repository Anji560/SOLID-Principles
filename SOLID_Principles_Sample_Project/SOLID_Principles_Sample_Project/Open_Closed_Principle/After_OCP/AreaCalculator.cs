
namespace SOLID_Principles_Sample_Project.Open_Closed_Principle.After_OCP
{
    public class AreaCalculator
    {
        public double TotalArea(Shape[] arrShapes)
        {
            double area = 0;

            foreach (var objShape in arrShapes)
            {
                area += objShape.Area();
            }

            return area;
        }
    }
}
