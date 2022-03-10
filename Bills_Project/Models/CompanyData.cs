using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_Project.Models
{
    public class CompanyData
    {
        public int id { get; set; }
        public string CompanyName { get; set; }
        public string Notes { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }
    }
}
