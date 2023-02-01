using System;

class Aula12{
    static void Main(){
        Console.WriteLine("Aula 12 Condicional IF \n");
        //Exemplo de Nota com IF 
        int nota = 0;
        string resultado = "Reprovado";

        Console.WriteLine("Digite a Nota final");
        nota = int.Parse(Console.ReadLine());

        if(nota >= 40){
            resultado = "Aprovado";
        }


        Console.WriteLine("Resultado {0} ",resultado);

        // Ler mais de uma Nota Primeiro ate Quarto Bimestre
        int n1, n2, n3, n4, res;
        res=n1=n2=n3=n4 = 0;
        string apuracaoFinal = "Reprovado";

        Console.WriteLine("Digite a Nota do Primeiro Bimestre");  
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota do Segundo Bimestre");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota do Terceiro Bimestre");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota do Quarto Bimestre");
        n4 = int.Parse(Console.ReadLine());

        res = n1 + n2 + n3 + n4;
        if(res >= 20){
            apuracaoFinal = "Aprovado";
        }

        Console.WriteLine("Aluno foi {0} Media Final = {1}",apuracaoFinal, res);
    }    
}
