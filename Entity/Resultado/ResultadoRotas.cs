public static class ResultadoRotas
{
    public static void AddRotasResultado(this WebApplication app){
        var rotasResultado = app.MapGroup("Resultado");
        //vamos criar uma rota para criar clientes
        //Para criar usar post
        rotasResultado.MapPost("",async (AddResultadoRequest request,AppDbContext context)=>
        {  
            var novoResultado= new Resultado(request.nomeAnimal,request.numero,request.id);
            await context.Resultado.AddAsync(novoResultado);
            await context.SaveChangesAsync();
        });

}

}