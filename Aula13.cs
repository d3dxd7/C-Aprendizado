using System;

class Aula13{
    static void Main(){
        Console.WriteLine("Aula 13 IF - ELSE");
        //Exemplo de Nota com IF - ELSE
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
        string apuracaoFinal;

        Console.WriteLine("Digite a Nota do Primeiro Bimestre");  
        n1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota do Segundo Bimestre");
        n2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota do Terceiro Bimestre");
        n3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a Nota do Quarto Bimestre");
        n4 = int.Parse(Console.ReadLine());


        /*
        Aprovado >= 25  
        Recuperacao >= 19
        Reprovado <= 18
        */
        res = n1 + n2 + n3 + n4;
        if (res <= 18){
            apuracaoFinal = "Reprovado";
        }else if(res >= 18 & res <= 23){
            apuracaoFinal = "de Recuperacao";
        }else{
            apuracaoFinal = "Aprovado";
        }

        Console.WriteLine("Aluno esta {0} Media Final = {1}",apuracaoFinal, res);
    }    
}
