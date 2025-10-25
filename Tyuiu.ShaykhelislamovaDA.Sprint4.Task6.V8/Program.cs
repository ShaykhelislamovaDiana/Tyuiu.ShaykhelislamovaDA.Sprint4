using Tyuiu.ShaykhelislamovaDA.Sprint4.Task6.V8.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #4 | Выолнила: Шайхелисламова Д. А. | ПКТБ-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #4                                                               *");
        Console.WriteLine("* Класс Array                                                             *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #8                                                              *");
        Console.WriteLine("* Выполнила: Шайхелисламова Диана Артуровна | ПКТБ-25-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Дан строковый массив данных [\"Пицца\", \"Борщ\", \"Пельмени\", \"Омлет\"       *");
        Console.WriteLine("* \"Салат\", \"Суп\", \"Роллы\"], используя класс Array, выведите элементы      *");
        Console.WriteLine("* массива, длина которых больше 4 символов.                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        string[] arr = { "Пицца", "Борщ", "Пельмени", "Омлет", "Салат", "Суп", "Роллы" };
        for(int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + "\t");
        }
        Console.WriteLine();
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        
        for(int i = 0; i < ds.Calculate(arr).Length; i++)
        {
            Console.Write(ds.Calculate(arr)[i] + "\t");
        }
       
    }
}