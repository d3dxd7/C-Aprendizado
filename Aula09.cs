using System;

class Aula09{
    static void Main(){
        Console.WriteLine("Aula 09 Opcoes de Bitwise << Dobrar  >> Metade");
        int num1=10;
        num1=num1<<1; // Deslocando em 1
        /*
        Exemplo 8bits
        Bit de 10 e 00001010 = 10
        apos Deslocar << por 1 Ele dobra dobro de 10 e 20
        Bit do dobro de 10 vai ser 00010100 = 20
        */
        Console.WriteLine("Valor de Num {0} valor de Bit 00010100", num1);

        int num2 = 28;
        num2=num2>>1;
        /*
        Exemplo 8Bits
        Bit de 28 = 00011100
        se Deslocar para a Direita >> vai ser metade 28 = 14
        Bit da metade 28 vai ser 0001110 = 14 sempre Retira Ultimo BIT
        Sempre que for >> Direta Metade vai tirar Ultimo bit 
        */
        Console.WriteLine("Valor de Num2 {0} Valor de Bit 0001110", num2);


        int num3 = 20;
        num3=num3>>2;
        /*
        Exemplo 8Bits
        Bit de 20 = 00010100 
        Metade de 2 vai ser 2/20 sendo primeiro bit 10 e depois o 5
        Bit 10 = 00001010 (Menos Ultimo Bit de 20 faz Bit de 10)
        Bit 5 = 00000101  (Menos Ultimo Bit de 10 faz Bit de 5)
        */
        Console.WriteLine("Valor de Num3 {0} Valor de Bit 00000101 ", num3);



            /*
            Exemplos de Bits
            << Dobra Operador de Bits
            >> Meta  Operador de Bits
            00011101 - 29
            00011110 - 30
            00011111 - 31
            00100000 - 32
            00100001 - 33
            00100010 - 34
            */
    }
}