using System;
public class Exercicio1
{
    public static void Main()
    {
        int convidadosNoivo = 300;
        int convidadosNoiva = 600;
        int convidadosPresentesNoivo = 400;
        int convidadosPresentesNoiva = 400;


        if (convidadosNoivo > convidadosNoiva)
        {
            Console.WriteLine("O numero de convidados da noivo e menor que do noiva");

        }
        else if (convidadosNoiva > convidadosNoivo)
        {
            Console.WriteLine("O numero de convidados da noiva e maior que do noivo");
        }
        else if (convidadosNoiva == convidadosNoivo)
        {
            Console.WriteLine("O numero de convidados da noiva e igual do noivo");
        }
        
        if (convidadosNoiva != convidadosNoivo)
        {
            Console.WriteLine("O numero de convidados da noiva é diferente do numero de convidados do noivo");
        }


        if (convidadosPresentesNoivo > convidadosNoivo)
        {
            Console.WriteLine("Existem penetras pois o numero convidados presentes é maior que o numero de convidados do noivo.");
        }
        else if (convidadosPresentesNoiva > convidadosNoiva)
        {
            Console.WriteLine("Existem penetras pois o numero convidados presentes é maior que o numero de convidados do noiva.");
        }

    }

};