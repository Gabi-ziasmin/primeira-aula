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

        // Ler três valores e colocá-los em ordem

        var num = new int[3];
        var cont = 0;
        int pri;
        int seg;
        int terc;
        int result = 0;

        while(cont < 3)
        {
            var maior = result;

            System.Console.WriteLine("Digite um número: ");
            result = Int32.Parse(Console.ReadLine());

            num[cont] = result;


        }

        }
    }
}