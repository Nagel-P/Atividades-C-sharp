using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma sequência de números separados por vírgula:");
        string entrada = Console.ReadLine();

        string[] numerosString = entrada.Split(',');
        int[] numeros = new int[numerosString.Length];

        for (int i = 0; i < numerosString.Length; i++)
        {
            numeros[i] = int.Parse(numerosString[i]);
        }

        Array.Sort(numeros);

        Console.WriteLine("Sequência ordenada:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }
    }
}
