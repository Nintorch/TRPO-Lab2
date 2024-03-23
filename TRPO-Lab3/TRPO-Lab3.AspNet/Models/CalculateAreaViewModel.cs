namespace TRPO_Lab3.AspNet.Models
{
    public class CalculateAreaViewModel
    {

        public double Radius { get; set; }

        public double Height { get; set; }

        public string AreaString { get; set; }

        public CalculateAreaViewModel(double radius, double height, double area)
        {
            Radius = radius;
            Height = height;
            AreaString = area.ToString();
        }
    }
}
