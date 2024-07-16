using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Lucas";
p1.Idade = 27;
p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "Rua Teste",
    Numero = 300,
    CEP = "0000000",
    Cidade = "Goiania",
};

WriteLine("Fim");

