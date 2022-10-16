//Задача 34: Задайте массив заполненный случайными 
//положительными трёхзначными числами. 
//Напишите программу, которая 
//покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = CreateArrayRndInt(3, 100, 999);
int countEvenNumbers = CountEvenOddNumbers(arr, 2);
if (countEvenNumbers != default) 
{
    PrintArray(arr);
    Console.Write($" -> кол-во четных чисел в массиве равно: {countEvenNumbers}");
}


//метод  подсчета кол-ва четных/нечетных чисел в массиве
int CountEvenOddNumbers(int[] array, int evenOrOdd)
{
    int count = 0;
    if (evenOrOdd % 2 == 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0) count++;
        }

    }
    else if (evenOrOdd <= 0 || evenOrOdd > 2) 
    {
        Console.WriteLine("Для настройки поиска четного или нечетного числа, введите во второй атрибут метода CountEvenOddNumbers: 2 или 1, соответственно");
    }
    else
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 > 0) count++;
        }
    }
    return count;
}


//метод создания и заполнения массива
int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
        
    for (int i = 0; i < size; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

//метод печати массива в формате [1, 2, 3]
void PrintArray (int[] array)
{
    Console.Write("[");    
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write(array[i]);
    }
     Console.Write("]"); 
}