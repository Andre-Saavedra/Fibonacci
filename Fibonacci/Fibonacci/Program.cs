using System;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduza um numero inteiro maior que zero: ");
            int num = int.Parse(Console.ReadLine());
            int fib = 1, penultimo = 1;


            if (num <= 0)
            {
                Console.WriteLine("Valor inválido");
                return;
            }

            for (int i = 0; i < num; i++)
            {
                if (i == 0 || i == 1)
                {
                    fib = 1;
                    Console.Write(fib);
                }
                else
                {
                    fib = fib + penultimo;
                    Console.Write(fib);
                    penultimo = fib - penultimo;
                }
            }
            Console.ReadKey();
        }
    }
}

