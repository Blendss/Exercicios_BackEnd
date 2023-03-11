using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string frutasStr = "maçã, banana, laranja, maçã, pêra, banana, uva, uva";

        string[] frutasArr = frutasStr.Split(new[] { ", " }, StringSplitOptions.None);
        List<string> frutas = new List<string>(new HashSet<string>(frutasArr));

        List<string> frutasMaiusculas = new List<string>();

        foreach (string fruta in frutas)
        {
            frutasMaiusculas.Add(char.ToUpper(fruta[0]) + fruta.Substring(1));
        }
        Console.WriteLine("Lista de Frutas formatada:");
        foreach (string fruta in frutasMaiusculas)
        {
            Console.WriteLine(fruta);
        }
    }
}