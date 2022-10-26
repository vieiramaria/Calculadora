using System;

class Calculadora{

    static void Main(){
        Menu();
    }

    public static void Menu()
    {
        Console.WriteLine("------------------------------");
        Console.WriteLine("[1] SOMA");
        Console.WriteLine("[2] SUBTRACAO");
        Console.WriteLine("[3] MULTIPLICACAO");
        Console.WriteLine("[4] DIVISÃO");
        Console.WriteLine("[5] RESTO DA DIVISÃO");
        Console.WriteLine("[6] POTENCIAÇÃO");
        Console.WriteLine("[0] SAIR");
        Console.WriteLine("------------------------------");
        
    int escolha = int.Parse(Console.ReadLine());

    switch(escolha){

        case 1:
            Somar();
        break;
        case 2:
            Subtrair();
        break;
        case 3:
            Multiplicar();
        break;
        case 4:
            Dividir();
        break;
        case 5:
            RestoDivisao();
        break;
        case 6:
            Potenciacao();
        break;
        case 0:
            Sair();
        break;
        default:
            Menu();
        break;

    }
}
    public static void Somar()
    {
        int num1,num2,soma;

        Console.WriteLine("Digite um número: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        num2=int.Parse(Console.ReadLine());
        soma=num1 + num2;
        Console.WriteLine("A soma entre {0} e {1} é igual a {2}", num1,num2,soma);
        Menu();
    }

    public static void Subtrair()
    {
        int num1,num2,subtracao;
        Console.WriteLine("Digite um número: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        num2=int.Parse(Console.ReadLine());
        subtracao=num1 - num2;
        Console.WriteLine("A subtração entre {0} e {1} é igual a {2}",num1,num2,subtracao);
        Menu();
    }

     public static void Multiplicar()
     {
        int num1,num2, multiplicacao;

        Console.WriteLine("Digite um número: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite outro número: ");
        num2=int.Parse(Console.ReadLine());
        multiplicacao=num1 * num2;
        Console.WriteLine("A multiplicação entre {0} e {1} é igual a {2}",num1,num2,multiplicacao);
        Menu();
     }
     public static void Dividir()
     {
        int num1,num2, divisao;

        Console.WriteLine("Digite o dividendo: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o divisor: ");
        num2=int.Parse(Console.ReadLine());
        divisao=num1 / num2;
        Console.WriteLine("A divisão entre {0} e {1} é igual a {2}",num1,num2,divisao);
        Menu();
            
    }

    public static void RestoDivisao()
    {   
        int num1,num2,resto;

        Console.WriteLine("Digite o dividendo: ");
        num1=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o divisor: ");
        num2=int.Parse(Console.ReadLine());
        resto=num1 % num2;
        Console.WriteLine("O resto da divisão entre {0} e {1} é igual a {2}",num1,num2,resto);
        Menu();
    }

    public static void Potenciacao()
    {
        double basePotenciacao, expoente, resultado;

        Console.WriteLine("Digite a base: ");
        basePotenciacao=int.Parse(Console.ReadLine());
        Console.WriteLine("Digite o expoente: ");
        expoente=int.Parse(Console.ReadLine());
        resultado=(Math.Pow(basePotenciacao,expoente));
        Console.WriteLine("O número {0} elevado ao número {1} é igual a {2}", basePotenciacao,expoente,resultado);
        Menu();
    }

    public static void Sair()
    {
        Console.WriteLine("Fim do programa!!!");
    }

}
            

    




