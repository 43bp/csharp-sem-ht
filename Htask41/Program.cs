//Задача 41: 
//Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Укажите кол-во вводимых чисел: ");
int quantityNumbers = Convert.ToInt32(Console.ReadLine());
int[] fillFixQuanNumArray = FillFixQuanNumArray(quantityNumbers);
int countQuantityNumbers = СountQuantityNumbers(fillFixQuanNumArray);
PrintArray(fillFixQuanNumArray);
Console.WriteLine($"Кол-во введенных Вами чисел значением > 0 равно: {countQuantityNumbers}");


// метод создания и наполнения пользователем массива фиксированным количеством чисел
int[] FillFixQuanNumArray(int quantity)
{
    int[] array = new int[quantity];
    for (int i = 0; i < quantity; i++)
    {
        Console.WriteLine($"Введите число №{i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}


// метод подсчета кол-ва чисел > 0 в массиве

int СountQuantityNumbers(int[] array)
{
    int i = 0;
    int count = 0;
    while (i < array.Length)
    {
        if (array[i] > 0)
        {
            count++;
            i++;
        }
        else i++;
    }
    return count;
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

