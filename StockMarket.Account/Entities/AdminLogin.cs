using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Account.Entities
{
    [Table("AdminLogin")]
    public class AdminLogin
    {
        [Key]
        [StringLength(30)]
        [Required]
        public string AdminEmail { get; set; }
        [Required]
        [StringLength(30)]
        public string AdminPassword { get; set; }
    }
}
