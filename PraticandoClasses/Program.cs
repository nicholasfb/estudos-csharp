#region Classes e Objetos
using PraticandoClasses;

Produto produto1 = new("Teclado Gamer", "Teclado para longas jornadas de jogatina", 200, 10);

Console.WriteLine(produto1.ToString());
#endregion

#region Classes e Objetos (Livro)
Livro livro1 = new("O Senhors dos Anéis", "J.R.R. Tolkien");
Console.WriteLine(livro1.ToString());
#endregion

#region Classes e Objetos (Passagem)
Passagem passagem1 = new("Ayrke Braga", "João Pessoa");
Console.WriteLine(passagem1.ToString());
#endregion

#region Classes e Objetos (Conta Bancária)
ContaBancaria conta1 = new("78901-2", 1000);
conta1.Depositar(500);
Console.WriteLine(conta1.ToString());
#endregion

#region Classes e Objetos (Funcionário)
Funcionario funcionario1 = new("Ayrke Braga", "Historiador");
funcionario1.Promover("HiStOrIaDoR");
funcionario1.Promover("Seminarista de Sumérios");
Console.WriteLine(funcionario1.ToString());
#endregion

#region Classes e Objetos (Retângulo)
Retangulo retangulo1 = new(5, 8);
Console.WriteLine($"Área do retângulo: {retangulo1.CalcularArea()}");
#endregion

#region Classes e Objetos (Filme)
Filme filme1 = new("Duna", 16);
Console.WriteLine(filme1.ExibirResultado(15));
Console.WriteLine(filme1.ExibirResultado(18));
#endregion

#region Classes e Objetos (Produto02)
Produto02 produto02 = new("Monitor 4K", 5);
produto02.RemoverEstoque(2);
produto02.RemoverEstoque(4);
Console.WriteLine($"Quantidade em estoque do produto {produto02.Nome}: {produto02.ObterQuantidadeEstoque()}");
#endregion

#region Classes e Objetos (Pedido)
Pedido pedido1 = new(1001, "Ayrke Braga", "Em processamento");
Console.WriteLine(pedido1.ToString());
pedido1.AtualizarStatus("Enviado");
Console.WriteLine(pedido1.ToString());
#endregion

#region Classes e Objetos (Consulta)
Consulta consulta1 = new("Ayrke Braga", "Dr. Silva", new DateTime(2024, 7, 15, 14, 30, 0));
consulta1.ExibirDetalhes();
consulta1.ReagendarConsulta(new DateTime(2024, 7, 20, 10, 0, 0));
consulta1.ExibirDetalhes();
#endregion

#region Classes e Objetos (ProdutoDigital e InformacaoTecnica)
InformacaoTecnica infoTecnica = new(150.5m, "Windows 10");
ProdutoDigital produtoDigital1 = new("Antivírus Pro", 99.90m, infoTecnica);
produtoDigital1.ExibirDetalhes();
#endregion
