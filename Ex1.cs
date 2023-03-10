using System;
using System.Collections.Generic;
public class Exerc2B
{
    public static void Main()
    {
        int x = 0;
        Console.WriteLine("Insira o numero de convidados: ");
        x = Convert.ToInt32(Console.ReadLine());

        string[] convidados = new string[x];
        int i = 0;
        int a = 0;

        do
        {
            Console.WriteLine("Insira o nome do convidado: ");
            convidados[i] = Convert.ToString(Console.ReadLine());
            i++;
        } while (i < convidados.Length);

        Console.WriteLine("Lista de convidados: ");
        do
        {
            Console.WriteLine(convidados[a]);
            a++;
        } while (a < convidados.Length);


    }
}