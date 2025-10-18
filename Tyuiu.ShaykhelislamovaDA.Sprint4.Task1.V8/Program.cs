using Tyuiu.ShaykhelislamovaDA.Sprint4.Task1.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Одномерные массивы (ввод с клавиатуры)                                  *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан одномерный целочисленный массив на 12 элементов заполненный         *");
        Console.WriteLine("* значениями с клавиатуры в диапазоне от 2 до 9 подсчитать сумму нечетных *");
        Console.WriteLine("* элементов массива  С клавиатуры: 8, 4, 7, 7, 3, 8, 8, 5, 8, 7, 2, 4     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int[] array = new int[12];
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine($"Введите значение {i+1} элемента массива:");
            
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine(ds.Calculate(array));
    }
}