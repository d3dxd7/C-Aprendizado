using System;

class Aula17{
    static void Main(){
        Console.WriteLine("Aula 17 Array / Vetor");

        //int n1,n2,n3,n4,n5;
        int[]/*Array Tipo Inteiro*/ n=new int[5]; // Cria Vetor que Cabe 5 Elementos
        //n=new e Array int[5] e Quantidade Elementos sendo primeiro na Posicao 0-4 = Array 5 POSICIOES
        // n=new o 'N' vai ser o Array Exemplo  N + Indice = Valor que Recebe
        
        //Exemplo
        /*
        int[] <- Abre Array
        int[] n=new <- Nomeia o Array (NEW = OPERADOR)
        int[] n=new int[5] <- Abre Array Apelida ele e Determina Tamanho do Array exemplo foi int[5]
        vai ter dentro deste Array Exemplo acima sao 5
        para Acessar e colocar valores nesse Array apenas chama 
        Variavel que representa o Array que e 'N' coloque o Indice
        e Atribua o valor a quele Array do Indice que indicar
        */

        //Array Vazio 
        //Adicionar Valor dentro do Array Vazio

        n[0]=11; // Adiciona valor 111 Indice 0
        n[1]=22;
        n[2]=33;
        n[3]=44;
        n[4]=55;
        //Imprimir Resultado do Array
        Console.WriteLine(n[0]);

        //Exemplo de Array String
    //   Tipo      Operador   atribuicao/inicializacao
        string[] veiculos=new string[3];
        veiculos[0]="Carro";
        veiculos[0]="Aviao";
        veiculos[0]="Navios";


        //Outro Array ja Indicando valores na Criancao do mesmo!
        int[] num=new int[3]{55,77,99};
        //                   0  1   2 = 3 Indices Use um dos Para acessar Valores
        Console.WriteLine(num[1]);//num[0] ou num[1] ou num[2]

        //Outro Array Tamanho do Array Definido Automaticamente pelo quantidade de Indices ou Seja Numero,Numero,Numero
        int[] numero={10,20,30};
        Console.WriteLine(numero[0]);

        //Para Iniciar um Array
        // Exemplo Tipo, Operador, Tamanho ou Direto
        /*
        int[] <- Tipo 
        operador=new 
        int[5]<- Tamanho ()Qtd Indice

        fica assim
        int[] teste=new int[10]
        ou
        int[] teste{1,2,3,4,5,6,7}
        ou
        int[] teste=new int[3]{1,2,3}


        //Exemplo de Array String
    //   Tipo      Operador   atribuicao/inicializacao
        string[] veiculos=new string[3];
        veiculos[0]="Carro";
        veiculos[0]="Aviao";
        veiculos[0]="Navios";

        */

    }
}