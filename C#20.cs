using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma lista de palavras separadas por espaço:");
        string[] palavras = Console.ReadLine().Split(' ');

        string maisLonga = EncontrarMaisLonga(palavras);
        string maisCurta = EncontrarMaisCurta(palavras);

        Console.WriteLine("Palavra mais longa: " + maisLonga);
        Console.WriteLine("Palavra mais curta: " + maisCurta);
    }

    static string EncontrarMaisLonga(string[] palavras)
    {
        return palavras.OrderByDescending(p => p.Length).FirstOrDefault();
    }

    static string EncontrarMaisCurta(string[] palavras)
    {
        return palavras.OrderBy(p => p.Length).FirstOrDefault();
    }
}
