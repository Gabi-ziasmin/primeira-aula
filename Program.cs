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

            // 15)Ler 10 números e imprimir quantos são múltiplos de 3 e quantos são múltiplos de 5.

            // int num;
            // var cont = 0;
            // var cont3 = 0;
            // var cont5 = 0;

            // while(cont < 10)
            // {
            //     num = 0;

            //     System.Console.WriteLine("Informe um número");  
            //     num = Int32.Parse(Console.ReadLine());

            //     if (num % 3 == 0 || 3 % num == 0)
            //     {
            //         cont3++;
            //     }
            //     if (num % 5 == 0 || 5 % num == 0)
            //     {
            //         cont5++;
            //     }
            //     cont++;
            // }
            // System.Console.WriteLine($"{cont3} números são múltiplos de 3");

            // System.Console.WriteLine($"{cont5} números são múltiplos de 5");

// Ler o salário de uma pessoa e imprimir o Salário Líquido de acordo com a redução do imposto descrito ao lado:
// Menor ou igual a R$ 600,00 - ISENTO
// Maior que R$ 600,00 e menor ou igual a 100 - 20% desconto
// Maior que R$ 1.200,00 e menor ou igual a R$2000 - 25% desconto
// Maior que R$ 2.000,00 - 30% desconto

// double salario;
// double SL;
// double conta;

// System.Console.WriteLine("Informe qual é o seu salário");   
// salario  = Int32.Parse(Console.ReadLine());

// if(salario <= 600.00)
// {
//     conta = 0;
//     SL = salario - conta;
//     System.Console.WriteLine($"Seu salário líquido será de {SL}");
// }
// else if(salario > 600.00 && salario <= 100)
// {
//     conta = (salario*20)/100;
//     SL = salario - conta;
//     System.Console.WriteLine($"Seu salário líquido será de {SL}");
// }
// else if(salario > 1200.00 && salario <= 2000)
// {
//     conta = (salario*25)/100;
//     SL = salario - conta;
//     System.Console.WriteLine($"Seu salário líquido será de {SL}");
// }
// else if(salario > 2000)
// {
//     conta = (salario*30)/100;
//     SL = salario - conta;
//     System.Console.WriteLine($"Seu salário líquido será de {SL}");
// }
//As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem
// compradas pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e
// escreva o custo total da compra.

// double maca = 0;
// double result = 0;

// System.Console.WriteLine("Quantas maçãs você quer comprar ?");
// maca = Int32.Parse(Console.ReadLine());

// if(maca < 12)
// {
//     result = maca * 1.30;
// }
// else if(maca >= 12)
// {
//     result = maca * 1.00;
// }

// System.Console.WriteLine($"O resultado da sua compra deu R${result.ToString("0.00")}");

// Calcular a quantidade de dinheiro gasta por um fumante. Dados: o numero de anos que
// ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.

// int anos;
// int cig_dia;
// double preco;
// int total_anos;
// int total_cig;
// double total_preco;
// double total_gasto;

// System.Console.WriteLine("Informe a quantos anos você fuma? ");
// anos = Int32.Parse(Console.ReadLine());

// System.Console.WriteLine("Informe o número de cigarros que você fuma por dia? ");
// cig_dia = Int32.Parse(Console.ReadLine());

// System.Console.WriteLine("Informe o preço da carteira? ");
// preco = double.Parse(Console.ReadLine());

// total_anos = anos * 365;
// total_cig = cig_dia * total_anos;
// total_preco = preco / 20;

// total_gasto = total_cig * total_preco;

// System.Console.WriteLine($"O total gasto com cigarros é de R${total_gasto.ToString("0.00")}");

// Ler 4 números inteiros e calcular a soma dos que forem par.

// !!!!!!14)Ler três valores e colocá-los em ordem!!!!!!
// SÓ FALTA ESSA

        }
    }
}