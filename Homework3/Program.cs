// Семинар 3. Домашняя работа.
// Задача 1. Напишите программу, которая принимает на вход число и проверяет, является ли оно палиндромом.
/*
bool Polindrom(int num)
{
    int index = 0;
    int PolNum = num;
    while (num > 0)
    {
        index = index * 10 + num % 10;
        num = num / 10;
    }
    if (index == PolNum) return true;
    else return false;
}
Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (Polindrom(number)) Console.WriteLine($"Число {number} - полиндром.");
else Console.WriteLine($"Число {number} не полиндром.");
*/

// Задача 2. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
double coord(double x1, double y1, double c1, double x2, double y2, double c2)
{
   return Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(c1 - c2, 2)), 2);
}

Console.Write("Введите x1: ");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y1: ");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c1: ");
double c1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите x2: ");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите y2: ");
double y2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите c2: ");
double c2 = Convert.ToDouble(Console.ReadLine());

Console.Write(coord(x1, y1, c1, x2, y2, c2));
*/

// Задача 3. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
void multNumber(int num)
{
    int quant = num;
    int index = 1;
    while (index <= num)
    {
        int N = Convert.ToInt32(Math.Pow(index, 3));
        index++;
        Console.Write(N + " ");    
    }
    return;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

multNumber(num);
*/