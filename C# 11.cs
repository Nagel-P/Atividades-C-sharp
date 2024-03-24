using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma palavra para verificar se é um palíndromo:");
        string palavra = Console.ReadLine();

        bool ehPalindromo = VerificarPalindromo(palavra);

        if (ehPalindromo)
        {
            Console.WriteLine(palavra + " é um palíndromo.");
        }
        else
        {
            Console.WriteLine(palavra + " não é um palíndromo.");
        }
    }

    static bool VerificarPalindromo(string palavra)
    {
        int inicio = 0;
        int fim = palavra.Length - 1;

        while (inicio < fim)
        {
            if (palavra[inicio] != palavra[fim])
            {
                return false;
            }
            inicio++;
            fim--;
        }
        return true;
    }
}
