using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro número:");
        int numero1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        int numero2 = int.Parse(Console.ReadLine());

        int soma = numero1 + numero2;
        Console.WriteLine("A soma de " + numero1 + " e " + numero2 + " é: " + soma);
    }
}
