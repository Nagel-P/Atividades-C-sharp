using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        int numeroAleatorio = random.Next(1, 101);
        int tentativas = 0;
        int palpite;

        Console.WriteLine("Tente adivinhar o número aleatório entre 1 e 100:");

        do
        {
            Console.Write("Palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numeroAleatorio)
            {
                Console.WriteLine("O número é maior. Tente novamente.");
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("O número é menor. Tente novamente.");
            }
            else
            {
                Console.WriteLine("Parabéns! Você acertou o número em " + tentativas + " tentativas.");
            }
        } while (palpite != numeroAleatorio);
    }
}
