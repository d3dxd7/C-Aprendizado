using System;

class Aula11{
    static void Main(){
        Console.WriteLine("Aula 11 Conversoes de tipos TypeCast\n");
        int n1=10;
        float n2=n1; // Cast de forma Segura Int para Float
        Console.WriteLine(n2); //Resultado Int (Operacao Implicita Ou seja Segura!)


    // Fazendo Cast Oposto Float para Int Precisa de TypeCast
        float n3 = 5.50f;
    //Atribuir o Novo valor que Vai Receber antes de Chamar variavel
        int n4 = (int)n3; // Maneira Exata! de Cast
        Console.WriteLine(n4); // Resultado Float(Operacao Implicita Ou seja Segura!)

        int vInt= 10;
        long vLong = vInt;
        Console.WriteLine(vLong); // Resultado Int(Operacao Implicita Ou seja Segura!)

    
    //Nao Implicita (nao vai Compilar)
        int vInt1 = 10;
        short vShort =(short)vInt1; // Funcional

        //short vShort = vInt1;  <- Nao Compila Precisa fazer Cast
        //Para funcionar fazer TypeCast
        //Exemplos
        //short vShort = (short)vInt1; TypeCast Int Para Short
        //short vShort = (short)vInt1; TypeCast float Para short
        Console.WriteLine(vShort);// Operacao nao Implicita Sem Seguranca e nao vai Compilar

    }
}