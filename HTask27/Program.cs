// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int result = SumDigits(number); // вызываем метод суммирования цифр в числе
Console.WriteLine($"Сумма цифр в числе {number} = {result}");


//====================================================
// Метод суммирования цифр в числе
int SumDigits (int num)
{
    int digit1 = default;
    int digit2 = default;
    int sumDigits = default;
    while (num > 0)
    {
        digit1 = num % 10;
        num = num / 10;
        digit2 = num % 10;
        sumDigits = sumDigits + digit1 + digit2;
        num = num / 10;
    }
    return sumDigits;
}
