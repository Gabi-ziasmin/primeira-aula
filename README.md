# Projeto Entra21

### Escrevendo e lendo do console 
    // Escrever 
    Console.WriteLine("Qual é a sua idade?");

    //Ler e salvar resultado
    var result = Console.ReadLine();

### Declarando variáveis e constantes 
    var text = "meu texto";
    string text = "meu texto";
    const string text = "meu texto";


### Tipos básicos
    // Tipo Numérico 
    var number = 1

    //Tipo texto/string
    var text = "meu texto"

    //Tipo booleano/bool
    var boolean = true  

    //Tipo numérico com ponto flutuante/double
    var price = 4.099

    // Tipo DateTime/Data
    var currentDate = DateTime.Now;

### Parsers / Transformadores 
    // Transformar um texto/string em um número/int
    var userAge = Int32.Parse(result); 

    // Transformar um texto/string em um número com ponto flutuante/double
    double price = Double.Parse(result);


### Operadores de comparação 
#### (toda comparação retorna um booleano/bool)
    // È igual?
    1==1;
    //vai retornar true

    // É diferente?
    1 != 1;
    //vai retornar false 
 
    // È diferente?
    !(1 == 1);
    //vai retornar invertido

    // Booleano da esquerda é true e da direita também ?
    true $$ true;
    //vai retornar true

    // Booleano da esquerda ou da direita é true ?
    true || false || true;;
    //vai retornar true

### Operadores de comparação para números 
#### (toda comparação retorna um booleano/bool)
    // É maior?
    1 > 1;
    //vai retornar true

    // É menor?
    1 < 1;
    //vai retornar false 
 
    // È maior OU igual?
    1 >= 1;
    //vai retornar true

    // È menor OU igual?
    1 <= 1;
    //vai retornar true


### Operadores de matematica
#### (toda comparação retorna um booleano/bool)
    // Somar
    1 + 1;

    // Subtrair
    1 - 1;
 
    // Dividir
    1 / 1;
    
    // Multiplicar
    1 * 1;
   
    // Resto
    3 % 2;
    // vai retornar 1

    // Incrementando uma variável 
    var counter = 0;
    var counter++;
    ver counter += 1;
    // caunter terá o valor 2

### Blocos condicionais 
    // escrevendo olá SOMENTE quando 1 > 0
    if (1 > 0)
    {
       Console.WriteLine(OLá);
    }

    // Caso 1 NÂO for maior que 0, e 2 > 1  escreva Boa tarde!
    else if (2 > 1)
    {
     Console.Writeline("Boa tarde!");
    }

    // Caso NENHUMA das condições anteriores não forem verdadeiras escreva 
    Xau!
    else 
    {
     Console.Writeline("Xau!");
    }

### Laços de repetição
    // while
    while (true)
    {
        Console.WriteLine("Olá!");
    }
    // Dirá olá repetidamente

### Comandos do editor
    Selecionando o texto:  
    segurar a tecla shift e utilizar as setas 

    Comando para comentar:  
    CTRL + K + C

    Comando para descomentar:
    CTRL + U

    Comando para desfazer:
    CTRL + Z

    Comando para refazer:
    CTRL + Y

### Depurando a aplicação

    1. CLicar na baratinha e depois no botão de engrenagem;
    2. Selecionar o texto '.Net Core'
    3. Alterar a opção "console" para "integratedTerminal"
    4. Adicionar um brakpoint ou mais(clicar na esquerda do número da linha
    5. Clicar na baratinha e no botão start (verdinho)
    6. Selecionar o terminal (Sair na tab "Debug Console")
    7. F10 vai a para a próxima linha 
    8. F5 para o póximo breakpint 
    9. Shift + F5 para "matar" a aplicação
   10.CTRL + Shift + F5 para reiniciar o debug