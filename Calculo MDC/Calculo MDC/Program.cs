using System;

namespace Calculo_MDC
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 0, n2 = 0, resto = 0;

            Console.WriteLine("Digite o primeiro valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            
            do
            {
                resto = n1 % n2;

                n1 = n2;
                n2 = resto;
            } while (resto != 0);
            Console.WriteLine(n1);
        }
    }
}

// MDC entre 12 e 56:
// 1, 2, 3, 4, 6, 12
//1. 2, 4, 7, 8, 14, 28, 56
/*
                if (resto == 0)
                {
                    Console.WriteLine(i);
                }*/
                        /*for (int z = 1; z <= i; z++)
                            {
                                if (z =)
                            }*/