using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_project.Models
{
    public class Unit
    {
     public   int id { get; set; }
     public  string UnitName { get; set; }
     public string Notes { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }

    }

}

