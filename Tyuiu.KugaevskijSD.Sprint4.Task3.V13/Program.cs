using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KugaevskijSD.Sprint4.Task3.V13.Lib;

namespace Tyuiu.KugaevskijSD.Sprint4.Task3.V13;
internal class Program
{
    static void Main(string[] args)
    {
        DataService dataService = new DataService();

        Console.Title = "Спринт #4 | Выполнил: Кугаевский С. Д. | АСОиУб-25-1";
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("- Спринт #4                                                            -");
        Console.WriteLine("- Тема: Двумерные массивы(ввод с клавиатуры)                           -");
        Console.WriteLine("- Задание #4                                                           -");
        Console.WriteLine("- Вариант #13                                                          -");
        Console.WriteLine("- Выполнил Кугаевский Сергей Дмитриевич | АСОиУб-25-1                  -");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("- УСЛОВИЕ:                                                             -");
        Console.WriteLine("- Дан двумерный целочисленный массив 5 на 5 элементов, заполненный     -");
        Console.WriteLine("- значениями с клавиатуры в диапазоне от 1 до 7.                       -");
        Console.WriteLine("- Найдите сумму четных элементов массива.                              -");
        Console.WriteLine("-                                                                      -");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("- ИСХОДНЫЕ ДАННЫЕ:                                                     -");
        Console.WriteLine("- 4, 7, 4, 2, 1,                                                       -");
        Console.WriteLine("- 6, 7, 3, 6, 5,                                                       -");
        Console.WriteLine("- 6, 5, 3, 3, 5,                                                       -");
        Console.WriteLine("- 4, 4, 6, 4, 7,                                                       -");
        Console.WriteLine("- 2, 1, 2, 3, 4,                                                       -");
        Console.WriteLine("-                                                                      -");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.WriteLine("- РЕЗУЛЬТАТ:                                                           -");

        int[,] matrix = {
    {4, 7, 4, 2, 1},
    {6, 7, 3, 6, 5},
    {6, 5, 3, 3, 5},
    {4, 4, 6, 4, 7},
    {2, 1, 2, 3, 4}
};

        int sumOfEvenElements = dataService.Calculate(matrix);

        Console.WriteLine($"Сумма четных элементов: {sumOfEvenElements}");
        Console.WriteLine("------------------------------------------------------------------------");
        Console.ReadLine();
    }
}