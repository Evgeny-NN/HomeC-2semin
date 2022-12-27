//  Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
//  в промежутке от N до 1. Выполнить с помощью рекурсии.

/*
void ShowNums(int num)
{
    if (num > 1)
    {
        Console.Write(num + " ");
        ShowNums(num - 1);
    }
    if (num < 1)
    {
        Console.Write(num + " ");
        ShowNums(num + 1);
    }
    if (num == 1) Console.Write(num + " ");
}
Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
ShowNums(number);
*/
/*
//  Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
//  элементов в промежутке от M до N.

int GetSum(int numM, int numN)
{
    if (numM < numN) return GetSum(numM, numN - 1) + numN;
    else if (numM > numN) return GetSum(numN, numM - 1) + numM;
    else return numM;
}
Console.Write("Input a first number: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = GetSum(numberM, numberN);
Console.WriteLine("sum all elements " + result);
*/


//  Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
//  Даны два неотрицательных числа m и n.

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if ((m > 0) && (n == 0))
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}
Console.Write("Input a first number: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int numberN = Convert.ToInt32(Console.ReadLine());
int result = Akkerman(numberM, numberN);
Console.WriteLine("Ackerman calculation results: " + result);