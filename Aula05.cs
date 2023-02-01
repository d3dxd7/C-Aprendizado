using System;

class Aula05{

    static void Main(){
        Console.WriteLine("Aula 05 Operadores e Operacoes");
        int res=10+5;
        Console.WriteLine("Soma do Resultado de 10+5 e = "+res);

        int resultado=(10+5)*2;
        Console.WriteLine("Resultado de 10+5x2 e ="+ resultado);

        //Valores Relacionais Booleans
        bool relacional = 10<5; // False 10 menor que 5
        //Console.WriteLine("10 e Menor que 5 = "+ relacional);
        if (relacional == true)
        {
            Console.WriteLine("Valores Verdadeiros");
        }else{
            Console.WriteLine("Valores Falses");
        }

        //Valor de Incremente e Decremento
        int numero=10;
        numero+=1; // era 10 virou 11 numero + numero = 1
        //numero*=2; //aqui e 10x2 numero x 2
        Console.WriteLine("Era 10 virou = "+ numero+" Valor de Incremente e Decremento");

        //Operadores Logicos  AND OR NOT 
        // & =AND 2 Operacoes Precisa ser TRUE
        // | = OR 1 das Operacoes precisa ser TRUE

        //Exemplos de uso do | = OR
        bool testeNumOR = (10<5) | (25>5); // True Uma das Operacoes foi Corretas
        if (testeNumOR)
        {
            Console.WriteLine("10 nao e menor que 5 Porem 25 e maior que Cinco Operacao "+testeNumOR);
        }else{
            Console.WriteLine("10 e maior que 5 e 25 e maior que Cinco Operacao "+testeNumOR);
        }

        //Exemplos do uso do & = AND
        bool testeNumAND = (10>5) & (25>5); // True as 2 Operacoes esta Corretas
        if (testeNumAND)
        {
            Console.WriteLine("10 e Menor que Cinco e 25 e maior que 5 "+testeNumAND);
        }else{
            Console.WriteLine("10 e Menor que Cinco e 25 e Menor que 5"+ testeNumAND);
        }


    }
}