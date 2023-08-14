// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int leadIn(string mes)
{
    System.Console.Write(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int num = leadIn("Введите трехзначное число: ");
if (num < 100 || num >= 1000)
{
    Console.WriteLine("Вы ввели не трехзначное число, пожайлуста повторите ввод");
    return;
}

Console.WriteLine($"Введенное число {num}");
int secNum = num / 10 % 10;
Console.WriteLine($"Вторая цифра: {secNum}");