// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными
// вещественными числами.
/*
double[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
             array[i,j] = Math.Round(rnd.NextDouble() + rnd.Next(minValue, maxValue), 1);
    return array;
}
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {for (int j = 0; j < array.GetLength(1); j++)
            {Console.Write(array[i, j] + "   ");}
        Console.WriteLine();}
}
double[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] CreateRandom2dArray()
{
    Console.Write("Input a number of rows: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a number of columns: ");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a min value: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Input a max value: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] array = new int[rows, columns];

    for (int i = 0; i < rows; i++)

        for (int j = 0; j < columns; j++)
            array[i, j] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + "  ");
        Console.WriteLine();
    }
}

void ItemPositions(int[,] array)
{
    Console.Write("enter position indexes i: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.Write("enter position indexes j: ");
    int b = Convert.ToInt32(Console.ReadLine());

    if (a >= array.GetLength(0) || b >= array.GetLength(1))
        Console.WriteLine("There are no numbers with such indexes in the array!");
    else
    {
        int position = array[a, b];
        Console.WriteLine("Namber : " + position);
    }
}
int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
ItemPositions(myArray);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое
// элементов в каждом столбце.

/*
int[,] CreateRandom2dArray()
{
Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a min value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];

for (int i = 0; i < rows; i++)

for (int j = 0; j < columns; j++)
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

void Arithmetic(int[,] array)                                       // 1 способ решения через метод void
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
            double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        Console.Write(Math.Round(sum / array.GetLength(0), 1) + " ");
    }
}
*/
/*
double[] Arithmetic(int[,] array)                                    // 2 способ решения через вывод массива
{
    double[] numSum = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j]; 
        }
        numSum[j] = sum / array.GetLength(0);
    }
    return numSum;
}
void ShowArray(double[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
double[] myArray2 = Arithmetic(myArray);
ShowArray(myArray2);
*/