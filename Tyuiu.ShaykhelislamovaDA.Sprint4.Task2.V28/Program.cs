using Tyuiu.ShaykhelislamovaDA.Sprint4.Task2.V28.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Random rnd = new Random();

        Console.Title = "Спринт #4 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Одномерные массивы (генератор случайных чисел)                          *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #28                                                             *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
        Console.WriteLine("* случайными в диапазоне от 2 до 9 подсчитать сумму нечетных элементов    *");
        Console.WriteLine("* массива.                                                                *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] arr = new int[12];
        for (int i = 0; i <12; i++)
        {
            arr[i] = rnd.Next(2, 10);
        }

        for(int i = 0; i < 12; i++)
        {
            Console.Write(arr[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(arr));
    }
}