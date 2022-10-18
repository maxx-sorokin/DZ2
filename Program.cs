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
