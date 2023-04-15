using Microsoft.EntityFrameworkCore;
using WebApi.Model;

namespace WebApi.Repository
{
    public class BaseContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public BaseContext(IConfiguration configuration)
        {   
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to mysql with connection string from app settings
            var connectionString = Configuration.GetConnectionString("WebApiBaseContext");
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Estoque> Estoques { get; set; }
        public DbSet<Home> Homes { get; set; }
        public DbSet<Produtocs> Produtos { get; set; }
        public DbSet<TvBmw> TvBmws { get; set; }
        public DbSet<Amor> Amores { get; set; }




    }
}
