namespace TRPO_Lab3.Lib
{
    public class CalculateArea
    {
        // 14.	Площадь поверхности круглого конуса

        public static double CalculateConeArea(double radius, double height)
        {
            if (radius < 0 || height < 0)
            {
                throw new ArgumentException("Radius or height is negative");
            }

            double l = Math.Sqrt(radius*radius + height*height);
            return Math.PI * radius * (l + radius);
        }
    }
}
