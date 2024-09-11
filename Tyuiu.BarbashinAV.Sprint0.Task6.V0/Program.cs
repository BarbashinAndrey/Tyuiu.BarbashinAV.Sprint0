using Tyuiu.BarbashinAV.Sprint0.Task6.V0.Lib;
namespace Tyuiu.BarbashinAV.Sprint0.Task6.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arraynums = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Сумма элементов массива = " + DataService.AdditionArray(arraynums));
            Console.WriteLine("Разность элементов массива = " + DataService.SubtractionArray(arraynums));
            Console.WriteLine("Произведение элементов массива = " + DataService.MultiplicationArray(arraynums));
            Console.ReadKey();
        }
    }
}
