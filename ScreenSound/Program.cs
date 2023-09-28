using System;
using System.Reflection.Metadata.Ecma335;

Musica musica1 = new Musica();
musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;
//Console.WriteLine(musica1.DescricaoResumida);

Musica musica2 = new Musica();
musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;
//Console.WriteLine(musica2.DescricaoResumida);
/*
musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
*/

List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
List<int> numerosPares = numeros.FindAll(numero => numero % 2 == 0);


int somar(int a, int b)  => a + b;

double subtrair(double a, double b) => a - b;

int multiplicar(int a, int b) => a * b;

double dividir(double a, double b) => a / b;

Console.WriteLine(somar(1, 9));
Console.WriteLine(subtrair(19.9, 8.7));
Console.WriteLine(multiplicar(9, 8));
Console.WriteLine(dividir(19, 4));