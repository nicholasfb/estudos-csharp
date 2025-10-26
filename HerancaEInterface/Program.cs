ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso", 150.00m, "teclado.jpg");
Console.WriteLine($@"Dados do item 1:
Nome: {item1.Nome}
Descricao: {item1.Descricao}
Preco: {item1.Preco};
Estoque: {item1.Estoque}
");

Console.WriteLine($"Imagem: {item1.Imagem}");
item1.Imagem = "teclado-novo.jpg";
Console.WriteLine($"Imagem atualizada: {item1.Imagem}");

ProdutoDigital item2 = new ProdutoDigital("Curso", "POO em C#", 57.90m, "imagemBacana.jpg", "www.teste.com/link-teclado");
item2.Avaliar(5, "Excelente curso!");

Console.WriteLine($@"Dados do item 1:
Nome: {item2.Nome}
Descricao: {item2.Descricao}
Preco: {item2.Preco};
Link de download: {item2.LinkDownload}
Está expirado: {item2.EstaExpirado()}
Nota: {item2.Avaliacao.Nota}
Comentário: {item2.Avaliacao.Comentario}
");

//**EXERCÍCIOS**//
//Cliente Vip
ClienteVip cliente1 = new ClienteVip("Renata", 32, "Ouro", "VIP123A");
ClienteVip cliente2 = new ClienteVip("Leonardo", 40, "Diamanete", "VIP789X");

cliente1.ExibirInfoVip();
cliente2.ExibirInfoVip();

cliente1.AlteraNivelFidelidade("Platina");

cliente1.ExibirInfoVip();

//Funcionarios
Freelancer freelancer1 = new Freelancer("Ana", "Desenvolvedora", 3000.00m);

ColaboradorInterno colaborador1 = new ColaboradorInterno("Bruno", "Analista", 5000.00m);

freelancer1.ExibirInformacoes();
colaborador1.ExibirInformacoes();

//Profissao e Certificado
Docente docente1 = new Docente("Professor de Matemática");
Analista analista1 = new Analista("Analista de Sistemas");

Certificado certificadoDocente = new Certificado(docente1);
Certificado certificadoAnalista = new Certificado(analista1);

//Monitoramento de Sensores
SensorPresenca sensorPresenca = new();
SensorTemperatura sensorTemperatura = new();

sensorPresenca.Ativar();
sensorPresenca.Desativar();

sensorTemperatura.Ativar();
sensorTemperatura.Desativar();

//Computador
Processador processador = new Processador("Intel","i7-12700K");
PlacaMae placaMae = new PlacaMae("ASUS", "LGA1700");
Computador computador = new Computador
{
    Processador = processador,
    PlacaMae = placaMae
};

computador.ExibirConfiguracao();
