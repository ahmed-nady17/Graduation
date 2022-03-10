using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_project.Models
{
    public class Type
    {
        public Type()
        {
            items = new HashSet<Item>();
        }
      public  int id { get; set; }
      public  string CompanyName { get; set; }
      public  string TypeName { get; set; }
      public  string Notes { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }
        public virtual ICollection<Item> items { get; set; }

    }
}