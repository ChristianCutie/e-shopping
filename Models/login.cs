using System;
using System.ComponentModel.DataAnnotations;

namespace e_shopping.Models
{
    public class login
    {
    [Key]
     public int MyID { get; set; }
     [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`
     {|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z",
     ErrorMessage = "Please enter a valid email address")]
     [Required(ErrorMessage ="")]
     [StringLength(30)]
     public string Username { get; set; }
     [Required]
     [StringLength(30)]
    public string Password { get; set; }
    }
}