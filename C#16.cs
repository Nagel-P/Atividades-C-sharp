using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para encontrar seus divisores:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Divisores de " + numero + ":");

        for (int i = 1; i <= numero; i++)
        {
            if (numero % i == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
