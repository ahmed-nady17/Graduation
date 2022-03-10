using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Graduation_project.Models
{
    public class SalesInvoice
    {
        public int Id { get; set; }
        public DateTime BillsDate { get; set; }
        public string ClientName { get; set; }

        public string ItemsName { get; set; }
        public decimal SellingPrice {get; set; }
        public decimal Quintity { get; set; }
        public decimal Total { get; set; }
        public decimal BillsTotal { get; set; }
        public decimal PercentageDiscount { get; set; }
        public decimal ValueDiscount { get; set; }
        public decimal TheNet { get; set; }
        public decimal PaidUp { get; set; }
        public decimal TheRest { get; set; }
        public string EmployeeName { get; set; }
        public  DateTime Date { get; set; }
        public string StartTime { get; set; }
        public  string EndTime { get; set; }
        [ForeignKey("Admin")]
        public int AdminId { get; set; }

        public virtual Admin Admin { get; set; }

    }
}
