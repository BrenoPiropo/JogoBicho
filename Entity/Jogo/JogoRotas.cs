public static class JogoRotas
{
    public static void AddRotasJogo(this WebApplication app){
        var rotasJogo = app.MapGroup("Jogo");
        //vamos criar uma rota para criar clientes
        //Para criar usar post
        rotasJogo.MapPost("",async (AddJogoRequest request,AppDbContext context)=>
        {  
            var novoJogo= new Jogo(request.nomeAnimal,request.idResultado,request.premio);
            await context.Jogo.AddAsync(novoJogo);
            await context.SaveChangesAsync();
        });

}

}