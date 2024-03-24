using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para verificar se é primo:");
        int numero = int.Parse(Console.ReadLine());

        bool ehPrimo = VerificarPrimo(numero);

        if (ehPrimo)
        {
            Console.WriteLine(numero + " é um número primo.");
        }
        else
        {
            Console.WriteLine(numero + " não é um número primo.");
        }
    }

    static bool VerificarPrimo(int num)
    {
        if (num <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }
}
