//Домашнее задание. Тема 14. Урок 1. Цикл For.
for (int i = 0; i <= 6; i++)
{
    Random rnd1 = new Random();
Random rnd2 = new Random();
    int a = rnd1.Next(6);
    int b = rnd2.Next(1);
    Console.WriteLine(b);
    Console.WriteLine(a);
        
    if (a>6&&b>6)
    {
        Console.WriteLine("Вы выйграли");
    }
    if (a>6 || b <5)
    {
        Console.WriteLine("Вы проиграли");
    }
   
 
}
class EnumDemo
{
    enum Mess { Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь };
    static void Main()
    {
        Console.WriteLine("Введи номер месяца");
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 12)
            Console.WriteLine("Некорректный номер!");
        else
            Console.WriteLine("Месяц под номером {0}: {1}", n, (Mess)(n - 1));
    }
}
