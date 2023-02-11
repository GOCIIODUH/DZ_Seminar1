int a = 1;
while (a == 1)
{
    System.Console.WriteLine("Для выхода нажмите CTRL+C");
    System.Console.WriteLine("Задания по 1 семинару");
    System.Console.WriteLine("2) Сравнение 2 чисел введенных пользователем");
    System.Console.WriteLine("4) Вывод максимального числа из трех введенных пользователем");
    System.Console.WriteLine("6) Определение чётности числа введенного пользователем");
    System.Console.WriteLine("8) Вывод всех четных чисел от 0 до введенного пользователем числа");
    System.Console.WriteLine("Введите номер требуемой задачи: ");
    int task = Convert.ToInt32(Console.ReadLine());
    switch (task)
    {
        case 2:
            {
                Console.Write("Введите первое число для сравнения: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число для сравнения: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                if (number1 > number2)
                {
                    System.Console.WriteLine(number1 + " > " + number2);
                }
                else
                {
                    System.Console.WriteLine(number1 + " < " + number2);
                }
                break;
            }
        case 4:
            {
                Console.Write("Введите первое число: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите второе число: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите третие число: ");
                int number3 = Convert.ToInt32(Console.ReadLine());
                int max = number1;
                if (number2 > max)
                {
                    max = number2;
                }
                if (number3 > max)
                {
                    max = number3;
                }
                System.Console.WriteLine("Максимальное число из введенных: " + max);
                break;
            }
        case 6:
            {
                Console.Write("Введите число: ");
                int number = Convert.ToInt32(Console.ReadLine());
                int x = number % 2;
                if (x == 0)
                {
                    System.Console.WriteLine(number + " - четное число");
                }
                else
                {
                    System.Console.WriteLine(number + " - нечетное число");
                }
                break;
            }
        case 8:
            {
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
                break;
            }
        default:
            {
                System.Console.WriteLine("Задание №" + task + " отсутствует в домашних заданиях по 1 семинару");
                break;
            }
    }
}