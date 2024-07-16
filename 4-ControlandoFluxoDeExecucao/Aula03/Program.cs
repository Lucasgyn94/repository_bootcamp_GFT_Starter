using System;
using static System.Console;

namespace Aula03
{
    class Program
    {
        static void Demo1While()
        {
            Boolean condicao = true;
            int valor = 0;

            while (condicao == true)
            {
                WriteLine("Digite um valor, 0 para sair");
                valor = int.Parse(ReadLine());

                if (valor == 0)
                {
                    WriteLine("Você saiu da aplicação");
                    condicao = false;
                }
                else
                {
                    WriteLine($"Valor informado = {valor}");
                }
            }
        }

        static void Demo2DoWhile()
        {
            Boolean condicao = true;
            int valor = 0;

            do
            {
                WriteLine("Digite um valor, 0 para sair");
                valor = int.Parse(ReadLine());

                if (valor == 0)
                {
                    WriteLine("Você saiu da aplicação");
                    condicao = false;
                }
                else
                {
                    WriteLine($"Valor informado = {valor}");
                }
            } while (condicao == true);
        }

        static void Demo3For()
        {
            int valor;

            WriteLine("Digite um valor");
            valor = int.Parse(ReadLine());

            for(int i = valor; i <= 10; i++)
            {
                WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            int[] lista = {1, 2, 3 , 4, 5};

            foreach (int numero in lista)
            {
                WriteLine(numero);
            }

        }
    }
}
