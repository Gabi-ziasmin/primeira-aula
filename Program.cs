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
            
            // var contador = 1;
           
            // while(contador < 200)
            // {
            //     if(contador % 2 > 0 ) 
            //     {
            //         System.Console.WriteLine(contador);
            //     }
            //     contador = contador + 1;
            // }

            //4)Calcular a média de idade de uma turma qualquer. O algoritmo deve parar quando for digitada a idade igual a zero.

            // var  cont = 0.0;
            // var sum = 0.0;
        
            // while(true)
            // {
            //     System.Console.WriteLine("Digite uma idade: ");
            //     var result = Console.ReadLine();
                
            //     if(result == "0")
            //     {
            //         break;
            //     }

            //     cont = cont + 1;
                
            //     sum += Int32.Parse(result);
                
            // }
            // System.Console.WriteLine($"A média da turma é: {sum / cont}"); 
            // System.Console.WriteLine(String.Format("{0:0.00}",sum / cont));   

//             5)Criar um algoritmo que peça o nome e a idade de 5 mulheres. Após informar estes dados,
// o programa deve mostrar apenas porcentagem de mulheres que estão com idade entre 18 e
// 35.     

            // var cont = 0;
            // var idadeMulheres = 0;

            // while(cont < 5)
            // {
            //     System.Console.WriteLine("Informe o seu nome: " );
            //     var result = Console.ReadLine();

            //     System.Console.WriteLine("Informe a sua idade: ");
            //     var age = Int32.Parse(Console.ReadLine());

            //     if(age > 17 && age < 36)
            //     {
            //         idadeMulheres++;
            //     }
            //      cont++;
            // }

            // System.Console.WriteLine($"A porcentagem de mulheres com idade entre 18 e 35 é: {idadeMulheres * 100 / cont}%");
            

        //    string candidato1;
        //    string candidato2;
        //    var c1 = 0;
        //    var c2 = 0;
        //    string voto;
        //    string sair;
           
           
        //    System.Console.WriteLine("Informe o nome do Primeiro candidato: ");
        //    candidato1 = System.Console.ReadLine();
        //    System.Console.WriteLine("Cadastre a senha: ");
        //    var senha1 = Int32.Parse(Console.ReadLine());

            
        //    System.Console.WriteLine("Informe o nome do Segundo candidato: ");
        //    candidato2 = System.Console.ReadLine();
        //    System.Console.WriteLine("Cadastre a senha: ");
        //    var senha2 = Int32.Parse(Console.ReadLine());

         
        //    do
        //    {
        //        System.Console.WriteLine("Em qual candidato deseja votar?");
        //        System.Console.WriteLine($"1 = {candidato1}");
        //        System.Console.WriteLine($"2 = {candidato2}");
        //        voto = System.Console.ReadLine();

        //        if(voto == "1")
        //        {
        //            c1++;
        //        }
        //        else
        //        {
        //            c2++;
        //        }

        //     System.Console.WriteLine("Deseja continuar ? (s/n)");
        //     sair = System.Console.ReadLine();
        //    } while (sair == "s" || sair == "S");

        //    System.Console.WriteLine("-----!APURAÇÃO!-----");

        //    if(c1 > c2)
        //    {
        //        System.Console.WriteLine($"O(a) candidato(a) {candidato1} teve a maior quantidade de votos!");
        //        System.Console.WriteLine($"Votos = {c1}");
        //    }
        //    else if(c2 > c1)
        //    {
        //        System.Console.WriteLine($"O(a) candidato(a) {candidato2} teve a maior quantidade de votos!");
        //        System.Console.WriteLine($"Votos = {c1}");
        //    }
        //    else
        //    {
        //        System.Console.WriteLine("---SEGUNDO TURNO---");
        //    }

        // 7)Calcular a quantidade de dinheiro gasta por um fumante. Dados: o numero de anos que
        // ele fuma, o nº de cigarros fumados por dia e o preço de uma carteira.

        int anos;
        int numdia;
        Double preco = 0;

        System.Console.WriteLine("Você fuma a quantos anos? ");
        anos = Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Quantos cigarros você fuma por dia? ");
        numdia = Int32.Parse(Console.ReadLine());

        System.Console.WriteLine("Qual o valor da carteira de cigarro? ");
        preco = Double.Parse(Console.ReadLine());

        //Precisa ser realizada a conta!!!

      
        }
    }
}