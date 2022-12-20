// Семинар 1. Домашняя работа.
// Задача 1. Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine("Максимальное число " + num1);
    Console.WriteLine("Минимальное число " + num2);
}
else
{
    Console.WriteLine("Максимальное число " + num2);
    Console.WriteLine("Минимальное число " + num1);
}
*/

// Задача 2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if(num1 < num2) max = num2;
if(num2 < num3) max = num3;

Console.Write("Максимальное число: " + max);
*/

// Задача 3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 2 == 0) Console.Write("Число " + num + " является чётным");
else Console.Write("Число " + num + " не является чётным");
*/

// Задача 4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int cur1 = 2;
int cur2 = -2;

if(num > 0)
{
    while(cur1 <= num)
    {
        Console.Write(cur1 + " ");
        cur1 += 2;
    }
}
if(num < 0)
{
    while(cur2 >= num)
    {
        Console.Write(cur2 + " ");
        cur2 -= 2;
    }
}
*/