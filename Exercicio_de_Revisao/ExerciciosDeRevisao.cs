namespace Fundamentos;

public class AlunoExercicioRevisao
{
 
  public void ExecutarExercicioRevisao()
  {
    Console.WriteLine("\n📘 EXERCÍCIOS GERAIS DE REVISÃO");
    Console.WriteLine("====================\n");
 
    // ===================================================
    // EXERCÍCIO 1: Verificar número positivo
    // ===================================================
    // 👉 O QUE FAZER:
    // Criar uma variável número
    // Usar IF para verificar se é positivo ou negativo
    // Mostrar o resultado
 
    Console.WriteLine("📝 Exercício 1");
    Console.WriteLine("--------------------\n");
 
    int numero = -5;
    //escolher o número com variável "int"
    Console.WriteLine($"O número escolhido é {numero}");
    //"if" se o número for maior que "0", "else if" se for menor que "0" e "else" se for igual a "0"
    if (numero > 0)
        {
            Console.WriteLine("É um número Positivo");
        }
    else if (numero < 0)
        {
            Console.WriteLine("É um número Negativo");
        }
    else
        {
            Console.WriteLine("Zero");
        }
    Console.WriteLine("--------------------\n");
    //SAIDA
 
    /**� Exercício 1
     Número negativo ou zero*/
 
 
    // ===================================================
    // EXERCÍCIO 2: Maior de dois números
    // ===================================================
    // 👉 O QUE FAZER:
    // Criar duas variáveis
    // Usar operador de comparação
    // Mostrar qual é maior
 
    Console.WriteLine("📝 Exercício 2");
    Console.WriteLine("--------------------\n");

    int numero1 = 10;
    int numero2 = 7;
    //escolher número 1 e 2
    Console.WriteLine($"Qual dos números é maior entre 10 e 7?");
    //"if" se numero1 for maior que numero2
    if (numero1 > numero2)
        {//saída
            Console.WriteLine($"O número {numero1} é maior que o número {numero2}");
        }
    //"else if" se numero1 for menor que numero2   
    else if (numero1 < numero2)
        {//saída
            Console.WriteLine($"O número {numero1} é menor que o número {numero2}");
        }
        else
        {
            Console.WriteLine($"Os números são iguais");
        }

    Console.WriteLine("--------------------\n");

    //SAIDA
 
    /**� Exercício 2
    10 é maior que 7*/
 
    // ===================================================
    // EXERCÍCIO 3: Sistema de desconto (operador ternário)
    // ===================================================
    // 👉 O QUE FAZER:
    // Se o valor da compra for maior que 100
    // aplicar desconto de 10%
    // Usar operador ternário
 
    Console.WriteLine("📝 Exercício 3");
    Console.WriteLine("--------------------\n");

    //criar variável int para valor da compra e para valor do desconto
    int valorCompra = 120;
    
    int valorDesconto = (valorCompra > 100) ? valorCompra / 10 : 0;
    //se o valor da compra for maior que 100, desconto de 10%, senão 0
    // "?" se condição for verdadeira, ":" se condição for falsa

    Console.WriteLine($"O valor da compra é: {valorCompra}");
    Console.WriteLine($"O valor do desconto é: {valorDesconto}");  

    Console.WriteLine("--------------------\n");

    //SAIDA
    /**� Exercício 3
     Desconto: 12*/
 
    // ===================================================
    // EXERCÍCIO 4: Classificação de idade
    // ===================================================
    // 👉 O QUE FAZER:
    // Criar variável idade
    // Usar IF/ELSE IF/ELSE:
    // < 12 → Criança
    // < 18 → Adolescente
    // >= 18 → Adulto
 
    Console.WriteLine("📝 Exercício 4");
    Console.WriteLine("--------------------\n");

    int idade = 14;
    Console.WriteLine($"Idade: {idade}");
    if (idade >= 18)
        {// adulto se idade maior que 18
            Console.WriteLine($"Adulto");
        }
    else if (idade < 12)
        {// criança se menor que 12
            Console.WriteLine($"Criança");
        }
    else
        {// adolescente se nenhuma das anteriores
            Console.WriteLine($"Adolescente");
        }// ***DUVIDA: como fazer "else if" para a variável "idade" estar entre 12 e 18????***
    Console.WriteLine("--------------------\n");

    //SAIDA
    /**� Exercício 4
    Adolescente*/
 
    // ===================================================
    // EXERCÍCIO 5: Menu com SWITCH
    // ===================================================
    // 👉 O QUE FAZER:
    // Criar variável opção (int)
    // Usar SWITCH:
    // 1 → "Novo jogo"
    // 2 → "Carregar jogo"
    // 3 → "Sair"
 
    Console.WriteLine("📝 Exercício 5");
    Console.WriteLine("--------------------\n");

    Console.WriteLine("Novo Jogo");
    Console.WriteLine("Carregar Jogo");
    Console.WriteLine("Sair");
    int opcao = 2;
    Console.WriteLine($"Opção escolhida: {opcao}");

    switch (opcao)
        {
            case 1:
                Console.WriteLine("Novo Jogo");
                break;
            case 2:
                Console.WriteLine("Carregar Jogo");
                break;
            case 3:
                Console.WriteLine("Sair");
                break;
            default:
                Console.WriteLine("Opção Inválida");
                break;
        }
    Console.WriteLine("--------------------\n");

    //SAIDA
    /**� Exercício 5
    Carregar jogo*/
 
    // ===================================================
    // EXERCÍCIO 6: Validação de acesso
    // ===================================================
    // 👉 O QUE FAZER:
    // Criar:
    // idade >= 18
    // temConvite = true/false
    // Usar operadores lógicos
    // Mostrar se pode entrar
 
    Console.WriteLine("📝 Exercício 6");
    Console.WriteLine("--------------------\n");
    
    int idade2 = 20;
    
    bool temIdade = idade2 >= 18;
    bool temConvite = true;
    bool podeEntrar = temConvite && temIdade;
    
    Console.WriteLine($"Tem idade?: {temIdade}");
    Console.WriteLine($"Tem convite?: {temConvite}");
    Console.WriteLine($"Pode entrar?: {temConvite && temIdade}");
    //posso usar tanto a variável bool que junta o "tem convite" com o "tem idade" como aplicar diretamente "tem convite && tem idade" no "writeline"
    

    //SAIDA
    /**� Exercício 6
    pode entrar? True*/
  }
 
}
 