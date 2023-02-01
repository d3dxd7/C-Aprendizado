using System;

class Aula15{
    static void Main(){
        //SWITCH case E USADO POR EXEMPLO PARA CHECKBOX EM SISTEMA
        //QUAL CHECKBOX ESCOLHER PARA FAZER ALGO E ENTREGAR PARA USUARIO

        Console.WriteLine("Aula 15 SWITCH case /n");
        string a = "Aviao";
        string c = "Carro";
        string o = "Onibus";
        char escolha; // A , C , O
        int tempo = 0;
        int horas=0;
        Console.WriteLine("Belo Horizonte/MG a Vitoria/ES");
        Console.WriteLine("Escolha O Transporte:[a]{0} | [c]{1} | [o]{2}",a, c, o);
        escolha = char.Parse(Console.ReadLine());

        switch(escolha){ // SWITCH COLOCA VALOR QUE QUER TESTAR
            case 'a'://Os Testes (Caso o Valor de Escolha Seja Igual A??)
            case 'A': // Minusculo ou maiusculo Sera mesma coisa
                tempo = 720; //720min
                horas = tempo / 60;
                break;
            case 'c'://Carro
            case 'C':// Minusculo ou maiusculo Sera mesma coisa
                tempo = 1440; // 1440min
                horas = tempo / 60;
                break;
            case 'o'://Onibus
            case 'O':// Minusculo ou maiusculo Sera mesma coisa
                tempo = 2880; // 2880min
                horas = tempo / 60;
                break;
            default: // Caso Nenhuma acima Cai aqui
                tempo = -1; //-1 para flag de tempo Indefinido
                break;
        }
        
        if (tempo < 0){
            Console.WriteLine("Transporte Indisponivel");
        }else{
            Console.WriteLine("Tempo para o Transporte Escolhido: {0}Minutos = {1}Horas", tempo, horas);
        }

    }   
}