using System;

namespace Calculatorrrrr
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                double a;
                double b;
                double res = 0;
                char oper;
                do
                {
                    do
                    {
                        Console.WriteLine("Введите первое число:");
                        if (double.TryParse(Console.ReadLine(), out a))
                        {
                            break;
                        }
                    }
                    while (true);

                    Console.WriteLine("Введите оператор:");
                    oper = Convert.ToChar(Console.ReadLine());

                    
                    Console.WriteLine("Введите второе число:");
                    do
                    {
                        if (double.TryParse(Console.ReadLine(), out b))
                        {
                            break;
                        }
                    } while (true);

                    if (oper == '+')
                    {
                        res = Sum(a, b);
                    }
                    else if (oper == '-')
                    {
                        res = Sub(a, b);
                    }
                    else if (oper == '*')
                    {
                        res = Mult(a, b);
                    }
                    else if (oper == '/')
                    {
                        res = Div(a, b);
                    }
                    else
                    {
                        Console.WriteLine("Неизвестный оператор.");
                    }
                    Console.WriteLine("Результат {0}", res);
                    Console.ReadLine();

                    




                } while (true);
            }
        }


        static double Sum(double first, double second)
        {
            return first + second;
        }
        static double Sub(double first, double second)
        {
            return first - second;
        }
        static double Mult(double first, double second)
        {
            return first * second;
        }
        static double Div(double first, double second)
        {
            double result;

            if(second == 0)
            {
                Console.WriteLine("На ноль не делится");
                result = 0;
            }
            else
            {
                return  first / second;
            }
            return result;
        }
    }
}

   
