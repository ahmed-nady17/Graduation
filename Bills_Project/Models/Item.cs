using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Bills_Project.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string TypeName { get; set; }
        public string ItemName { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal BuyingPrice { get; set; }
        public string Notes { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }
        [ForeignKey("Type")]
        public int TypeId { get; set; }
        public virtual Admin Admin { get; set; }
        public virtual Type Type { get; set; }
    }
}
