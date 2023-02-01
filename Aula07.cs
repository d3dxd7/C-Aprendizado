using System;


class Aula07{
    static void Main(){
        Console.WriteLine("Aula 07 SOBRE Constantes\n");
        //Diferenca de variavel e constante
        //Constante nao e possivel trocar valor ja variavel sim

        const string testeConstString = "Lucas Matheus";
        const double pi=3.1415;
        Console.WriteLine("Teste de Const: {0}\nValor de Pi: {1}", testeConstString,pi);
        
    }
}