using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<Bichos> Bichos { get; set; } // DbSet para a tabela Bichos
    public DbSet<Jogo> Jogo { get; set; } // DbSet para a nova tabela Jogo
    public DbSet<Resultado> Resultado { get; set; } // DbSet para a nova tabela Resultados

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Banco.sqlite");
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configuração do modelo, se necessário
        // Por exemplo, chaves primárias, chaves estrangeiras, etc.
        modelBuilder.Entity<Bichos>()
            .HasKey(b => b.Id); // Define a propriedade Id como chave primária para a tabela Bichos

        modelBuilder.Entity<Jogo>()
            .HasKey(j => j.IdJogo); // Define a propriedade Id como chave primária para a tabela Jogo

        modelBuilder.Entity<Resultado>()
            .HasKey(r => r.Id); // Define a propriedade Id como chave primária para a tabela Resultados

        base.OnModelCreating(modelBuilder);
    }
}
