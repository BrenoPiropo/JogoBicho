public class Resultado
{

    public string NomeAnimal { get; set; }
    public int Numero { get; set; }
    public int Id { get; private set; } // Propriedade Id com um setter privado

    // Construtor personalizado
    public Resultado(string nomeAnimal, int numero,int id)
    {
        NomeAnimal = nomeAnimal;
        Numero = numero;
        id=id;
    }

    // Construtor sem parâmetros necessário para o EF Core
    public Resultado()
    {
    }
}
