//Задача 43: 
// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значения k1 и b1 для 1-й линии, заданной уравнением y = k1 * x + b1");
Console.Write("k1 = ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("b1 = ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значения k2 и b2 для 2-й линии, заданной уравнением y = k2 * x + b2");
Console.Write("k2 = ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("b2 = ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (CheakOfIntersectTwoLines(k1, b1, k2, b2))
{
     double[] coordOfIntersectTwoLines = СoordOfIntersectTwoLines(k1, b1, k2, b2);
     Console.Write($"Координаты пересечения линии y = {k1}x + {b1} и линии y = {k2}x + {b2}: ");
     PrintArray(coordOfIntersectTwoLines);
}
else Console.WriteLine("Линии y = {k1} * x + {b1} и y = {k2} * x + {b2} не пересекаются или совпадают");


// метод проверки на пересечение двух линий, заданных уравнением y = k * x + b
bool CheakOfIntersectTwoLines (double numK1, double numB1, double numK2, double numB2)
{
    if (numK1 != numK2) return true;
    return false;
}

// метод поиска координат (округленных до десятых) в 2-мерном пространстве пересечения двух линий, 
// заданных уравнениями y = k * x + b
double[] СoordOfIntersectTwoLines(double numK1, double numB1, double numK2, double numB2)
{
    double[] array = new double[2];
    array[0] = Math.Round((numB2 - numB1) / (numK1 - numK2), 1);
    array[1] = Math.Round(numK1 * ((numB2 - numB1) / (numK1 - numK2)) + numB1, 1);
    return array;
}

//метод печати массива в формате (1,2 , 2,3 , 3,4 ...)
void PrintArray (double[] array)
{
    Console.Write("(");    
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} , ");
        else Console.Write(array[i]);
    }
     Console.WriteLine(")"); 
}
