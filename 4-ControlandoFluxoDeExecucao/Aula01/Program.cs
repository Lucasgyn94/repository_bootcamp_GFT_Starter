using static System.Console;

namespace Aula01
{
    class Program
    {

        static void Demo1()
        {
            int valor1;
            int valor2;
            int total;

            WriteLine("Digite o primeiro valor");
            valor1 = int.Parse(ReadLine()); // int.Parse faz a conversão para inteiro
            WriteLine($"O primeiro valor é: {valor1}");

            WriteLine("Digite o segundo valor");
            valor2 = int.Parse(ReadLine());
            WriteLine($"O segundo valor é: {valor2}");

            total = valor1 + valor2;

            WriteLine($"A soma dos valores é: {total}");
        }
        static void Main(string[] args)
        {
            Demo1();
        }
    }
}
