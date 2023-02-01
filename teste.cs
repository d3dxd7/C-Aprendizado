using System;

class Exercicio{
    static void Main(){
        //Array
        int[]   modelo=new  int[3];
        string[] valor=new string[9];
        string[] carro=new string[3];
        string[] placa=new string[3];
        //Placa
        placa[0]="3B3E58";
        placa[1]="YH45I8";
        placa[2]="55CV56";
        //Carro
        carro[0]="ECO-SPORT";
        carro[1]="PORSHE PANAMERA";
        carro[2]="CAMARO-SS";
        //Modelo
        modelo[0]=2008;
        modelo[1]=2009;
        modelo[2]=2022;
        //Valor Carro
        valor[0]="150.000";
        valor[1]="200.000";
        valor[2]="255.000";
        valor[3]="285.000";
        valor[4]="325.000";
        valor[5]="375.000";
        valor[6]="415.000";
        valor[7]="455.000";
        valor[8]="490.000";

        Console.WriteLine("Seja Bem Vindo Ao Sistema de Carros!");
        Console.WriteLine("Temos Alguns Modelos para Escolha Segue os Modelos Abaixo: ");
        Console.WriteLine("{0} , {1} , {2}",carro[0],carro[1],carro[2]);
        Console.WriteLine("Qual dos Modelos Acima voce Deseja Selecionar 1, 2 ou 3");
        char escolhaCarro = char.Parse(Console.ReadLine());


        Console.WriteLine("Temos para Este Modelo Selecionado Os Anos {0}, {1}, {2}", modelo[0], modelo[1], modelo[2]);
        Console.WriteLine("Qual Ano Voce quer Selecionar 1, 2 ou 3");
        char anoCarro = char.Parse(Console.ReadLine());
        int anoCar=0;
        string preco="";
        string car = "";
        switch(escolhaCarro & anoCarro){
            case '1' & '1': // Eco Sport
                car = "ECO-SPORT";
                anoCar = modelo[0];
                preco = "R$"+valor[1];
                break;
            case '1' & '2':
                car = "ECO-SPORT";
                anoCar = modelo[1];
                preco = "R$"+valor[2];
                break;
             /*   
            case '1' & '3':
                car = "ECO-SPORT";
                anoCar = modelo[2];
                preco = "R$"+valor[3];
                break;*/
            }
        switch(escolhaCarro & anoCarro){
            case '2' & '1': //Porshe Panamera
                car = "PORSHE PANAMERA 2008";
                anoCar = modelo[0];
                preco = valor[6];
                break;

            case '2' & '2':
                car = "PORSHE PANAMERA 2009";
                anoCar = modelo[1];
                preco = valor[7];
                break;
            
            case '2' & '3':
                car = "PORSHE PANAMERA 2022";
                anoCar = modelo[2];
                preco = valor[8];
                break;
             }
        switch(escolhaCarro & anoCarro){
            case '3' & '1': // Camaro - SS 
                car = "CAMARO-SS 2008";
                anoCar = modelo[0];
                preco = valor[4];
                break;

            case '3' & '2':
                car = "CAMARO-SS 2009";
                anoCar = modelo[1];
                preco = valor[5];
                break;
            case '3' & '3':
                car = "CAMARO-SS 2022";
                anoCar = modelo[2];
                preco = valor[6];
                break;
            default:
                anoCar = -1;
                break;
        }

        if (anoCar<0){
           Console.WriteLine("carro e ano invalido"); 
        }else{
            Console.WriteLine("Carro Escolhido {0} e ano {1} valor do Veiculo {2}", car, anoCar, preco);
        }
        
        
    }
}