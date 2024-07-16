using static System.Console;

namespace Aula02
{
    class Program
    {
        static void Demos1()
        {
            WriteLine("Digite a sua idade");
            var idade = int.Parse(ReadLine());

            if(idade >= 18)
            {
                WriteLine($"Idade = {idade} \nUsuário maior de idade");
            }
            else
            {
                WriteLine($"Idade = {idade} \nUsuário menor de idade");
            }
        }

        static void Demos2()
        {
            int mes;

            WriteLine("Digite um número do mês");
            mes = int.Parse(ReadLine());

            if(mes == 1)
            {
                WriteLine("O mês é Janeiro");
            }
            else if(mes == 2)
            {
                WriteLine("O mês é Fevereiro");
            }
            else if(mes == 3)
            {
                WriteLine("O mês é Março");
            }
            else if(mes == 4)
            {
                WriteLine("O mês é Abril");
            }
            else if(mes == 5)
            {
                WriteLine("O mês é Maio");
            }
            else if(mes == 6)
            {
                WriteLine("O mês é Junho");
            }
            else if(mes == 7)
            {
                WriteLine("O mês é Julho");
            }
            else if(mes == 8)
            { 
                WriteLine("O mês é Agosto");
            }
            else if(mes == 9)
            {
                WriteLine("O mês é Setembro");
            }
            else if(mes == 10)
            {
                WriteLine("O mês é Outubro");
            }
            else if(mes == 11)
            {
                WriteLine("O mês é Novembro");
            }
            else if(mes == 12)
            {
                WriteLine("O mês é Dezembro");
            }
            else
            {
                WriteLine("Opção inválida, escolha um mês entre 1 e 12");
            }
        }
        static void Main(string[] args)
        {
            WriteLine("Digite um número do mês");
            var mes = int.Parse(ReadLine());

            switch(mes)
            {
                case 1:
                        WriteLine("Janeiro");
                break;
                
                case 2:
                        WriteLine("Fevereiro");
                break;

                case 3:
                        WriteLine("Março");
                break;

                case 4:
                        WriteLine("Abril");
                break;

                case 5:
                        WriteLine("Maio");
                break;
                
                case 6:
                        WriteLine("Junho");
                break;

                case 7:
                        WriteLine("Julho");
                break;

                case 8:
                        WriteLine("Agosto");
                break;

                case 9:
                        WriteLine("Setembro");
                break;

                case 10:
                        WriteLine("Outubro");
                break;
                
                case 11:
                        WriteLine("Novembro");
                break;

                case 12:
                        WriteLine("Dezembro");
                break;

                default:
                        WriteLine("Opção inválida");
                break;
            }
        }
    }
}
