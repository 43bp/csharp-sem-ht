/* Задача 64. Задайте значение N.
Вывести все натуральные числа в промежутке от N до 1.
*/

Console.WriteLine("Введите целое число:");
int number = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(number);

void NaturalNumbers (int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers(num - 1);
}