using System;

class Aula06{

    static void Main(){
        Console.WriteLine("Aula 06 Formatando Saida no Console");
        //Acessando Indice 

        int n1=10, n2=20, n3=30; // \n E para quebrar Linha
        Console.WriteLine("\n Quebra Linha");
        Console.WriteLine("\n n1={0}\n n2={1}\n n3={2} \n",n1,n2,n3);
        // Da para usar \t que e uma Tabulacao ele da Espaco 
        //Exemplos
        Console.WriteLine("\n Tabulacao ou Espaco Entre Resultado");
        Console.WriteLine("\n n1={0}\t n2={1}\t n3={2} \n",n1,n2,n3);

        //Variavel Double e Variavel de Ponto Flutuante de 8bits
        double valorCompra = 5.50;// Valor Produto
        double valorVenda;
        double valorLucro=0.2; //% quer ganhar encima do PRODUTO
        string Produto = "Pastel de Frango";

       //Venda Recebe Valor de Compra e valor de compra x valor lucro
       valorVenda = valorCompra + (valorCompra*valorLucro);
        
        
        //Indice, 15 o valor de 15 significa tamanho do espaco
        Console.WriteLine("Produto.......:{0,15}", Produto);
        
        //Indice, 15:c O :c significa formato Monetario ou seja em Dinheiro
        Console.WriteLine("Val.Compra.......:{0,15:c}", valorCompra);//Tras valorCompra
        
        //Indice, 15:p O :p significa valor de porcentagem
        Console.WriteLine("Val.Lucro.......:{0,15:p}", valorLucro);//tras Porcentagem
        
        //Indice, 15:c O :c significa formato Monetario ou seja em Dinheiro
        Console.WriteLine("Val.Venda.......:{0,15:c}", valorVenda);//tras valorVenda

        Console.WriteLine("\n Sugestao de Venda.......:{0,15:c}", valorVenda);//Sugere a Venda
        
    }
}