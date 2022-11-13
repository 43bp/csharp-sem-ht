/* Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int[,] arrayMatrix = NewRndArrayMatrix (4, 5, 1, 9);
PrintMatrix (arrayMatrix);
int[] array = SumElemRowsArrayMatrix (arrayMatrix);
int numElemArray = SearchMinElemArray(array);
Console.WriteLine();
Console.WriteLine($"Номер строки с наименьшей суммой элементов: {numElemArray + 1}");

// метод поиска индекса наименьшего элемента в одномерном массиве
int SearchMinElemArray(int[] arr)
{
    int minElem = arr[0];
    int indexMinElem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
       if (minElem > arr[i])  // 2 5 6 1 2
        {
            minElem = arr[i];
            indexMinElem = i;
        } 
    }
    return indexMinElem;
}

// метод подсчета суммы элементов строк двумерного массива и записи результатов в одномерный массив
int[] SumElemRowsArrayMatrix (int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    int k = 0; // индекс элемента одномерного массива
    int sum = 0; // сумма элементов строки двумерного массива
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
        }
        array[k] = sum;
        sum = 0;
        k++;
    }
    return array;
}

// метод создания и зополнения двумерного массива
int[,] NewRndArrayMatrix (int rows, int col, int min, int max)
{
    var matrix = new int[rows, col]; 
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

// метод печати массива
void PrintMatrix (int[,] matrix)
{
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j], 4}");
        }
        Console.WriteLine("   |");
    }
}