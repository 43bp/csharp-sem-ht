/* Задача 66. 
Задайте знаяени M и N.
Выведите сумму натуральных элементов от M до N.
*/

Console.WriteLine("Введите целое число от:");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите целое число до:");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2) 
{
    int sumNumbers = SumNumbers(number1, number2);
    Console.WriteLine($"{number1}, {number2} -> {sumNumbers}");
}
else if (number1 > number2)
{
    int sumNumbers = SumNumbers(number2, number1);
    Console.WriteLine($"{number1}, {number2} -> {sumNumbers}");
}
else Console.WriteLine($"{number1}, {number2} -> {number1}");

int SumNumbers(int num1, int num2)
{
    if (num2 == num1 - 1) return 0;
    else return num2 + SumNumbers(num1, num2 - 1);
}