using Tyuiu.BarbashinAV.Sprint0.Task7.V0.Lib;
namespace Tyuiu.BarbashinAV.Sprint0.Task7.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #0 | Выполнил: Барбашин А. В. | ИИПб-24-1";
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* Спринт #0                                                            *");
            Console.WriteLine("* Тема: Создание итогового решения по спринту                          *");
            Console.WriteLine("* Задание #7                                                           *");
            Console.WriteLine("* Вариант #0                                                           *");
            Console.WriteLine("* Выполнил: Барбашин Андрей Владиславович | ИИПб-24-1                  *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                             *");
            Console.WriteLine("* Написать консольную программу на C#, которая суммирует значения двух *");
            Console.WriteLine("* одинаковых массивов по длине                                         *");
            Console.WriteLine("*                                                                      *");
            Console.WriteLine("************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                     *");
            Console.WriteLine("************************************************************************");


            var arrayNums1 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №1");
            printArray(arrayNums1);

            var arrayNums2 = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("Значение элементов массива №2");
            printArray(arrayNums2);

            Console.WriteLine("************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                           *");
            Console.WriteLine("************************************************************************");

            if (arrayNums1.Length == arrayNums2.Length)
            {
                var resultArray = DataService.AdditionArrays(arrayNums1, arrayNums2);
                Console.WriteLine("Сумма элементов массива равна:");
                printArray(resultArray);
            }
            else
            {
                Console.WriteLine("Ошибка! Исходные массивы имеют разное количество элементов");
            }
            Console.ReadKey();

            void printArray(int[] array)
            {
                if (array.Length == 0)
                    return;
                for (var i = 0; i < array.Length-1; i++)
                    Console.Write(array[i] + ", ");
                Console.Write(array[array.Length - 1]);
                Console.Write("\n");
            }
        }
    }
}
