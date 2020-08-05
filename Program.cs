using System;

namespace primeira_aula
{
    class Program
    {
       

         static void Exercise2L2()
         {
            var num = new int[10];

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe um número: ");
                num[i] = Int32.Parse(Console.ReadLine());
            }

            System.Console.WriteLine("Ordem crescente: ");
            for(int i = 0; i < 10; i++)
            {
                System.Console.WriteLine(num[i]);
            }

            System.Console.WriteLine("Ordem decrescente: ");
            for (int i = 9; i > -1; i--)
            {
                System.Console.WriteLine(num[i]);
            }
         }
            
         static void Exercise5L2()
         {
            var A = new int[15];
            var a = 0;
            var b = 0;
            var c = 0;
            var media = 0;
            var soma = 0;

            for (int i = 0; i < 15; i++)
            {
                System.Console.WriteLine("Informe um número: ");
                var result = Int32.Parse(Console.ReadLine());

                soma = result + soma;                

                A[i] = result;
              
                if(i == 14)
                {
                    media = soma / 15;
                }
                

            }
            
            for (int i = 0; i < 15; i++)
            {
                
                if(A[i] < media)
                {
                    a++;
                }
                else if(A[i] > media)
                {
                    b++;
                }
                else if(A[i] == media)
                {
                    c++;
                }

            }
                System.Console.WriteLine(media);
                 if(a > 0)
                {
                    System.Console.WriteLine($"{a} números do Array estão abaixo da média ");
                }
                 if(b > 0)
                {
                    System.Console.WriteLine($"{b} números do Array estão acima da média ");
                }
                if(c > 0)
                {
                    System.Console.WriteLine($"{c} números do Array estão na média de ");
                }
        }
        
        static void Exercise14L1()
        {
            // Ler três valorese colocálos em ordem.
            var smaller = Double.MinValue;
            var middle = Double.MinValue;
            var greater = Double.MinValue;

            for (int i = 0; i < 3; i++)
            {
                System.Console.WriteLine("Informe um número: ");
                var input = Double.Parse(Console.ReadLine());

                if(input < smaller)
                {
                    if(i ==0)
                    {
                        smaller = input;
                    }
                    greater = middle;
                    middle = smaller;
                    smaller = input;  
                }
                    else if(input >middle)
                    {
                        middle = greater;
                        greater = input;
                    }
                    else
                    {
                        middle = input;
                    }
            }
            System.Console.WriteLine($"\nO primeiro número é: {smaller}");
            System.Console.WriteLine($"O segundo número é: {middle}");
            System.Console.WriteLine($"O terceiro número é: {greater}");
        }
            
        static void Exercise2L3()
        {
            // Dado um vetor qualquer com 10 números, faça um programa que informa se há ou não números repetidos nesse vetor.

            var num = new int[10];
            var s = 0;

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine("Informe um número: ");
                var result = Int32.Parse(Console.ReadLine());

                num[i] = result;
                if (num[i] == result)
                {
                    s++;
                }
            }
            if (s > 0)
            {
                System.Console.WriteLine("Há números repetidos no vetor!");
            }
            else
            {
                System.Console.WriteLine("Não há números repetidos no vetor!");
            }

        }

         static void Main(string[] args)
        {
            Exercise2L2();
        }
    } 
}