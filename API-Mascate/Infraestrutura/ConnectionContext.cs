using API_Mascate.Model;
using Microsoft.EntityFrameworkCore;



namespace API_Mascate.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseNpgsql(
             "Server=localhost;" +
             "Port=5432;Database=new_employee;" +
             "User Id=postgres;" +
             "Password=123456;");
    }
}
