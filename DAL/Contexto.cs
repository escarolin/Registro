using Microsoft.EntityFrameworkCore;
namespace Registro.DAL{

public class Contexto: DbContext{
    public DbSet<Actores> Actores {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlite(@"Data Source=Peliculas.db");

    }
}
}