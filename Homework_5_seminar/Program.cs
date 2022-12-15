//Задача 34: Задайте массив заполненный случайными положительными трёхзначными
//числами. Напишите программу, которая покажет количество чётных 
//чисел в массиве.
/*

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)
        array[i] = new Random().Next(minValue, maxValue + 1);
    return array;
}
void ShowArray(int[] array)
{   Console.Write( "[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
     Console.Write("]");
    Console.WriteLine();
}

int GetSumOfEvenNamb(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
        if (array[i] % 2 == 0)
            count ++;
    return count;
}

Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("min three - digit value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("max three - digit value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = GetSumOfEvenNamb(myArray);
Console.WriteLine("Sum of even elements array " + result);

*/

//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

/*
int[] CreateRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < size; i++)

        array[i] = new Random().Next(minValue, maxValue + 1);

    return array;
}

void ShowArray(int[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
int GetSumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 != 0)
            sum += array[i];
    return sum;
}

Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("max value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

int result = GetSumOddPosition(myArray);
Console.WriteLine("Sum of nambers on not even position is " + result);

*/

//Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
//максимальным и минимальным элементов массива.


double[] CreateRandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

   
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().NextDouble() + new Random().Next(minValue, maxValue);
    }
    return array;
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
double GetDif(double[] array)
{
    double max = array[0];
    double min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];


        else if (array[i] < min) min = array[i];

    }
    double difference = max - min;
    return Math.Round(difference, 3);
}

Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("min value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("max value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomArray(size, min, max);
ShowArray(myArray);

double result = GetDif(myArray);

Console.WriteLine("difference of values max and min " + result);
