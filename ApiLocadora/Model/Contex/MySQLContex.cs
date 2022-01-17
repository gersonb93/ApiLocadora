using Microsoft.EntityFrameworkCore;


namespace ApiLocadora.Model.Contex
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Filme> Filmes { get; set; }
        public DbSet<Locacao> Locacao { get; set; }
    }
}
