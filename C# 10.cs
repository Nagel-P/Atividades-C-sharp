using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para calcular o fatorial:");
        int numero = int.Parse(Console.ReadLine());

        long resultado = CalcularFatorial(numero);
        Console.WriteLine("O fatorial de " + numero + " é: " + resultado);
    }

    static long CalcularFatorial(int num)
    {
        if (num == 0 || num == 1)
        {
            return 1;
        }
        else
        {
            long fatorial = 1;
            for (int i = 2; i <= num; i++)
            {
                fatorial *= i;
            }
            return fatorial;
        }
    }
}
