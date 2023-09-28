class Usuario 
{ 
    public Usuario(string nome, int idade, Endereco endereco, string email, string senha)
    {
        Nome = nome;
        Idade = idade;
        Endereco = endereco;
        Email = email;
        Senha = senha;
        Ativo = true;
    }

    List<Musica> playlistMusica = new List<Musica>();

    public string Nome { get; set; }
    public int Idade { get; set; }
    public Endereco Endereco { get; set; }
    public string Email { get; set; }
    public string Senha { get; set;}
    public bool Ativo;

    public void ListarUsuario()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Endereco: {Endereco.Logradouro} - n° {Endereco.Numero}");
        Console.WriteLine($"Email: {Endereco}");
        Console.WriteLine($"Ativo: {Ativo}\n");
    }

    public void AdicionarMusicaNaPlaylist(Musica musica)
    {
        playlistMusica.Add(musica);
        Console.WriteLine($"Música {musica.Nome} adicionada com sucesso na playlist do {Nome}\n");
    }

    public void ListarMusicasDaPlaylist()
    {
        Console.WriteLine($"Lista das músicas na playlist\n");
        foreach (var musica in playlistMusica)
        {
            Console.WriteLine($"Música: {musica.Nome} - {musica.Artista.Nome}");
        }
    }

    public void Inativar()
    {
        Console.WriteLine($"O usuário {Nome} foi inativo\n");
        Ativo = false;
    }

    public void SolicitarReativacaoConta()
    {
        Console.WriteLine("");
    }
}
