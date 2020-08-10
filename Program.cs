using System;

namespace primeira_aula
{
    class Program
    {
        static void Exercise6L3()
        {
            // Ler um vetor de 10 posições (aceitar somente números positivos). Escrever a seguir o
            // valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor.

            const int Array = 10;
            var a = new int[Array];
            (int maior, int posicao) cont = (0,0);  
            
            for (int i = 0; i < Array; i++)
            {
                System.Console.WriteLine($"Informe {Array} números positivos: ");
                var result = Int32.Parse(Console.ReadLine());

                a[i] = result; 

                if (result < 0)
                {
                    System.Console.WriteLine("Apenas números positivos!!");
                }
                if (result > cont.maior)
                {
                    cont.maior = result;
                    cont.posicao = i;
                }
               
            }
            System.Console.WriteLine($"Maior elemento: {cont.maior}\nPosição ocupada no vetor: {cont.posicao}");
            
        }
        static void Exercise4L3()
        {
            // Desenvolver um programa que efetue a leitura de cinco elementos de uma matriz // A do tipo vetor.
            // No final, apresente o total da soma de todos os elementos // que sejam impares.

            const int Array = 5;
            var a = new int[Array];
            int impares = 0;

            for (int i = 0; i < Array; i++)
            {
                System.Console.WriteLine($"Informe {Array} números: ");
                a[i] = Int32.Parse(Console.ReadLine());

                if(a[i] % 2 > 0)
                {
                    impares += a[i];
                };
            }
            System.Console.WriteLine($"A soma dos números impares informados é {impares}");



        }
        static void Exercise5L3()
        {
            // Contar quantos valores de um vetor de 10 posições são positivos

            const int Array = 10;
            var a = new int[Array];
            int positivos = 0;
            var result = 0;

            for (int i = 0; i < Array; i++)
            {
                System.Console.WriteLine("Informe um número: "); 
                try
                {
                    result = Int32.Parse(Console.ReadLine());
                }
                catch (System.Exception)
                {
                    System.Console.WriteLine("Informe um valor válido! ");
                    continue;
                } 

                a[i] = result;
                if (result > 0)
                {
                    positivos++;
                }
            }
            System.Console.WriteLine($"{positivos} valores do vetor são positivos!");

        }
        static void Exercise9L3()
         {
            // Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
            // No final, imprima a string resultante da soma das strings que residem em índices pares.
            
            const int Array = 10;
            var letras = new string[Array];
            var pares = "";

            for (int i = 0; i < Array; i++)
            {
                System.Console.WriteLine("Informe uma letra do alfabeto: ");
                var result = Console.ReadLine();

                letras[i] = result;
            }
            for (int i = 0; i < Array; i+=2)
            {
                pares += letras[i];                
            }
            System.Console.WriteLine($"Soma das letras: {pares}");
            


         }
        static void Exercise8L3()
         {
            // Crie um vetor de strings de 10 posições onde cada posição recebe uma letra do alfabeto.
            // No final, imprima quantas destas são vogais.

            const int Array = 10;
            var alfabeto = new string[Array];  
            int cont = 0;   

            for (int i = 0; i < Array; i++)
            {
                System.Console.WriteLine("Informe uma letra do alfabeto: ");
                var result = Console.ReadLine();

                alfabeto[i] = result;
                
                if (result == "a" || result == "e" || result == "i" || result == "o" || result == "u")
                {
                    cont++;  
                }                
            }
            System.Console.WriteLine($"{cont} das letras informadas são vogais!");
         } 
        static void Exercise7L3()
         {
            // Crie e popule um vetor A e imprima na tela o número de vezes que existe um número
            // residindo na mesma posição do vetor que seu valor numérico.

            const int Array = 10;
            var a = new int[Array];
            int cont = 0;

            for (int i = 0; i < Array; i++)
            {
                System.Console.WriteLine("Informe um número: ");
                var result = Int32.Parse(Console.ReadLine());

                a[i] = result;

                if (i == result)
                {
                    cont++;
                }
            }
            System.Console.WriteLine($"O número de vezes que existe um número residindo na mesma posição do vetor que seu valor numérico é: {cont}");

         }
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
        static void Exercise1L3()
         {
            //Popule dois vetores com 10 valores cada. Após esta operação, troque o conteúdo dos vetores.
            const int Array = 10;

            var A = new int[Array];
            var B = new int[Array];
            var aux = new int[Array];
            
            System.Console.WriteLine($"Informe os {Array} primeiros valores ");
            for (int i = 0; i < Array; i++)
            {
                System.Console.WriteLine("Digite um número: ");
                A[i] = Int32.Parse(Console.ReadLine());
            }

            System.Console.WriteLine($"Informe os póximos {Array} valores ");
            for (int i = 0; i < Array; i++)
            {
                System.Console.WriteLine("Digite um número: ");
                B[i] = Int32.Parse(Console.ReadLine());
            }
            for (int i = 0; i < Array; i++)
            {
                aux[i] = A[i];
                A[i] = B[i];
                B[i] = aux[i];
            }
            for (int i = 0; i < Array; i++)
            {
                System.Console.WriteLine($"{A[i]} troca {B[i]}");
            }
            
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

            const int Array = 5;
            var num = new int[Array];

            for (int i = 0; i < Array; i++)
            {
                System.Console.WriteLine("Informe um número: ");
                num[i] = Int32.Parse(Console.ReadLine());
            } 
             

        }

        static void Main(string[] args)
        {
            Exercise2L3();
        }
    } 
}