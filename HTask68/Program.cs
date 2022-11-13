/* Задача 68: Напишите программу вычисления функции Аккермана 
с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

Console.WriteLine("Введите неотрицательное число m:");
int numM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите неотрицательное число n:");
int numN = Convert.ToInt32(Console.ReadLine());
if (numM >= 0 && numN >= 0)
{
    int acerMan = AcerMan (numM, numN);
    Console.WriteLine($"A({numM},{numN}) = {acerMan}");
}
else Console.WriteLine($"Введите НЕОТРИЦАТЕЛЬНЫЕ числа!");

int AcerMan (int m, int n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AcerMan(m - 1, 1);
    else return AcerMan(m - 1, AcerMan(m, n - 1));
}