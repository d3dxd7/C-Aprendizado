using System;

class Aula16{
    static void Main(){                   //GOTWO MODO DE FALAR!
        Console.WriteLine("Aula 16 Comando GOTO /n");

        inicio: // Isso e Um Label
        string a = "Aviao";
        string c = "Carro";
        string o = "Onibus";
        char escolha; // A , C , O
        int tempo = 0;
        int horas=0;

        
        Console.Clear();

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

        teclaDiferente://Diferente de 'N' volta a Perguntar Sair Ou Nao Sair Programa
        Console.Write("Deseja Escolher Outro Transporte Ou Nao [s]=Sim, [n]Nao: ");
        escolha =char.Parse(Console.ReadLine());
        if (escolha=='s' || escolha== 'S'){
            goto inicio;//Volta la para Inicio do Programa
        }else{
            if(escolha == 'n' || escolha == 'N'){
                Console.WriteLine("Fim Programa!");
            }else{
                Console.WriteLine("Voce Digitou Diferente de N");
                goto teclaDiferente;//Retorna na Pergunta
            }
            
        }
    }
}