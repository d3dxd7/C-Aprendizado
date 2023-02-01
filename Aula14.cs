using System;

class Aula14{
    static void Main(){
        Console.WriteLine("Aula 14 IF Aninhado");
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
        if (res >= 24){//1 IF
            if (res >= 30){//1.1 IF
                
                if (res >= 99){//1.2 IF
                    apuracaoFinal = "de parabens e um Dotado de Inteligencia";
                }else{//1.2 ELSE
                    apuracaoFinal = "Aprovado Com Sucesso!";
                }

            }else{//1.1 ELSE
                apuracaoFinal = "Aprovado";
            }
                
        }else{//1 ELSE

            if (res >= 19 & res <= 23){//1.3  IF DO IF-ELSE 1
                apuracaoFinal = "de Recuperacao";
            }else{ // 1.3 ELSE DO IF-ELSE 1
                apuracaoFinal = "Reprovado";
            }
        }

        Console.WriteLine("Aluno esta {0} Media Final = {1}",apuracaoFinal, res);
    }    
}
