using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Escolha a conversão desejada:");
        Console.WriteLine("1. Celsius para Fahrenheit");
        Console.WriteLine("2. Fahrenheit para Celsius");
        int opcao = int.Parse(Console.ReadLine());

        if (opcao == 1)
        {
            Console.WriteLine("Digite a temperatura em Celsius:");
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = CelsiusParaFahrenheit(celsius);
            Console.WriteLine("A temperatura em Fahrenheit é: " + fahrenheit);
        }
        else if (opcao == 2)
        {
            Console.WriteLine("Digite a temperatura em Fahrenheit:");
            double fahrenheit = double.Parse(Console.ReadLine());
            double celsius = FahrenheitParaCelsius(fahrenheit);
            Console.WriteLine("A temperatura em Celsius é: " + celsius);
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
    }

    static double CelsiusParaFahrenheit(double celsius)
    {
        return (celsius * 9 / 5) + 32;
    }

    static double FahrenheitParaCelsius(double fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }
}
