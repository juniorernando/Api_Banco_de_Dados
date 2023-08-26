using Microsoft.EntityFrameworkCore;
using WebAPiS.Models;

namespace WebAPiS.DataContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }
        
    }
}
