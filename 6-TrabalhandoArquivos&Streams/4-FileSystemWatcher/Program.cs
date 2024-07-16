using System.IO;
using static System.Console;

var path = @"C:\Users\Admin\Desktop\DigitalOne\3-Bootcamp_GFT_Starter\6-TrabalhandoArquivos&Streams\2-DirectoryAndDirectoryInfo\globo";

using var fsw = new FileSystemWatcher(path);
fsw.Created += OnCreated;
fsw.Deleted += OnDeleted;
fsw.Renamed += OnRenamed;

fsw.EnableRaisingEvents = true; // diz q os eventos podem ser disparados
fsw.IncludeSubdirectories = true; 

WriteLine($"Monitorando eventos na pasta {path}");
WriteLine("Pressione [enter] para finalizar");
ReadLine();


void OnCreated(object sender, FileSystemEventArgs e)
{
    WriteLine($"Foi criado o arquivo {e.Name}");
}

void OnDeleted(object sender, FileSystemEventArgs e)
{
    WriteLine($"Foi excluido o arquivo {e.Name}");
}

void OnRenamed(object sender, RenamedEventArgs e)
{
    WriteLine($"O arquivo {e.OldName} foi renomeado para {e.Name}");
}