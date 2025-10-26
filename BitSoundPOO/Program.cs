Banda banda1 = new Banda("Arctic Monkeys");
Musica musica1 = new Musica(banda1,"505")
{
    Duracao = 3,
    Disponivel = true,
};

Console.WriteLine(musica1.DescricaoResumida);
musica1.ExibirFichaTecnica();

//Console.WriteLine($"Nome da música {musica1.nome}");
//Console.WriteLine($"Nome do artista {musica1.artista}");

Banda banda2 = new Banda("Radiohead");
Musica musica2 = new Musica(banda2, "Creep")
{
    Duracao = 5,
    Disponivel = false,
};

musica2.ExibirFichaTecnica();


//Console.WriteLine($"Nome da música {musica2.nome}");
//Console.WriteLine($"Nome do artista {musica2.artista}");


//Exemplo Lambda. Função anônima que retorna números pares
/*List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);
numerosPares.ForEach(numero => Console.WriteLine(numero));
*/

Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the Opera");

Musica musica3 = new Musica(queen, "Love of my life")
{
    Disponivel = true,
    Duracao = 213 / 60,
};


Musica musica4 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354 / 60,
    Disponivel = false,
};

musica3.ExibirFichaTecnica();
musica4.ExibirFichaTecnica();

albumDoQueen.AdicionarMusica(musica3);
albumDoQueen.AdicionarMusica(musica4);

albumDoQueen.ListaMusicasAlbum();


queen.AdicionarAlbum(albumDoQueen);
queen.ExibirDiscografia();

Podcast pontosHipsters = new Podcast("Pontos Hipsters", "Paulo Silveira");

Episodio episodio1 = new Episodio("A ascensão dos hipsters", 45);
episodio1.AdicionarConvidados("Guilherme Silveira");
episodio1.AdicionarConvidados("Mário Solto");

Episodio episodio2 = new Episodio("Cultura e Tech", 30);
episodio2.AdicionarConvidados("Nico Steppat");

pontosHipsters.AdicionarEpisodio(episodio1);
pontosHipsters.AdicionarEpisodio(episodio2);

pontosHipsters.ExibirDetalhesPodcast();

/*
Titular titular = new Titular();
titular.Nome = "Ayrke Braga";
titular.Cpf = "111.111.111-11";
titular.Email = "ayrke.braga@email.com";
titular.Telefone = 1191111111;

Conta conta1 = new Conta();
conta1.Titular = titular;
conta1.Agencia = 1111;
conta1.NumeroConta = 111111;
conta1.Saldo = 20000;
conta1.Limite = 30000;

Console.WriteLine("\nInformações do Titular:");
Console.WriteLine(conta1.Titular.ExibeInformacoesTitular);

Console.WriteLine("Informações da Conta Bancária");
conta1.ExibeInformacoesConta();

Aluno aluno1 = new Aluno();
aluno1.Nome = "Zezinho";
aluno1.Idade = 15;
aluno1.Notas.Add(10);
aluno1.Notas.Add(8);
aluno1.Notas.Add(7);
aluno1.Notas.Add(9);

Aluno aluno2 = new Aluno();
aluno2.Nome = "Huguinho";
aluno2.Idade = 16;
aluno2.Notas.Add(6);
aluno2.Notas.Add(9);
aluno2.Notas.Add(6);
aluno2.Notas.Add(7);

Aluno aluno3 = new Aluno();
aluno3.Nome = "Wiltinho";
aluno3.Idade = 17;
aluno3.Notas.Add(9);
aluno3.Notas.Add(6);
aluno3.Notas.Add(4);
aluno3.Notas.Add(5);

Professor professor1 = new Professor();
professor1.Nome = "Girafales";

Disciplina disciplinaPortugues = new Disciplina();
disciplinaPortugues.Nome = "Português";
disciplinaPortugues.ListaAlunos.Add(aluno1);
disciplinaPortugues.ListaAlunos.Add(aluno2);
disciplinaPortugues.ListaAlunos.Add(aluno3);
disciplinaPortugues.professor = professor1;

Console.WriteLine(disciplinaPortugues.ExibeInformacoesDisciplina);
*/