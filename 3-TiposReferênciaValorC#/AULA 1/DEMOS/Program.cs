using System;
using System.Collections.Generic;

namespace DEMOS
{
    public class Program
    {
        static void Demo6()
        {
            int[] numeros = new int[] {0, 2, 4, 6, 8};
            Console.WriteLine($"Digite o número que gostaria de encontrar");
            var numero = int.Parse(Console.ReadLine());
            var idxEncontrado = EncontrarNumero(numeros, numero);

            if (idxEncontrado >= 0)
            {
                Console.WriteLine($"O número digitado está na posição {idxEncontrado}");
            }
            else
            {
                System.Console.WriteLine("O número digitado não foi encontrado");
            }
        }
        static void Demo5()
        {
            int[] pares = new int[] {0, 2, 4, 6, 8}; 

            MudarParaImpar(pares);

            Console.WriteLine($"Os ímpares {string.Join(", ", pares)}"); 
        }
        static void Demo4()
        {
            string nome = "Lucas";

            TrocarNome(nome, "Jesse");

            Console.WriteLine($"O novo nome é: {nome}");
        }
        static void Demo3()
        {
             StructPessoa p1 = new StructPessoa()
            {
                Documento = "1234",
                Idade = 27,
                Nome = "Lucas"
            };

            var p2 = p1;

            // TrocarNomeStruct(p1, "Jesse");
            p1 = TrocarNomeStruct(p1, "Jesse");

            Console.WriteLine($@"
                Nome do p1: {p1.Nome}
                Nome da p2: {p2.Nome}
            ");

            // StructPessoa p = default; // Cria uma variavel p;
            // p.Nome = "Cida";
            // p.Idade = 30;

             // static void TrocarNomeStruct(StructPessoa p1, string nomeNovo)
        // {
        //     p1.Nome = nomeNovo; // Dessa forma somente cria um copia
        // }
        }
        static void Demos2()
        {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Lucas";
            p1.Idade = 27;
            p1.Documento = "1234";

            // Pessoa p2 = p1; // cria uma copia da referencia de p1
            Pessoa p2 = p1.Clone();
            

            TrocarNome(p1, "Tampinha");

            Console.WriteLine($@"
            O novo de p1 é: {p1.Nome}
            O nome de p2 é: {p2.Nome}
            ");
            // Ao colocar o @ facilita as entradas de enter

        }

        static void Demo1()
        {
            int a = 2;
            a = Adicionar20(a);

            Console.WriteLine($"O valor da variável a é {a}");
        }
        static int Adicionar20(int a)
        {
            return a + 20;
            // a = a + 20;
        }

        static void TrocarNome(Pessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
        } 
       
        static StructPessoa TrocarNomeStruct(StructPessoa p1, string nomeNovo)
        {
            p1.Nome = nomeNovo;
            return p1;
        }
        static void TrocarNome(string nome, string nomeNovo)
        {
            nome = nomeNovo;

        // static string TrocarNome(string nome, string nomeNovo)
        // {
        //     nome = nomeNovo;
        //     return nome;
        // }
        }

        static void MudarParaImpar(int[] pares)
        {
            for (int i = 0; i < pares.Length; i++)
            {
                pares[i] = pares[i] + 1;
            }
        }

        static int EncontrarNumero(int[] numeros, int numero)
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] == numero)
                {
                    return i;
                }
            }
            return -1;
        }

        static bool EncontrarPessoa(List<Pessoa> pessoas, Pessoa pessoa)
        {
            foreach (var pessoaProcurada in pessoas)
            {
                if(pessoaProcurada.Nome == pessoa.Nome)
                {
                    return true;
                }
            }
            return false;
        }

          static bool EncontrarPessoa(List<StructPessoa> pessoas, StructPessoa pessoa)
        {
            foreach (var pessoaProcurada in pessoas)
            {
                if(pessoaProcurada.Equals(pessoa))
                {
                    return true;
                }
            }
            return false;
        }
        public static void Main(string[] args)
        {
            List<StructPessoa> pessoas = new List<StructPessoa>()
            {
                new StructPessoa() {Nome = "Lucas"},
                new StructPessoa() {Nome = "Tampinha"},
                new StructPessoa() {Nome = "Joao"},
                new StructPessoa() {Nome = "Jesse"},
                new StructPessoa() {Nome = "Julia"}
            };

            System.Console.WriteLine("Digite a pessoa que gostaria de localizar");
            var nome = Console.ReadLine();

            var pessoa = new StructPessoa() {Nome = nome};
            var encontrado = EncontrarPessoa(pessoas, pessoa);

            if(encontrado)
            {
                System.Console.WriteLine("Pessoa localizada");
            }
            else
            {
                System.Console.WriteLine("Pessoa não localizada");
            }
        }
    }
}
