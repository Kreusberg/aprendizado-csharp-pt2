class Endereco
{ 
    public Endereco(string logradouro, int numero, string bairro, string cidade, string cep) 
    { 
        Logradouro = logradouro;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Cep = cep;
    }

    public string Logradouro { get; }
    public int Numero { get; }
    public string Bairro { get; }
    public string Cidade { get; }
    public string Cep { get; }

    public void ListarEndereco()
    {
        Console.WriteLine($"Logradouro: {Logradouro}");
        Console.WriteLine($"Número: {Numero}");
        Console.WriteLine($"Bairro: {Bairro}");
        Console.WriteLine($"Cidade: {Cidade}");
        Console.WriteLine($"Cep: {Cep}");
    }

}
