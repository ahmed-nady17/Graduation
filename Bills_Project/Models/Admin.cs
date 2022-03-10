using System.Collections.Generic;

namespace Bills_Project.Models
{
    public class Admin
    {
        public Admin()
        {

            Clients = new HashSet<Client>();
            Items = new HashSet<Item>();
            SalesInvoices = new HashSet<SalesInvoice>();
            SalesReports = new HashSet<SalesReport>();
            Types = new HashSet<Type>();
            Units = new HashSet<Unit>();
            CompanyDatas = new HashSet<CompanyData>();

        }

        public virtual ICollection<Client> Clients { get; set; }
        public virtual ICollection<Item> Items { get; set; }
        public virtual ICollection<SalesInvoice> SalesInvoices { get; set; }
        public virtual ICollection<SalesReport> SalesReports { get; set; }
        public virtual ICollection<Type> Types { get; set; }
        public virtual ICollection<Unit> Units { get; set; }
        public virtual ICollection<CompanyData> CompanyDatas { get; set; }
    }
}
