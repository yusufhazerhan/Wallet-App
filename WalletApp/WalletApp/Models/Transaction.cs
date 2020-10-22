using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WalletApp.Models
{
    public class Transaction
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [Display(Name = "Name")]
        [StringLength(500, ErrorMessage = "Name is too short", MinimumLength = 3)]
        public string name { get; set; }
        public string type { get; set; }    //Income or Spending

        [Range(-9999,9999)]
        [Display(Name ="Price")]
        public float price { get; set; }
    }
}
