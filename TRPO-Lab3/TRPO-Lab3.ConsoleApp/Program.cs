using TRPO_Lab3.Lib;

namespace TRPO_Lab3.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Расчёт площади поверхности круглого конуса");

            Console.WriteLine("Введите радиус конуса:");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите высоту конуса:");
            double height = Convert.ToDouble(Console.ReadLine());

            try
            {
                Console.WriteLine("Результат: " + CalculateArea.CalculateConeArea(radius, height));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
