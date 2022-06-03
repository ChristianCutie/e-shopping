using System;
using System.ComponentModel.DataAnnotations;

namespace e_shopping.Models
{
    public class register
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage ="*Required")]
        [StringLength(25)]
        public string Name { get; set; }
        [Required(ErrorMessage ="*Required")]
        [StringLength(25)]
        public string Lastname { get; set; }
        [Required(ErrorMessage ="*Required")]
        [StringLength(30)]
        public string Username { get; set; }
        [Required(ErrorMessage ="*Required")]
        [StringLength(20)]
        public string Password { get; set; } 
        [Required(ErrorMessage ="*Required")]
        [Compare("Password")]
        public string ConPassword { get; set; }
        [Required(ErrorMessage ="*Required")]
        [StringLength(15)]
        public int Phonenumber { get; set; }      
           
    }
}
