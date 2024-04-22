public class Bichos
{
    private static int UltimoId = 0; // Variável estática para rastrear o último ID usado

    public string Nome { get; set; }
    public int Numero { get; set; }
    public int Id { get; private set; } // Propriedade Id com um setter privado

    // Construtor personalizado
    public Bichos(string nome, int numero,int id)
    {
        Nome = nome;
        Numero = numero;
        Id = ++UltimoId; // Incrementa o último ID usado
    }

    // Construtor sem parâmetros necessário para o EF Core
    public Bichos()
    {
    }
}
