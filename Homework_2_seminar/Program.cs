// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*

int Cutnumber(int num)
{
    int odin = num / 10;
    int vtoroe = odin % 10;
    
    if (num / 100 > 0 && num / 1000 == 0) return vtoroe;
    else return -1;
};

    Console.Write("Input trehznachnoe number: ");
    int Num = Convert.ToInt32(Console.ReadLine());
    int Newnum = Cutnumber(Num);
    Console.WriteLine("вторая цифра введённого числа " + Newnum);
    */


    //Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int Cutnumber(int num)
{
while (num > 999)
    {
        num = num / 10;
        }
    int third = num % 10;
    int fool = -1;
   
    if (num / 100 > 0) return third;
    else return fool;
}
    Console.Write("Input number: ");
    int Num = Convert.ToInt32(Console.ReadLine());
    int Newnum = Cutnumber(Num);
    Console.WriteLine("третья цифра введённого числа " + Newnum);
    



    // Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

  /*  
    bool Numday(int num)
   { 
    int current = num;
    if (current == 6 || current == 7) return true;
    else return false;
   }
   Console.Write("Введите номер дня: ");
    int Num = Convert.ToInt32(Console.ReadLine());

    if (Num <= 7 && Num >= 1)
    {
        bool Newnum = Numday(Num);
        Console.Write("В неделе 7 дней, Ура! ");
        Console.WriteLine("Введённый день недели " + Newnum);
    }
    else 
    Console.WriteLine("НЕ СУЩЕСТВУЮЩИЙ день недели");
    */
    