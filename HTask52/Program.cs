// Задача 52. 
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arrayMatrix = NewRndArrayMatrix (5, 5, 1, 20);
Console.WriteLine();
PrintMatrix (arrayMatrix);
Console.WriteLine();
ArithmeticMeanOfEachColumn(arrayMatrix);


// метод подсчета и вывода среднего арифметического каждого столбца двумерного массива
void ArithmeticMeanOfEachColumn(int[,] matrix)
{
    Console.Write($"Среднее арифметическое каждого столбца массива: ");
    double sum = 0;
    double arithmeticMean = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
        }
        arithmeticMean = Math.Pow(sum / matrix.GetLength(0), 1);
        if (j < matrix.GetLength(1) - 1) Console.Write($"{arithmeticMean}; ");
        else Console.Write($"{arithmeticMean}");
        sum = 0;
        arithmeticMean = 0;
    }
}


// метод создания и заполнения массива + и - элементами
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