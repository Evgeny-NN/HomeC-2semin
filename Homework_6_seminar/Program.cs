//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько 
//чисел больше 0 ввёл пользователь.
/*
 //   1 СПОСОБ

int PosNam(int num)
{
    int sum = 0;
    for(int current = 1; current <=num; current++)
    {
        Console.Write($"Введите число [{current}] : ");
     int chislo = Convert.ToDouble(Console.ReadLine());
    
    if(chislo > 0) sum = sum + 1;}
    return sum;
    }
Console.Write("enter the number of array elements : ");
int size = Convert.ToDouble(Console.ReadLine());
int result = PosNam(size);
Console.WriteLine("number of positive elements : " + result);

//  2 СПОСОБ

int[] CreateArray(int size)
{   
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Эл: [{ i+1}] : ");
        array[i] = Convert.ToDouble(Console.ReadLine());
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
int GetSumOfEvenNamb(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i] > 0)
            count ++;
    return count;
}

Console.Write("enter the number of array elements : ");
int size = Convert.ToDouble(Console.ReadLine());

int[] myArray = CreateArray(size);
ShowArray(myArray);
Console.WriteLine();
int rusult = GetSumOfEvenNamb(myArray);
Console.WriteLine("Кол-во положительных чисел: " + rusult );

*/

//  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void Lin(double b1, double k1, double b2, double k2)
{
    if (k1 == k2 && b1 == b2)
    { Console.WriteLine("Прямые совпадатют"); }

    else if (k1 == k2 && b1 != b2)
    { Console.WriteLine("Прямые параллельны"); }
    else
    {
        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;
        Console.WriteLine($" ({x}; {y})");
    }
}
Console.Write("Enter your b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Enter your k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Lin(b1, k1, b2, k2);

