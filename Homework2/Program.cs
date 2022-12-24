// Семинар 2. Домашняя работа.
// Задача 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
/*
int TDigitNumber(int number)
{
    
        int num1 = number / 10;
        int num2 = num1 % 10;
        return num2;
    
}


Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int DigitNumber = TDigitNumber(number);

if (99 < number && 1000 > number) Console.Write($"Вторая цифра числа {number} равна {DigitNumber}");
else Console.Write("Введите корректное ТРЁХзначное число!");
*/

// Задача 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
int IncomNumber(int number, int step)
{
    int num1 = number / Convert.ToInt32(Math.Pow(10, step));
    int num2 = num1 % 10;
    return num2;
}
int QuantNumber(int number)
{
    int num = number;
    int i = 0;
    while (num > 0)
    {
        i++;
        num /= 10;
    }
    return i;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0 && number < 100) Console.Write("Третьей цифры нет!");
else 
{
    int step0 = QuantNumber(number);
    int step = step0 - 3;
    int ThirdNumber = IncomNumber(number, step);
    Console.WriteLine($"Количество цифр в числе {number} равно {step0}");
    Console.WriteLine($"Третья цифра числа {number} это {ThirdNumber}");
}
*/

// Задача 3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
/*
bool DayOff(int number)
{
    if (number == 6 | number == 7) return true;
    else return false;
}

Console.Write("Введите цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(DayOff(number));
*/