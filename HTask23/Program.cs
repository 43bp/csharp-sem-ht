// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

Console.WriteLine("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool noNatural = number < 1;  // проверка на натуральность
if (noNatural) Console.WriteLine("Введенное число не натуральное");
else
{
    for (int digit = 1; digit <= number; digit++)
    {
      Console.WriteLine($"{digit}|{Math.Pow(digit, 3)}");
    }
}