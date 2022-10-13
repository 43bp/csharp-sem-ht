// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите натуральную степень, в которую это число возвести: ");
int degree = Convert.ToInt32(Console.ReadLine());
degree = Natural (degree); // вызываем метод проверки числа на натуральность

int result = Degree(number, degree); // вызываем метод возведения числа в степень
Console.WriteLine($"Число {number} в степени {degree} = {result}");


// ==================================================================================
// Метод проверки числа на натуральность
int Natural (int num)
{   while (num <= 0)
    {
        Console.WriteLine("Это значение степени не натуральное!");
        Console.WriteLine();
        Console.WriteLine("Введите натуральную степень, в которую это число возвести: ");
        num = Convert.ToInt32(Console.ReadLine());
    }
    return num;
}


// ==================================================================================
// Метод возведения числа в степень
int Degree (int num, int deg)
{
    int multipl = num;
    for (int i = 1; i < deg; i++)
    {
        checked
        {
            multipl = multipl * num;
        }
    }
    return multipl;
}
