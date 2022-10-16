// Задача 38: 
// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] arr = CreateArrayRndInt(5, 0.1, 9.9);
PrintArray(arr);
double diffMaxMinElemArray = DiffMaxMinElemArray(arr);
Console.WriteLine($"Разница между максимальным и минимальным элеметом равна: {diffMaxMinElemArray}");


// метод расчета разницы между максимальным и минимальным элементом массива
double DiffMaxMinElemArray (double[] array)
{
    int i = 0;
    double maxElement = array[i];
    double minElement = array[i];
    double result = default;
    while (i < array.Length)
    {
        if (maxElement < array[i]) maxElement = array[i];
        else if (minElement > array[i]) minElement = array[i];
        i++;
    }
    Console.WriteLine($"Маскимальный элемент: {maxElement}");
    Console.WriteLine($"Минимальный элемент: {minElement}");
    result = maxElement - minElement;
    return Math.Round(result, 1);
}


//метод создания и заполнения массива вещественными числами с округлением до десятых
double[] CreateArrayRndInt(int size, double min, double max)
{
    double[] array = new double[size];
    Random rnd = new Random();
        
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
    }
    return array;
}


//метод печати массива в формате [1,1 | 2,4 | 3,5]
void PrintArray (double[] array)
{
    Console.Write("[");    
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]} | ");
        else Console.Write(array[i]);
    }
     Console.WriteLine("]"); 
}