using System;
using System.ComponentModel.DataAnnotations;

namespace e_shopping.Models
{
    public class Categories
    {
        [Key]
        public int OrderID { get; set; }
        [Required]
        [StringLength(50)]
        public string FullName { get; set; }
        public double ProductCost { get; set; }
        [Required]
        [StringLength(50)]
        public string PaymentMode { get; set; }
        [Required]
        [StringLength(50)]
        public string StartDate { get; set; }
        [Required]
        [StringLength(50)]
        public string PaymentStatus { get; set; }
    }
}