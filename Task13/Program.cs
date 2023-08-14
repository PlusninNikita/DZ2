// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int leadIn(string mes)
{
    System.Console.Write(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

int GetSecNum(int num)
{
    while (num > 999)
    {
        num /= 10;
    }
    return num % 10;
}

bool ValNum(int num)
{
    if (num < 100)
    {
        Console.WriteLine("Третьей цифры нет!");
        return false;
    }
    return true;
}

int num = leadIn("Введите число:");
if (ValNum(num))
{
    Console.WriteLine(GetSecNum(num));
}