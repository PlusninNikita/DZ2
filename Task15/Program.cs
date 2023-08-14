// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

int leadIn(string mes)
{
    System.Console.Write(mes);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

bool numWeek(int wDay)
{
    if (wDay > 5)
    {
        return true;
    }
    return false;
}

bool VDayWeek(int wDay)
{
    if (wDay > 0 && wDay <= 7)
    {
        return true;
    }
    Console.WriteLine("Это не день недели!");
    return false;
}

int wDay = leadIn("Введите день недели: ");
if (VDayWeek(wDay))
{
    if (numWeek(wDay))
    {
        Console.WriteLine($"День {wDay} - является выходным!");
    }
    else
    {
        Console.WriteLine($"День {wDay} - является рабочим днем!");
    }
}