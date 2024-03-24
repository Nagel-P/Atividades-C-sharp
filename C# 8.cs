using System;

class Program
{
    static void Main(string[] args)
    {
        int quantidade = 10;
        int primeiroTermo = 0;
        int segundoTermo = 1;

        Console.WriteLine("Sequência de Fibonacci:");

        for (int i = 0; i < quantidade; i++)
        {
            Console.Write(primeiroTermo + " ");

            int proximoTermo = primeiroTermo + segundoTermo;
            primeiroTermo = segundoTermo;
            segundoTermo = proximoTermo;
        }
    }
}
