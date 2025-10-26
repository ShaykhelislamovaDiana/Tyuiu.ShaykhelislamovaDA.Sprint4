using Tyuiu.ShaykhelislamovaDA.Sprint4.Task7.V3.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Добавление к решению итоговых проектов по спринту                       *");
        Console.WriteLine("* Задание #7                                                              *");
        Console.WriteLine("* Вариант #3                                                              *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дана строка из одноразрядных цифр \"27182818\". Преобразуйте ее в матрицу *");
        Console.WriteLine("* 4 на 2 и подсчитайте количество нечетных чисел в матрице.               *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        int i = 4;
        int j = 2;
        string str = "27182818";
        int ind = 0;
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Матрица:");
        for (int i2 = 0; i2 < i; i2++)
        {
            for (int j2 = 0; j2 < j; j2++)
            {
                Console.Write(str[ind] + "\t");
                ind++;
            }
            Console.WriteLine();
        }
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.Write("Количество нечетных чисел в матрице: ");
        Console.WriteLine(ds.Calculate(i, j, str));
    }
}