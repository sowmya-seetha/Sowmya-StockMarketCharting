using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Admin.Entities
{
    [Table("StockExchange")]
    public class StockExchange
    {
        [Key]
        [Required]
        public int StockExchangeId { get; set; }
        [Required]
        [StringLength(30)]
        public string StockExchangeName { get; set; }
        [Required]
        [StringLength(30)]
        public string Description { get; set; }
        [Required]
        [StringLength(30)]
        public string Address { get; set; }
        [Required]
        [StringLength(30)]
       public string Remarks { get; set; }
  

    }
}
