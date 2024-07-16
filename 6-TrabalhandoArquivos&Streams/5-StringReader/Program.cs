using System;
using System.Text;
using System.IO;

// Criando Instância StringBuilder
StringBuilder sb = new StringBuilder();
sb.AppendLine("Caracteres na primeira linha para ler");
sb.AppendLine("E a segunda linha");
sb.AppendLine("E o fim");

using var sr = new StringReader(sb.ToString());
// var buffer = new char[10];
// var tamanho = 0;

do
{

    Console.WriteLine(sr.ReadLine());

} while(sr.Peek() >= 0); // peek = Retorna o próximo caractere disponível, mas não o consome.


// do{
//     // zerando/ limpando o buffer
//     buffer = new char[10];
//     tamanho = sr.Read(buffer);
//     Console.WriteLine(string.Join("", buffer));

// } while(tamanho >= buffer.Length);

Console.WriteLine("Digite [enter] para finalizar");
Console.ReadKey(); // ReadKey = Obtém o próximo caractere ou tecla de função pressionada pelo usuário.


// using var sr = new StringReader(sb.ToString());
// var buffer = new char[10];
// var posicao = sr.Read(buffer);
// WriteLine($"{string.Join("", buffer)}");

// ReadLine();

