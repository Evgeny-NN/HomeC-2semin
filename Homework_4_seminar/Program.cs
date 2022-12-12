//Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в 
//натуральную степень B.
/*

double Stepen(double num, double step)
{
    double proizv = 1;
    if (step > 0)
    {
        for (int current = 1; current <= step; current++)
        {
            proizv = proizv * num;
        }
        return proizv;     
    }
    else
    {
        for (int lav = -1; lav >= step; lav--)
        {
            proizv = proizv * num;
        }
        double otrizStep = 1/proizv;
        return otrizStep;
    }
}
Console.Write("Введите число для возведения в степень: ");
Double Num = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите целую степень :");
Double Step = Convert.ToDouble(Console.ReadLine());
Double result = Stepen(Num, Step);
Console.WriteLine($"{Num} в степени {Step} равно {result}");
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int Row(int num)
{
    int sum = 0;
    while (num != 0)
    {
        int ost = num % 10;
        sum = sum + ost;
        num = num / 10;
    }
return sum;
}
Console.Write("Input a number: ");
int Num = Convert.ToInt32(Console.ReadLine());
int result = Row(Num);
Console.WriteLine($"{Num} сумма цифр в этом числе равна {result}");

*/

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] CreateArray(int size)
{   
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Элемент: [{ i+1}] : ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
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
}
Console.Write("введите количество элементов массива : ");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);