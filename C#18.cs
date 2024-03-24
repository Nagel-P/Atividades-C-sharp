using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        string semVogais = RemoverVogais(frase);

        Console.WriteLine("Frase sem vogais: " + semVogais);
    }

    static string RemoverVogais(string frase)
    {
        string vogais = "aeiouAEIOU";
        foreach (char vogal in vogais)
        {
            frase = frase.Replace(vogal.ToString(), "");
        }
        return frase;
    }
}
