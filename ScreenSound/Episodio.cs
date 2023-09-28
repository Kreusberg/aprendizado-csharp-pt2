class Episodio 
{ 
    public Episodio(int ordem, string titulo, int duracao)
    {
        Ordem = ordem;
        Titulo = titulo;
        Duracao = duracao;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    public string Resumo => $"Ordem: {Ordem} - Título: {Titulo} - Duração: ({Duracao} min) - {string.Join(", ", convidados)}";
    private List<string> convidados = new();

    public void AdicionarConvidados(string nomeConvidado)
    {
        convidados.Add(nomeConvidado);
    }
}
