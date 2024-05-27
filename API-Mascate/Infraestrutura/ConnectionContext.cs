using API_Mascate.Model;
using API_Mascate.Model.Client;
using API_Mascate.Model.employee;
using API_Mascate.Model.reservation;
using API_Mascate.Model.table;
using Microsoft.EntityFrameworkCore;


namespace API_Mascate.Infraestrutura
{
    public class ConnectionContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Client> Client { get; set; }
        public DbSet<Table> Table { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
         => optionsBuilder.UseNpgsql(
             "Server=localhost;" +
             "Port=5432;Database=new_employee;" +
             "User Id=postgres;" +
             "Password=123456;");
    }
}
