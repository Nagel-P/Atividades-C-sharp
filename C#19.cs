using System;

class Program
{
    static void Main(string[] args)
    {
        string[] opcoes = { "Pedra", "Papel", "Tesoura" };

        Console.WriteLine("Jogo: Pedra, Papel e Tesoura");
        Console.WriteLine("Escolha sua jogada (Digite Pedra, Papel ou Tesoura):");
        string jogadaUsuario = Console.ReadLine();

        Random random = new Random();
        int indiceComputador = random.Next(opcoes.Length);
        string jogadaComputador = opcoes[indiceComputador];

        Console.WriteLine("O computador escolheu: " + jogadaComputador);

        // Lógica para determinar o vencedor
        if (jogadaUsuario == jogadaComputador)
        {
            Console.WriteLine("Empate!");
        }
        else if ((jogadaUsuario == "Pedra" && jogadaComputador == "Tesoura") ||
                 (jogadaUsuario == "Papel" && jogadaComputador == "Pedra") ||
                 (jogadaUsuario == "Tesoura" && jogadaComputador == "Papel"))
        {
            Console.WriteLine("Você venceu!");
        }
        else
        {
            Console.WriteLine("Você perdeu!");
        }
    }
}
