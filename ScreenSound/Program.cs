Album albumDoQueen = new Album();
albumDoQueen.Nome = "A night at the opera";

//Genero genero = new Genero();
//genero.Nome = "Rock";

Musica musica1 = new Musica();
musica1.Nome = "Love of my life";
musica1.Duracao = 213;
//musica1.Genero = new Genero();
//musica1.Genero.Nome = "Rock";

Musica musica2 = new Musica();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;
//musica2.Genero = new Genero();
//musica2.Genero.Nome = "Rock";

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

Banda queen = new Banda();
queen.Nome = "Queen";
queen.AdicionarAlbum(albumDoQueen);
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