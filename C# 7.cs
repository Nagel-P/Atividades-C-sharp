using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma frase:");
        string frase = Console.ReadLine();

        int contadorVogais = 0;

        foreach (char letra in frase)
        {
            if ("aeiouAEIOU".Contains(letra))
            {
                contadorVogais++;
            }
        }

        Console.WriteLine("Número de vogais na frase: " + contadorVogais);
    }
}
