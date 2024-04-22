public static class BichosRotas
{
    public static void AddRotasBichos(this WebApplication app){
        var rotasBicho = app.MapGroup("Bichos");
        //vamos criar uma rota para criar Bichos
        //Para criar usar post
        rotasBicho.MapPost("",async (AddBichosRequest request,AppDbContext context)=>
        {  
            var novoBicho= new Bichos(request.nome,request.numero,request.id);
            await context.Bichos.AddAsync(novoBicho);
            await context.SaveChangesAsync();
        });

}

}