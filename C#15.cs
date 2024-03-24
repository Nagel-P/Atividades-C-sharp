using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a forma geométrica para calcular a área:");
        Console.WriteLine("1. Círculo");
        Console.WriteLine("2. Retângulo");
        Console.WriteLine("3. Triângulo");
        int opcao = int.Parse(Console.ReadLine());

        double area = 0;

        switch (opcao)
        {
            case 1:
                Console.WriteLine("Digite o raio do círculo:");
                double raio = double.Parse(Console.ReadLine());
                area = CalcularAreaCirculo(raio);
                break;
            case 2:
                Console.WriteLine("Digite a base do retângulo:");
                double baseRetangulo = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do retângulo:");
                double alturaRetangulo = double.Parse(Console.ReadLine());
                area = CalcularAreaRetangulo(baseRetangulo, alturaRetangulo);
                break;
            case 3:
                Console.WriteLine("Digite a base do triângulo:");
                double baseTriangulo = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a altura do triângulo:");
                double alturaTriangulo = double.Parse(Console.ReadLine());
                area = CalcularAreaTriangulo(baseTriangulo, alturaTriangulo);
                break;
            default:
                Console.WriteLine("Opção inválida.");
                break;
        }

        Console.WriteLine("A área é: " + area);
    }

    static double CalcularAreaCirculo(double raio)
    {
        return Math.PI * Math.Pow(raio, 2);
    }

    static double CalcularAreaRetangulo(double baseRetangulo, double alturaRetangulo)
    {
        return baseRetangulo * alturaRetangulo;
    }

    static double CalcularAreaTriangulo(double baseTriangulo, double alturaTriangulo)
    {
        return (baseTriangulo * alturaTriangulo) / 2;
    }
}
