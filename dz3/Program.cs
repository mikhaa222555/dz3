double perss, dwas, result;
char sints;
Console.WriteLine("Введите числа, а так же выберете действие(+,-,*,/)");
Console.Write("Введите первое число = ");
perss = Convert.ToSingle(Console.ReadLine());
Console.Write("Введите знак действия = ");
sints = Convert.ToChar(Console.ReadLine());
Console.Write("Введите Второе число = ");
dwas = Convert.ToSingle(Console.ReadLine());
if (sints == '+')
{
    result = perss + dwas;
    Console.WriteLine("Ответ при сложении равен = " + result);
}
else if (sints == '-')
{
    result = perss - dwas;
    Console.WriteLine("Ответ при вычетании равен =  " + result);
}
else if (sints == '*')
{
    result = perss * dwas;
    Console.WriteLine("Ответ при умножении равен =  " + result);
}
else if (sints == '/')
{
    result = perss / dwas;
    Console.WriteLine("Ответ при делении равен = " + result);
}
else
{
    Console.WriteLine("Ошибка.Неверный знак.");
}