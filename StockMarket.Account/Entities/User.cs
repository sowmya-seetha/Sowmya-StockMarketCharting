using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Account.Entities
{
    
    [Table("User")]
    public class User
    {
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
        [Key]
        [StringLength(30)]
        [Required]
        public string UserEmail { get; set; }

        [Required]
        //   [StringLength(30)]
        public int mobilenum { get; set; }

        [Required]
        [StringLength(30)]
        public string UserPassword { get; set; }


    }
}
