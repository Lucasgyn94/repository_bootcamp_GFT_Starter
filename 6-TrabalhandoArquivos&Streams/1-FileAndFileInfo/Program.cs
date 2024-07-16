using static System.Console;
using System.IO;
using System;

WriteLine("Digite o nome do arquivo");
var nome = ReadLine();

nome = LimparNome(nome);

// var path = Environment.CurrentDirectory + "\\teste.txt";
var path = Path.Combine(Environment.CurrentDirectory, $"{nome}.txt"); // // caminho = ambiente.DiretorioAtual + "\\teste.txt"

CriarArquivo(path);

WriteLine("Digite enter para finalizar...");
ReadLine();

static string LimparNome(string nome)
{
    // Path.GetInvalidFileNameChars(); // Retorna um array com uma lista de caracteres que não e permitido para criar um arquivo
    foreach(var _char in Path.GetInvalidFileNameChars())
    {
        nome = nome.Replace(_char, '-');
    }
    return nome;
}

static void CriarArquivo(string path)
{
    try
    {
        // Cria arquivo teste omitindo o flush com using
        using var sw = File.CreateText(path);
        {
        sw.WriteLine("Está e a linha 1 do arquivo");
        sw.WriteLine("Está é a linha 2 do arquivo");
        sw.WriteLine("Está é a linha 3 do arquivo");
        }
    }
    catch
    {
        WriteLine("O nome do arquivo está inválido");
    }
}

    // cria arquivo teste
    // File.Create(path);

    // criar arquivo teste 
    // var sw = File.CreateText(path);
    // sw.WriteLine("Está e a linha 1 do arquivo");
    // sw.WriteLine("Está é a linha 2 do arquivo");
    // sw.WriteLine("Está é a linha 3 do arquivo");
    // sw.Flush(); 
    // Flush = Serve para descarregar os arquivos da memoria. se n colocar, o arquivo continuara vazio, tambem pode ser dado flush por linha


