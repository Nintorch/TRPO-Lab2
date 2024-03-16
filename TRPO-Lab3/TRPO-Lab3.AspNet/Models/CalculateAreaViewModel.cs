using TRPO_Lab3.Lib;

namespace TRPO_Lab3.AspNet.Models
{
    public class CalculateAreaViewModel
    {

        public double Radius { get; set; }

        public double Height { get; set; }

        public double Area
        {
            get => CalculateArea.CalculateConeArea(Radius, Height);
        }

        public CalculateAreaViewModel(double radius, double height)
        {
            Radius = radius;
            Height = height;
        }
    }
}
