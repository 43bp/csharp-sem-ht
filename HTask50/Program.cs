// Задача 50. 
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
//1 4 7 2
//5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

int[,] arrayMatrix = NewRndArrayMatrix (5, 5, 0, 99);
Console.WriteLine();
PrintMatrix (arrayMatrix);

Console.WriteLine();
Console.WriteLine("Введите индекс строки искомого элемента: ");
int numRow = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца искомого элемента: ");
int numCol = Convert.ToInt32(Console.ReadLine());

if (CheckExistElemMatrix (arrayMatrix, numRow, numCol)) Console.WriteLine($"Искомый элемент с индексом ({numRow}, {numCol}) равен: {arrayMatrix[numRow, numCol]}");
else Console.WriteLine ($"Элемента с индексом ({numRow}, {numCol}) в массиве не существует! Нумерация индекса начинается с нуля.");

// метод проверки наличия элемента в двумерном массиве
bool CheckExistElemMatrix (int[,] matrix, int i, int j)
{
    if (i < matrix.GetLength(0) && j < matrix.GetLength(1)) return true;
    else return false;
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