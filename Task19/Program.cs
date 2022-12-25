// 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет 12821 -> да 23432 -> да
Console.Clear();

int getUserValue(string message)
{
    Console.WriteLine(message);
    int result = int.Parse(Console.ReadLine()!);
    return result;
}
int number = getUserValue("Введите пятизначное число: ");

if (number < 10000 || number > 99999)
{
    Console.WriteLine("Ошибка! Введите пятизначное число!");
}
else
{
    int digit5 = number % 10;
    int digit4 = number / 10;
    int digit2 = number / 1000;
    int digit1 = number / 10000;
    if (digit1 == digit5 || digit2 == digit4)
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else
    {
        Console.WriteLine($"Ваше число: {number} - не палиндром.");
    }
}
