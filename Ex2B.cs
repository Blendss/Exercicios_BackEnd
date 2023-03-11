using System;
using System.Collections.Generic;
public class Exerc2B
{
    public static void Main()
    {
        List<string> convidados = new List<string>();

        do
        {
            Console.WriteLine("digite SAIR para parar\n Digite o nome do convidado:  ");
            convidados.Add(Convert.ToString(Console.ReadLine()));

            if (convidados.Contains("SAIR") || convidados.Contains("sair") || convidados.Contains("Sair"))
            {
                break;
            }

        } while (true);

        Console.WriteLine("A lista possui: " + convidados.Count + " convidados");
        Console.WriteLine(string.Join("\n", convidados));

    }
}