using MeuCondo.Entities;
using Microsoft.EntityFrameworkCore;

namespace MeuCondo.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }

        public DbSet<Morador> mc_moradores { get; set; }
        public DbSet<Visitante> mc_visitantes { get; set; }
        public DbSet<Funcionario> mc_funcionario { get; set; }


    }
}
