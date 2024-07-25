class EnumDemo
{
    enum mesyac { Январь, Февраль, Март, Апрель, Май, Июнь, Июль, Август, Сентябрь, Октябрь, Ноябрь, Декабрь };
    static void Main()
    {
        Console.WriteLine("Введи номер месяца");
        int nomer = int.Parse(Console.ReadLine());
        if (nomer == 1)
            Console.Write("Месяц под номером " + nomer + " : Январь");
        if (nomer == 2)
            Console.Write("Месяц под номером " + nomer + " : Февраль");
        if (nomer == 3)
            Console.Write("Месяц под номером " + nomer + " : Март");
        if (nomer == 4)
            Console.Write("Месяц под номером " + nomer + " : Апрель");
        if (nomer == 5)
            Console.Write("Месяц под номером " + nomer + " : Май");
        if (nomer == 6)
            Console.Write("Месяц под номером " + nomer + " : Июнь");
        if (nomer == 7)
            Console.Write("Месяц под номером " + nomer + " : Июль");
        if (nomer == 8)
            Console.Write("Месяц под номером " + nomer + " : Август");
        if (nomer == 9)
            Console.Write("Месяц под номером " + nomer + " :  Сентябрь");
        if (nomer == 10)
            Console.Write("Месяц под номером " + nomer + " : Октябрь");
        if (nomer == 11)
            Console.Write("Месяц под номером " + nomer + " : Ноябрь");
        if (nomer == 12)
            Console.Write("Месяц под номером " + nomer + " : Декабрь");
    }
}
