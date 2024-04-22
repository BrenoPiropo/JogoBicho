public class Jogo
{
    public int IdJogo { get; private set; } // Chave primária
    public string NomeAnimal { get; private set; }
    public int IdResultado { get; private set; }

    public double Premio { get; private set; }

    public Jogo(string nomeAnimal, int idResultado, double premio)
    {
        NomeAnimal = nomeAnimal;
        IdResultado = idResultado;
        Premio = premio;
    }

    // Construtor sem parâmetros necessário para o EF Core
    public Jogo()
    {

    }
}
