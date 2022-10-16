//Задача 36: 
//Задайте одномерный массив, заполненный случайными числами. 
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = CreateArrayRndInt(7, 1, 10);
PrintArray(arr);
int sumOddIndexNumbers = SumOddIndexNumbers(arr);
Console.WriteLine($"Сумма чисел, записанных в нечётные позиции массива, равна: {sumOddIndexNumbers}");

//метод суммирования чисел, записанных в нечётные позиции массива
int SumOddIndexNumbers(int[] array)
{
    int result = default;
    for (int i = 1; i < array.Length; i+=2)
    {
        result += array[i];
    }
    return result;
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
     Console.WriteLine("]"); 
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