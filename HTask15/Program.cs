// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели: ");
int noDofW = Convert.ToInt32(Console.ReadLine());
bool cheakweek = noDofW <= 0 || noDofW > 7;
if (cheakweek) Console.WriteLine("Дня недели под таким номером не существует");
else 
{
    bool cheak = noDofW > 5;
    if (cheak) Console.WriteLine($"{noDofW} -> да");
    else Console.WriteLine($"{noDofW} -> нет");
}