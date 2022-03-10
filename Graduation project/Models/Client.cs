using Graduation_project.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_project.Models
 
{
    public class Client
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string Phone { get; set; }
        public int Number { get; set; }
        public string Address { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }

        public virtual Admin Admin { get;set;}
      
        
    }
}
