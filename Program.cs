using System;

namespace primeira_aula
{
    class Program
    {
        static void Main(string[] args)
        {

            // var names = new string[3];
            // var counter = 0;

            // while (counter < 3)
            // {
            //     System.Console.WriteLine("Digite um nome");
            //     var result = Console.ReadLine();

            //     names[counter] = result;
            //     counter++;
            // }
            // System.Console.WriteLine($"Olá, {names[0]}!");
            // System.Console.WriteLine($"Olá, {names[1]}!");
            // System.Console.WriteLine($"Olá, {names[2]}!");

            // !!!!!!14)Ler três valores e colocá-los em ordem!!!!!! SÓ FALTA ESSA
            // int cont = 0;
            // int cont2 = 0;
            // int[] num = new int[3];

            // for (cont = 0; cont < 3; cont++)
            // {
            //     Console.Write("Digite um número: ");
            //     num[cont] = int.Parse(Console.ReadLine());
            // }            

            // Array.Sort(num);

            // for (cont = 2; cont >= 0; cont--) 
            // {
            //     Console.Write("\n");                
            //     Console.Write(num[cont2]);
            //     cont2++;
            // }  

           
            // Leia 10 elementos e armazene em um array A. Em seguida, solicite pelo teclado um
            // número qualquer e pesquise no array se o número existe. Caso, seja verdade imprima a
            // mensagem: “O número existe no array” , caso contrário “Número inexistente”.
            
            //     int[] num = new int[10];
            //     int num2;
            //     int i = 0;
            //     int n = 0;

            //    for (i = 0; i <= 9; i++)
            //    {
            //        System.Console.WriteLine("Informe um número: ");
            //         var result = int.Parse(Console.ReadLine());

            //         num[i] = result;
            //    }
            //    System.Console.WriteLine("Informe o número que deseja procurar no vetor: ");
            //    num2 = Int32.Parse(Console.ReadLine());

            //         for (i = 0; i <= 9; i++)
            // 
                    
            //             if(num2==num[i])
            //             {
            //                 System.Console.WriteLine("O número existe no array! ");
            //                 n++;
            //                 break;
            //             }
            //         }  
            //         if(n == 0)
            //         {
            //             System.Console.WriteLine("Número inexistente");
            //         }  
                        
            // Leia dois arrays A e B com 15 elementos. Construir um array C, onde cada elemento de C
            // é a subtração do elemento correspondente de A com B.

            // int[] a = new int[15];
            // int[] b = new int[15];
            // int[] c = new int[15];
            // int i = 0;

            // for (i = 0; i < 15; i++)
            // {
            //     System.Console.WriteLine("Informe um número (Array A): ");
            //     var result = Int32.Parse((Console.ReadLine()));

            //     a[i] = result;
            // }
            // for(i = 0; i < 15; i++)
            // {
            //     System.Console.WriteLine("Informe um número (Array B)");
            //     var result2 = Int32.Parse(Console.ReadLine()); 

            //     b[i] = result2;
            // }
            // System.Console.WriteLine("O resultado da subtração de A e B é: "); 
            // for (i = 0; i < 15; i++)
            // {
            //     c[i] = a[i] - b[i]; 

            //     System.Console.WriteLine($"{a[i]} - {b[i]} = {c[i]}");
            // }


            //     }
            //Leia dois arrays A e B com 10 elementos. Em seguida, compare os arrays e verifique se 
            // os mesmos são iguais ou diferentes.

            // int[] a = new int[10];
            // int[] b = new int[10];
            // int n = 0;

            // for (int i = 0; i < 10; i++)
            // {
            //     System.Console.WriteLine("Informe um valor para A: ");
            //     var result = Int32.Parse(Console.ReadLine());

            //     a[i] = result;
            // }
            // for (int i = 0; i < 10; i++)
            // {
            //     System.Console.WriteLine("Informe um valor para B: ");
            //     var result2 = Int32.Parse(Console.ReadLine());

            //     b[i] = result2;
            // }
            // for (int i = 0; i < 10; i++)
            // {
            //     if (a[i] != b[i])
            //     {
            //         n++;
            //     }

            // }
            //     if(n > 0)
            //     {
            //         System.Console.WriteLine("Os arrays são diferentes");
            //     }
            //     else
            //     {
            //         System.Console.WriteLine("Os arrays são iguais");
            //     }

            // Terminar exercícios 5 e 6 da lista 2
    
        }
    } 
}