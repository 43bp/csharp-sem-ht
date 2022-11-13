/*  Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Например, задан массив размером 2 x 2 x 2.
Результат:
66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)
*/

int rows = 6;
int col = 5;
int depth = 2;
int min = 10;
int max = 99;
if (rows * col * depth <= max + 1 - min)
{
    int[,,] cube = NewRndArrayCube (rows, col, depth, min, max);
    Print3DArrayinRows (cube);
}
else Console.WriteLine($"Заданного диапазона чисел не хватает для заполнения трехмерного массива");

// метод создания и заполнения трехмерного массива рандомными неповторяющимися элементами из заданного диапазона
int[,,] NewRndArrayCube (int rows, int col, int depth, int min, int max)
{   
    int[] randArr = new int[max + 1 - min]; // создаем одномерный массив размером с заданный диапазон
    randArr[0] = min; // записываем в первый элемент минимальное значение из заданного диапазона
    for (int m = 1; m < randArr.Length; m++) // заполняем массив числами из заданного диапазона в порядке возрастания
    {
        randArr[m] = randArr[m - 1] + 1;
    }
    var rnd = new Random(); // запускаем генератор случайных чисел
    for (int l = 0; l < randArr.Length; l++) // перемешаем каждый элемент массива со случайным
    {
        int l1 = rnd.Next(0, randArr.Length);
        int temp = randArr[l];
        randArr[l] = randArr[l1];
        randArr[l1] = temp;
    }
    int p = 0; // назначаем новую переменную для индекса одномерного массива
    int[,,] cube = new int[rows, col, depth]; // создаем трехмерный массив
    for (int i = 0; i < cube.GetLength(0); i++) // заполняем трехмерный массив числами из одномерного массива
    {
        for (int j = 0; j < cube.GetLength(1); j++)
        {
            for (int k = 0; k < cube.GetLength(2); k++)
            {
                cube[i,j,k] = randArr[p];
                p++;
            }
        }
    }
    return cube;
}

// метод построчного вывода элементов с индексами из трехмерного массива
void Print3DArrayinRows (int[,,] arrayCube)
{
    for (int k = 0; k < arrayCube.GetLength(2); k++)
    {
        for (int i = 0; i < arrayCube.GetLength(0); i++)
        {
            Console.WriteLine();
            for (int j = 0; j < arrayCube.GetLength(1); j++)
            {
                Console.Write($"{arrayCube[i,j,k]}({i}, {j}, {k})  "); 
            }
        }
    }
}