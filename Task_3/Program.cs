﻿// 3. Напишите программу, которая будет выдавать
// название дня недели по заданному номеру.
// 3 -> Среда
// 5 -> Пятница

Console.Write("Введите число от 1 до 7: ");
int a = int.Parse(Console.ReadLine());
if (a == 1) Console.WriteLine("Сегодня понедельник");
else if (a == 2)
{
    Console.WriteLine("Сегодня вторник");
}
else if (a == 3) 
{
    Console.WriteLine("Сегодня среда");
}
else if (a == 4)
{
    Console.WriteLine("Сегодня четверг");
}
else if (a == 5) 
{
    Console.WriteLine("Сегодня пятница");
}
else if (a == 6)
{
    Console.WriteLine("Сегодня ссуббота");
} 
else if (a == 7)
{
    Console.WriteLine("Сегодня воскресенье");
}
else Console.WriteLine("Некорректный ввод");