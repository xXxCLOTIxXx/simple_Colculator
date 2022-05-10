using System;

namespace colculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число");
            string num1 = Console.ReadLine();
            Console.WriteLine("Введите символ (+ - * :)");
            string symbol = Console.ReadLine();
            Console.WriteLine("Введите второе число");
            string num2 = Console.ReadLine();
            if (symbol == "+")
            {
                Console.WriteLine($"Ответ: {Convert.ToInt32(num1) + Convert.ToInt32(num2)}");
            }
            else if (symbol == "-")
            {
                Console.WriteLine($"Ответ: {Convert.ToInt32(num1) - Convert.ToInt32(num2)}");
            }
            else if (symbol == "*")
            {
                Console.WriteLine($"Ответ: {Convert.ToInt32(num1) * Convert.ToInt32(num2)}");
            }
            else if (symbol == ":")
            {
                Console.WriteLine($"Ответ: {Convert.ToInt32(num1) : Convert.ToInt32(num2)}");
            }
            else
            {
                Console.WriteLine("Вы ввели неверный символ!");
            }

        }
    }
}
