// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int chNumber = number / 100; // делим введеное число на 100, чтобы проверить трехзначность
if (chNumber == 0 || chNumber > 9) Console.WriteLine($"Число {number} - не трехзначное");
else 
{
int secAndThdDigit = number / 10;  // получаем с деления 1 и 2 цифру
int secDigit = secAndThdDigit % 10;  // получаем с остатка 2 цифру
Console.WriteLine($"{number} -> {secDigit}");
}