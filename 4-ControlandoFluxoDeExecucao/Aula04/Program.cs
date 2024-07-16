using System;
using static System.Console;

namespace Aula04
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean condicao = true;
            int valor;

            do
            {
                WriteLine("Digite um valor, 0 para sair");
                valor = int.Parse(ReadLine());

                if(valor == 0)
                { 
                    WriteLine("Você saiu da aplicação");
                    break;
                }
                else
                {
                    WriteLine($"O valor digitado foi: {valor}");
                    continue;
                }
            } while(condicao == true);
        }
    }
}
