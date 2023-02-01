using System;

class praticando{
    static void Main(){
        Console.WriteLine("Praticando ate Aula 08");

        Double compra=0; 
        Double venda=0; 
        Double lucro=0; 
        Double sugestao = venda;
        string nome;

        
        //Iniciando
        Console.WriteLine("Digite Nome do Produto....: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite Margem de Lucro....: Exemplo 0,1 = 1%");
        lucro = Double.Parse(Console.ReadLine());

        Console.WriteLine("Digite Valor de Compra....:Exemploe 2,50");
        compra = Double.Parse(Console.ReadLine());

        //Console.WriteLine("Porcentagem do Lucro vai ser {0,15:p}",lucro);
        
        venda = compra + (compra*lucro);

        Console.WriteLine("Sugestao de Venda \nValor Unitario \n{1} {0,5:c}", venda, nome);

    }

}