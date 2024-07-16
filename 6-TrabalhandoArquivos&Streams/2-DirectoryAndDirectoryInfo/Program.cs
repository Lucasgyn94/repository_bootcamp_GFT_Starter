using System;
using System.IO;
using static System.Console;

CriarDiretorioGlogo();

CriarArquivo();
var origem = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
var destino = Path.Combine(Environment.CurrentDirectory, 
                                "globo", 
                                "América do Sul", 
                                "Argentina", 
                                "argentina.txt");
//MoverArquivo(origem, destino);

CopiarArquivo(origem, destino);

static void CopiarArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        WriteLine("Arquivo de origem não existe");
        return;
    }
    if(File.Exists(pathDestino))
    {
        WriteLine("Arquivo já existe na pasta destino");
        return;
    }
    File.Copy(pathOrigem, pathDestino);
}

static void MoverArquivo(string pathOrigem, string pathDestino)
{
    if(!File.Exists(pathOrigem))
    {
        WriteLine("Arquivo de origem não existe");
        return;
    }
    if(File.Exists(pathDestino))
    {
        WriteLine("Arquivo já existe na pasta destino");
        return;
    }
    File.Move(pathOrigem, pathDestino);
}

static void CriarArquivo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "brasil.txt");
    if (!File.Exists(path))
    {
        using var sw = File.CreateText(path);
        sw.WriteLine("População: 213M");
        sw.WriteLine("IDH: 0,901");
        sw.WriteLine("Dados atualizados em: 20/01/2022");
    }
}

static void CriarDiretorioGlogo()
{
    var path = Path.Combine(Environment.CurrentDirectory, "globo");
    
    if (!Directory.Exists(path))
    {
        var dirGlobo = Directory.CreateDirectory(path);

        DirectoryInfo dirAmNorte = dirGlobo.CreateSubdirectory("América do Norte");
        DirectoryInfo dirAmCentral = dirGlobo.CreateSubdirectory("América Central");
        var dirAmSul = dirGlobo.CreateSubdirectory("América do sul");

        dirAmNorte.CreateSubdirectory("USA");
        dirAmNorte.CreateSubdirectory("México");
        dirAmNorte.CreateSubdirectory("Canada");

        dirAmCentral.CreateSubdirectory("Costa Rica");
        dirAmCentral.CreateSubdirectory("Panama");

        dirAmSul.CreateSubdirectory("Brasil");
        dirAmSul.CreateSubdirectory("Argentina");
        dirAmSul.CreateSubdirectory("Paraguai");
    }
}

