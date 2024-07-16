using System.IO;
using static System.Console;

// o @ serve para reconhecer o caminho
var path = @"C:\Users\Admin\Desktop\DigitalOne\3-Bootcamp_GFT_Starter\6-TrabalhandoArquivos&Streams\2-DirectoryAndDirectoryInfo\globo";
// LerDiretorios(path);
LerArquivos(path);

WriteLine("Digite [enter] para finalizar...");
ReadLine();

static void LerArquivos(string path)
{
    var arquivos = Directory.GetFiles(path, "*", SearchOption.AllDirectories);
    foreach (var arquivo in arquivos)
    {
        var fileInfo = new FileInfo(arquivo);
        WriteLine($"[Nome]: {fileInfo.Name}");
        WriteLine($"[Tamanho]: {fileInfo.Length}");
        WriteLine($"[Último acesso]: {fileInfo.LastAccessTime}");
        WriteLine($"[Pasta]: {fileInfo.DirectoryName}");
        WriteLine("----------------------------------------");
    }
}


void LerDiretorios(string path)
{
    if(Directory.Exists(path))
    {
        var diretorios = Directory.GetDirectories(path, "*", SearchOption.AllDirectories);

        foreach(var dir in diretorios)
        {
            var dirInfo = new DirectoryInfo(dir);
            WriteLine($"[Nome]: {dirInfo.Name}");
            WriteLine($"[Raiz]: {dirInfo.Root}");

            if(dirInfo.Parent != null)
            {
                WriteLine($"[Pai]: {dirInfo.Parent.Name}");
            }
            WriteLine("--------------------------");
        }
    }
    else
    {
        WriteLine($"{path}Diretório não existe");
    }
}