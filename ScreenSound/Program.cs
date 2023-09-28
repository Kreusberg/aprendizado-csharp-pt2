Banda queen = new Banda("Queen");

Album albumDoQueen = new Album("A night at the opera");

//Genero genero = new Genero();
//genero.Nome = "Rock";

Musica musica1 = new Musica(queen, "Love of my life")
{
    Duracao = 213,
    Disponivel = true,
};

//musica1.Genero = new Genero();
//musica1.Genero.Nome = "Rock";

Musica musica2 = new Musica(queen, "Bohemian Rhapsody")
{
    Duracao = 354,
    Disponivel = false,
};

//musica2.Genero = new Genero();
//musica2.Genero.Nome = "Rock";

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