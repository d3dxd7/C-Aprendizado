using System;
// Aula de Variavel
class Aula03{
    static void Main(string[] args){
        //Valores Primitivos
        int Variavel_inteiro = 1; // Padrao Int
        char letra='c'; // Padrao Chgar 1 Caracter
        float Variavel_flutuante = 1.0f; //Padrao Float
        //Tipo Referencia
        string nome="string onde coloca testo maior"; //Varios Caracteres
        
        var aux=Variavel_flutuante;//Nao especifica tipo da variavel usando VAR
        var aux1="teste";//Entende Automtatico quando compilado

        //Console.WriteLine(aux);
        //Console.WriteLine(aux1+" "+nome);
        int num1, num2, num3, res; //Estas Variaveis Serao todas INT

        num1 = 1;
        num2 = 2;
        num3 = 3;
        res = num1 * num2; //Res de Resuldo
        Console.WriteLine("Multiplicando {1} x {2} = "+ res);
    }
}