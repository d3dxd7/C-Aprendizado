using System;

class Aula08{
    static void Main(){
        Console.WriteLine("Aula 08 Lendo Valores do Teclado \n");

        int v1,v2,soma;
        string nome;

        Console.WriteLine("Digite seu Nome: ");
        nome=Console.ReadLine(); // Captando valores digitados Inserindo na variavel
        Console.WriteLine("Nome Digitado {0} ",nome);

        //Para Fazer Troca de Valores para Int

        Console.WriteLine("Digite o Primeiro valor: ");
        v1 = int.Parse(Console.ReadLine());// Faz Cast de string para Int (INT.PARSE)
       
        Console.WriteLine("Digite o Segundo valor: ");
        v2 = Convert.ToInt32(Console.ReadLine());// Convert.ToInt32 Converte para inteiro de tamanho de Numero para 32
        
        soma = v1 + v2;
        Console.WriteLine("A Soma do Valor 1 com Valor 2 e {0}", soma);
    }
}