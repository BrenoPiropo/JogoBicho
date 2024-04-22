public static class ClientesRotas
{
    public static void AddRotasClientes(this WebApplication app){
        var rotasClientes = app.MapGroup("Cliente");
        //vamos criar uma rota para criar clientes
        //Para criar usar post
        rotasClientes.MapPost("",async (AddClienteRequest request,AppDbContext context)=>
        {  
            var novoCliente= new Cliente(request.nome,request.email,request.senha);
            await context.Clientes.AddAsync(novoCliente);
            await context.SaveChangesAsync();
        });

}

}