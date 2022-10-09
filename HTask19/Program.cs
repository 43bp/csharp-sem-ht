// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
bool cheakQuantity = (number / 10000 == 0 || number / 10000 > 9); // проверка числа на пятизначность
if (cheakQuantity) Console.WriteLine("Число не пятизначное");
else
{
    int digit1 = number / 10000;   // получаем 1 цифру
    int digit2 = (number % 10000) / 1000; // получаем 2 цифру
    int digit4 = (number % 100) / 10; // получаем 4 цифру
    int digit5 = number % 10; // получаем 5 цифру

    bool result = (digit1 == digit5 && digit2 == digit4);  // сравниваем цифры
    if (result) Console.WriteLine($"Число {number} является палиндромом");
    else Console.WriteLine($"Число {number} не является палиндромом");
}
