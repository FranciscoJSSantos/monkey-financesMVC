using Microsoft.EntityFrameworkCore;
using MonkeyFinancesMVC.Models;

namespace MonkeyFinancesMVC.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options): base(options)
        {

        }

        public DbSet<RegistroModel> Registro { get; set; }
    }
}
