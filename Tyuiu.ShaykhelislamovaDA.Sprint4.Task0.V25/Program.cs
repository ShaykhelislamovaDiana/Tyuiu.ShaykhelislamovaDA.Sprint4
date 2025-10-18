using Tyuiu.ShaykhelislamovaDA.Sprint4.Task0.V25.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Одномерные массивы (статический ввод)                                   *");
        Console.WriteLine("* Задание #0                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
        Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных   *");
        Console.WriteLine("* элементов массива.  {1, 4, 2, 6, 4, 8, 6, 7, 8, 4}                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        int[] arr = { 1, 4, 2, 6, 4, 8, 6, 7, 8, 4 };
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]+"\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.GetSumEvenArrEl(arr));
    }
}