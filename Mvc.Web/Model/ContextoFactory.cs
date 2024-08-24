using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Mvc.Web.Model;

namespace Mvc.Web.Model
{
    public class ContextoFactory : IDesignTimeDbContextFactory<Contexto>
    {
        public Contexto CreateDbContext(string[] args)
        {
            // Ajuste o caminho base para o diretório do projeto Mvc.Web.API
            var basePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\Mvc.Web");
            var configuration = new ConfigurationBuilder()
                .SetBasePath(basePath)
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<Contexto>();
            var connectionString = configuration.GetConnectionString("MinhaConexao");
            optionsBuilder.UseSqlServer(connectionString);

            return new Contexto(optionsBuilder.Options);
        }
    }
}