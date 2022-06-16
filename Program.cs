/*  10. Принимает трехзначное число и показывает вторую цифру числа
    15. Принимает цифру, обозначающ. деньнедели, проверяет являетя ли
    это выходной или нет */

/* Console.WriteLine("Введите число");
int c = int.Parse(Console.ReadLine());
if (c > 99 && c < 1000)
{
    c = c / 10;
    Console.WriteLine(c%10);
}
else
{
    Console.WriteLine("Число не трехзначное");
}
 */


Console.WriteLine("Введите число");
int c = int.Parse(Console.ReadLine());
if (c == 6 || c == 7)
{
    Console.WriteLine("Выходной");
}
else if (c >= 1 && c <= 5)
{
    Console.WriteLine("Рабочий");
}
else if (c <=0 || c >= 8)
{
    Console.WriteLine("Введите заново");
}