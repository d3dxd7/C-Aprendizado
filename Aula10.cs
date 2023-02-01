using System;

class Aula10{

    //Variavel Global
    //Valor do Enumerador Sempre dentro da Chave
    enum DiasDaSemana{Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado};
    //Indices          0    1    2    3     4     5     6
    static void Main(){
        Console.WriteLine("Aula 10 Enumerate(Enumeradores ou enum)");

    //Variaveis Recebendo valor do Enumerate
        DiasDaSemana DiaUmNome = DiasDaSemana.Domingo;
        Console.WriteLine(DiaUmNome);
    //Console.WriteLine vai exibir Domingo Acesso Pelo Nome Dom
    //Variavel DiaUmNome vai receber valor Domingo

        DiasDaSemana DiaUmIndice = (DiasDaSemana)0;
        Console.WriteLine(DiaUmIndice);
    //Console.WriteLine vai exibir Domingo Acessado Pelo Indice 0
    //Variavel DiaUmIndice vai receber valor Domingo

    //Possibilidade de fazer Ao Contrario

        int DiaUmInt = (int)DiasDaSemana.Sexta;
        Console.WriteLine(DiaUmInt);
    //Variavel DiaUmInt vai receber como valor Indice como Inteiro
    //Console.WriteLine vai exibir o Indice de Sexta como Numero Inteiro
    }
}