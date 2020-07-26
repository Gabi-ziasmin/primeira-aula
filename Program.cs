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
            
            int[] num = new int[3];
            var cont = 0;
            int num2;
            string continuar = "s";

            while(cont < 3)
            {
                System.Console.WriteLine("Informe um número: ");
                var result = int.Parse(Console.ReadLine());

                num[cont] = result;
                cont++;
            }

            while(continuar != "n")
            {
                System.Console.WriteLine("Informe o número que deseja procurar: ");
                num2 = Int32.Parse(Console.ReadLine()); 

                if(num2 == num[3])
                {
                    System.Console.WriteLine("O número existe no array! ");
                }
                else
                {
                    System.Console.WriteLine("Número inexistente!");
                }
                System.Console.WriteLine("Deseja continuar? (s/n)");
                continuar = Console.ReadLine();
            }
            

        }
    }
}