using System;

class Aula04
{
    //Varaival Global Para chamar em qualquer Metodo Void
    static int num=50; // Essa Variavel e Global
    static void Main()
    {
        Console.WriteLine("Aula 04 Escopo de Variaveis");
        //Para mostrar variavel global dentro de um metodo
        //Static a variavel Global precisa ter Static tambem
        //Exemplo
        Console.WriteLine("Variavel Global = "+num);

        //Variavel Local
        int num1 = 0; 
        Console.WriteLine("Variavel Local = "+ num1);
        // Essa Variavel so pode ser usada dentro Deste metodo

    }
}