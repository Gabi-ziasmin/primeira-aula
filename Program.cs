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
            
            var contador = 1;

            while(contador <= 10)
            {
                System.Console.WriteLine(contador);
                contador = contador + 1;
                
            }

           
        }
    }
}