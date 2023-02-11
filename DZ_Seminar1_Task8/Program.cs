/*Задача 8: Напишите программу, которая на вход принимает число (N),
а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 2 && number > -2)
{
    System.Console.WriteLine("От 0 до " + number + " нет чётных чисел");
}
if (number > 0)
{
    int i = 2;
    while (i <= number)
    {
        Console.Write(i);
        if (i < number && i < number - 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.WriteLine(".");
        }
        i = i + 2;
    }
}
else
{
    int i = -2;
    while (i >= number)
    {
        Console.Write(i);
        if (i > number && i > number + 1)
        {
            Console.Write(", ");
        }
        else
        {
            Console.WriteLine(".");
        }
        i = i - 2;
    }
}
