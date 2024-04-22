public class Cliente
{
    private static int UltimoId = 0; // Variável estática para rastrear o último ID usado

    public int Id {get;init;}
    public string Nome {get;private set;}
    public string Senha{get;private set;}

    public string Email{get;private set;}

    public double Carteira{get;init;}

    public Cliente(string nome,string senha, string email)
    {
        Nome=nome;
        Senha=senha;
        Email=email;
        Carteira=0.0;

        Id=++UltimoId;

    }

}