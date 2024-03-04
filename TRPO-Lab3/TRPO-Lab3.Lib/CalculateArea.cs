namespace TRPO_Lab3.Lib
{
    public class CalculateArea
    {
        // 14.	Площадь поверхности круглого конуса

        public static double CalculateConeArea(double radius, double height)
        {
            double l = Math.Sqrt(radius*radius + height*height);
            return Math.PI * radius * (l + radius);
        }
    }
}
