using System;

namespace primeira_aula
{
    class Program
    {
        static void Exercise4L2()
        {
            // Leia dois arrays A e B com 10 elementos. Em seguida, compare os arrays e verifique se
            // os mesmos são iguais ou diferentes

            const int arraysLenght = 3;

            var a = new double?[arraysLenght];
            var b = new double?[arraysLenght];

            System.Console.WriteLine($"Informe os {arraysLenght} primeiros valores: ");
            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor: ");
                a[i] = double.Parse(Console.ReadLine());
            }

            System.Console.WriteLine($"Informe os próximos {arraysLenght} valores: ");
            for (int i = 0; i < arraysLenght; i++)
            {
                System.Console.WriteLine("Digite um valor: ");
                b[i] = double.Parse(Console.ReadLine());
            }

            var arraysAreEquals = true;

            foreach (var itemB in b)
            {
                var hasEquals = false;

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] == itemB)
                    {
                        hasEquals = true;
                        a[i] = null;
                        break;
                    }
                }

                if (!hasEquals)
                {
                    arraysAreEquals = false;
                    System.Console.WriteLine("Os arrays são diferentes");
                    break;
                }
            }

            if (arraysAreEquals)
            {
                System.Console.WriteLine("Os arrays são iguais");
            }

        }
         static void Exercise3L3()
         {
            // Um certa empresa fez uma pesquisa para saber se as pessoas gostaram ou não de um novo
            // produto lançado no mercado. Para isso, forneceu-se o sexo do entrevistado e a sua resposta
            // (sim ou não). Sabendo-se que foram entrevistadas 10 pessoas, fazer um algoritmo que calcule e
            // escreva:
            // • O número de pessoas que responderam sim;
            // • O número de pessoas que responderam não;
            // • A percentagem de pessoas do sexo feminino que responderam sim;
            // • A percentagem de pessoas do sexo masculino que responderam não;
            const int quantidade = 3;

            var S = new string[quantidade];
            var R = new string[quantidade];
            (int fem, int mas) respostas = (0,0);
            (int s, int n) respostas2 = (0,0);
            
            for (int i = 0; i < quantidade; i++)
            {
                System.Console.WriteLine("Informe o seu sexo (fem / mas)");
                S[i] = Console.ReadLine();        

                if (S[i] == "fem")
                {
                    respostas.fem++;
                }    
                else
                {
                    respostas.mas++;
                } 
            }

            for (int i = 0; i < quantidade; i++)
            {
                System.Console.WriteLine("Você gostou do produto? (sim / não)");
                R[i] = Console.ReadLine();

                if (R[i] == "sim")
                {
                    respostas2.s++;
                }
                else
                {
                    respostas2.n++;
                }
            }

            System.Console.WriteLine($"{respostas2.s} pessoas responderam sim ");
            System.Console.WriteLine($"{respostas2.n} pessoas responderam não ");


            System.Console.WriteLine($"A porcentagem de pessoas do sexo feminino que responderam sim foi: %{(respostas.fem * 100)/respostas2.s}");
            System.Console.WriteLine($"A porcentagem de pessoas do sexo masculino que responderam não foi: %{(respostas.mas * 100)/respostas2.n}");
            
         }
         static void Exercise6L2()
         {
            // Leia um array A com 12 elementos. Após sua leitura, colocar os seus elementos em
            // ordem crescente. Depois ler um array B também com doze elementos, colocar os
            // elementos de B em ordem decrescente. Construir um array C, onde cada elemento de C é a
            // soma do elemento correspondente de A com b. Colocar em ordem crescente a matriz
            // C e apresentar os seus valores.

            var A = new int[12];
            var B = new int[12];
            var C = new int[12];

            for (int i = 0; i < 12; i++)
            {
                System.Console.WriteLine("Informe um número: ");
                A[i] = Int32.Parse(Console.ReadLine());

            }

         } 
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

            var num = new int[5];
            var s = 0;

            for (int i = 0; i < 5; i++)
            {
                System.Console.WriteLine("Informe um número: ");
                num[i] = Int32.Parse(Console.ReadLine());
              
            
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
            Exercise3L3();
        }
    } 
}