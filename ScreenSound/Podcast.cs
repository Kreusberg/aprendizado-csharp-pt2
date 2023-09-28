class Podcast
{
    public Podcast(string nome, string host)
    {
        Nome = nome;
        Host = host;
    }

    public string Nome { get; }
    public string Host { get; }
    public List<Episodio> episodios = new();
    private int totalEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio ep)
    {
        episodios.Add(ep);
    }
    
    public void ExibirDetalhes()
    {
        Console.WriteLine($"Exibindo detalhes do podcast {Nome}: \n");
        Console.WriteLine($"Podcast {Nome} apresentado por {Host}\n");
        Console.WriteLine($"Exibindo lista de episódios:\n");
        foreach (Episodio ep in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(ep.Resumo);
        }
        Console.Write($"\n\nEste podscast possui {totalEpisodios} episódios\n");

    }
}
