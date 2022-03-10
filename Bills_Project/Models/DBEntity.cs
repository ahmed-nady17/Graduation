using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Bills_Project.Models
{
    public class DBEntity: IdentityDbContext
    {
        public DBEntity()
        {

        }
        public DBEntity(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Client> clients { get; set; }
        public DbSet<CompanyData> companyDatas { get; set; }
        public DbSet<Item> items { get; set; }

        public DbSet<SalesInvoice> salesInvoices { get; set; }

        public DbSet<SalesReport> salesReports { get; set; }

        public DbSet<Type> types { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseLazyLoadingProxies();
            //don't forget to change!!
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-2S4PV11\\SQLEXPRESS;Initial Catalog=GradiuationDB;Integrated Security=True");

        }
    }
}
