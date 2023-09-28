Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

Usuario usuario1 = new Usuario("Lucas", 18, new Endereco("Rua", 99, 
    "Bairro Fictício", "São Paulo", "888888-888"), "lucas@gmail.com", "senha123");

Usuario usuario2 = new Usuario("João", 19, new Endereco("Rua", 99,
    "Bairro Fictício", "São Paulo", "888888-888"), "joao@gmail.com", "123senha");

usuario1.ListarUsuario();
usuario2.ListarUsuario();

usuario1.AdicionarMusicaNaPlaylist(musica1);
usuario1.AdicionarMusicaNaPlaylist(musica2);
usuario2.AdicionarMusicaNaPlaylist(musica2);

usuario2.Inativar();

usuario1.ListarUsuario();
usuario2.ListarUsuario();

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);
queen.AdicionarAlbum(albumDoQueen);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoQueen.ExibirMusicasDoAlbum();
queen.ExibirDiscografia();

/*
int somar(int a, int b)  => a + b;

double subtrair(double a, double b) => a - b;

int multiplicar(int a, int b) => a * b;

double dividir(double a, double b) => a / b;

Console.WriteLine(somar(1, 9));
Console.WriteLine(subtrair(19.9, 8.7));
Console.WriteLine(multiplicar(9, 8));
Console.WriteLine(dividir(19, 4));
*/