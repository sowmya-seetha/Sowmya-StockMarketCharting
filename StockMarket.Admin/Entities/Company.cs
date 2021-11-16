using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace StockMarket.Admin.Entities
{[Table("Company")]
    public class Company
    {
        [Required]
        [StringLength(30)]
        public string CompanyName { get; set; }
        [Key]
        [Required]
        [StringLength(30)]
        public string CompanyCode { get; set; }
        [Required]
        public int ComapnyTurnover { get; set; }
        [Required]
        public string CompanyCEO { get; set; }
        [Required]
        [StringLength(30)]
        public string CompanyBOD { get; set; }
        [Required]
        [StringLength(10)]
        public string StockExchangeName { get; set; }
        [Required]
        [StringLength(20)]
        public string Sectorname { get; set; }
        [Required]
        [StringLength(40)]
        public string Description { get; set; }


    }
}
