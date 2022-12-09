//Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.

void Polin(int num)
{
    int sum = 0;
    int newsum = num;
    {
        while (num != 0)
        {
            int ost = num % 10;
            sum = sum * 10 + ost;
            num = num / 10;
        }
        if (newsum == sum ) 
        Console.Write(" Yes! ");
        else 
        Console.Write(" No! ");
    }
}
    Console.Write("Enter your number: ");
    int Num = Convert.ToInt32(Console.ReadLine());
    Polin(Num);
    

/*
//Задача 21 Напишите программу, которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве.

double Dist(double x1, double y1, double z1, double x2, double y2, double z2)
   
{
    double rasst = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
    return Math.Round (rasst, 4);
}
Console.Write("Введите координ. - Х для точки А :");
double Ax1  = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координ. - Y для точки А :");
double Ay1  = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координ. - Z для точки А :");
double Az1  = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координ. - Х для точки B :");
double Bx2  = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координ. - Y для точки B :");
double By2  = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координ. - Z для точки B :");
double Bz2  = Convert.ToDouble(Console.ReadLine());

double result = Dist(Ax1, Ay1, Az1, Bx2, By2, Bz2);
Console.WriteLine("Расстояние между точками " + result); */


//Задача 23
//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void Kub(int Num)
{
    for (int i = 1; i <= Num; i++ )
    {
        double result = Math.Pow(i, 3);
        Console.Write(result + ", ");
        if (i == Num)
        Console.Write(".");
        }
}
Console.WriteLine("Введите число для возведения в куб: ");
int Num = Convert.ToInt32(Console.ReadLine());
Kub(Num);
*/


