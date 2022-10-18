Console.Clear();
Console.WriteLine("Введите номер задачи: 10, 13, или 15");
int z = Convert.ToInt32(Console.ReadLine());

// Задача 10 - Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
int GiveSecondDigit(int number)
{
    number = number / 10;
    int secondDigit = number % 10;

    return secondDigit;
}

bool CheckNumber(int number)
{
    number = number / 100;
    return number > 0 & number < 10;
}

if (z == 10)
{
    Console.WriteLine("Введите трёхзначное число");
    int threeDigitNumber = Convert.ToInt32(Console.ReadLine());

    bool result10 = CheckNumber(threeDigitNumber);
    int secondDigit = GiveSecondDigit(threeDigitNumber);

    if (result10)
    {
        Console.WriteLine($"Вторая цифра этого числа - {secondDigit}");
    }
    else
    {
        Console.WriteLine("Ошибка");
    }
}

// Задача 13 - Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
int GiveThirdDigit(int number)
{
    number = number / 100;
    int thirdDigit = number % 10;

    return thirdDigit;
}

bool CheckThirdDigit(int number)
{
    number = number / 100;
    return number > 0;
}

if (z == 13)
{
    Console.WriteLine("Введите число");
    int num = Convert.ToInt32(Console.ReadLine());

    bool result13 = CheckThirdDigit(num);
    int thirdDigit = GiveThirdDigit(num);

    if (result13)
    {
        Console.WriteLine($"Третья цифра этого числа - {thirdDigit}");
    }
    else
    {
        Console.WriteLine("Третьей цифры нет");
    }
}

// Задача 15 - Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
bool CheckWeekend(int number)
{
    return number == 6 | number == 7;
}

bool CheckWeekDay(int number)
{
    return number > 0 & number < 8;
}

if (z == 15)
{
    Console.WriteLine("Введите число от 1 до 7");
    int dayWeek = Convert.ToInt32(Console.ReadLine());

    bool result15 = CheckWeekend(dayWeek);
    bool check = CheckWeekDay(dayWeek);

    if (check)
    {
        if (result15)
        {
            Console.WriteLine("Выходной");
        }
        else
        {
            Console.WriteLine("Не выходной");
        }
    }
    else
    {
        Console.WriteLine("Ошибка - это не день недели");
    }
}