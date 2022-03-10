using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_project.Models
{
    public class SalesReport
    {
        public int Id { get; set; }
       public DateTime PeriodFrom { get; set; }
        public DateTime PeriodTo { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }

    }
}
