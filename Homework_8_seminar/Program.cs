// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
// элементы каждой строки двумерного массива.
/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input current of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input current of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
void Revers2d(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int current = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = current;
        }
      }
    }
  }
}

int[,] myArray = CreateRandom2dArray();
Console.WriteLine();
Show2dArray(myArray);
Revers2d(myArray);
Show2dArray(myArray);
*/

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
/*

int[,] CreateRandom2dArray()
{
    Console.Write("Input current of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input current of colums: ");
    int colums = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min possible value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max possible value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}
int[] RowsSum(int[,] array)          // находим суммы элементов в каждой строке и записываем в одномерный массив                               
{
    int[] totalSum = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        totalSum[i] = sum;
    }
    return totalSum;
}
void ShowArray(int[] array)
{
    int minSumRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minSumRow])
        {
            minSumRow = i;
        }
    }
    Console.Write($"Наименьшая сумма элементов в {minSumRow + 1} строке");
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Console.WriteLine();
Show2dArray(myArray);
int[] myArray2 = RowsSum(myArray);
ShowArray(myArray2);
Console.WriteLine();
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < colums; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] ProizvedenieMatrix(int[,] firstArray, int[,] secondArray, int rows, int colums)
{
    int[,] resultArray = new int[rows, colums];

    if (firstArray.GetLength(1) != secondArray.GetLength(0))
    {
        Console.WriteLine(" Умножение не возможно! ");
    }
    else
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < secondArray.GetLength(1); j++)
            {
                resultArray[i, j] = 0;
                for (int k = 0; k < firstArray.GetLength(1); k++)
                {
                    resultArray[i, j] += firstArray[i, k] * secondArray[k, j];
                }
            }
        }
    return resultArray;
}

Console.Write("Input current of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input current of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min possible value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max possible value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] firstArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2dArray(firstArray);
int[,] secondArray = CreateRandom2dArray(rows, colums, minValue, maxValue);
Show2dArray(secondArray);
int[,] resultArray = ProizvedenieMatrix(firstArray, secondArray, rows, colums);
Show2dArray(resultArray);
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

int[,,] CreateRandom3dArray(int[] array1d, int pages, int rows, int colums)
{
    int[,,] array3d = new int[pages, rows, colums];
    int current = 0;
    for (int i = 0; i < pages; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            for (int k = 0; k < colums; k++)
            {
                array3d[i, j, k] = array1d[current];            // Заполняем элементы 3d массива элементами
                current++;                                      // 1d массива, в котором генерировали числа
                                                                // array[i, j, k] = new Random().Next(10, 100);
            }
        }
    }
    return array3d;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {

            for (int k = 0; k < array.GetLength(2); k++)

                Console.Write($"{array[i, j, k]} ({i},{j},{k}) ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] CreateArray1d(int pages, int rows, int colums)   // создаём случайную последовательность двузначных чисел;
{                                                      // их кол-во соответствует папраметрам 3 d массива; используем
    int size = pages * rows * colums;                  // метод Random; ими будем заполнять 3d массив
    int[] array1d = new int[size];

    int current;
    for (int i = 0; i < size; i++)
    {
        array1d[i] = new Random().Next(10, 100);
        current = array1d[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array1d[i] == array1d[j])
                {
                    array1d[i] = new Random().Next(10, 100);
                    
                    current = array1d[i];
                }
                current = array1d[i];
            }
        }
    }
    return array1d;
}

Console.Write("Input current of pages: ");
int pages = Convert.ToInt32(Console.ReadLine());
Console.Write("Input current of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input current of colums: ");
int colums = Convert.ToInt32(Console.ReadLine());

int[] myArray1d = CreateArray1d(pages, rows, colums);
int[,,] myArray3d = CreateRandom3dArray(myArray1d, pages, rows, colums);
Console.WriteLine();
Show3dArray(myArray3d);



//Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
