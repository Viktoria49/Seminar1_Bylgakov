// 7. Напишите программу, которая принимает на вход
// трёхзначное число и на выходе показывает последнюю цифру
// этого числа.
// 456 -> 6
// 782 -> 2
// 918 -> 8

Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine());
if (num >= 100 && num < 1000)
{
    Console.WriteLine($"Последняя цифра числа {num} = {num % 10} ");
}
else
 Console.WriteLine("Вы ввели не трехзначное число");

