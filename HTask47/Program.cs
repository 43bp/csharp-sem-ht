// двумерный массив размером m,n
// заполненный случ.вещественными числами

double[,] newRndDoubleMatrix = NewRndDoubleMatrix (4, 4, 1, 9);
PrintDoubleMatrix(newRndDoubleMatrix);


// метод создания и заполнения массива случ. вещественными числами
double[,] NewRndDoubleMatrix (int rows, int col, int min, int max)
{
    var matrix = new double[rows, col];
    var rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(rnd.NextDouble() * (max - min) + min, 1);
        }
    }
    return matrix;
}

// метод печати массива с вещественными числами
void PrintDoubleMatrix (double[,] matrix)
{
    for (var i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
           Console.Write($"{matrix[i, j], 6}");
        }
        Console.WriteLine("    |");
    }
}