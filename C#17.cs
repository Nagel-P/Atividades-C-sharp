using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite uma lista de números separados por espaço:");
        string[] numerosString = Console.ReadLine().Split(' ');

        Console.WriteLine("Números pares:");

        foreach (string numStr in numerosString)
        {
            int num = int.Parse(numStr);
            if (num % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }
    }
}
