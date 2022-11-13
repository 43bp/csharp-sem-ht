/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

int[,] arrayMatrix1 = NewRndArrayMatrix (2, 3, 0, 9);
Console.WriteLine("Матрица 1");
PrintMatrix (arrayMatrix1);
int[,] arrayMatrix2 = NewRndArrayMatrix (3, 4, 0, 9);
Console.WriteLine("Матрица 2");
PrintMatrix (arrayMatrix2);
Console.WriteLine("Результат умножения Матрица 1 и Матрица 2:");
if (arrayMatrix1.GetLength(1) == arrayMatrix2.GetLength(0))
{
    int[,] multiplMatrix = MultiplMatrix(arrayMatrix1, arrayMatrix2);
    PrintMatrix (multiplMatrix);
}
else Console.WriteLine($"Умножение невозможно! Кол-во столбцов Матрицы 1 должно равняться кол-ву строк Матрицы 2!");

// метод умножения двух матриц
int[,] MultiplMatrix (int[,] matrix1, int[,] matrix2)
{
    var multMatrix = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < multMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < multMatrix.GetLength(1); j++)
        {
            for (int m = 0; m < matrix1.GetLength(1); m++)
            {
                sum = sum + (matrix1[i, m] * matrix2[m, j]);
            }
            multMatrix[i, j] = sum;
            sum = 0;
        }
    }
    return multMatrix;
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