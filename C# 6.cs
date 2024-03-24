using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite um número para ver a sua tabuada:");
        int numero = int.Parse(Console.ReadLine());

        Console.WriteLine("Tabuada de " + numero + ":");

        for (int i = 1; i <= 10; i++)
        {
            int resultado = numero * i;
            Console.WriteLine(numero + " x " + i + " = " + resultado);
        }
    }
}
