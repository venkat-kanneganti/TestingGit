using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCAssesment.Models
{
    [Table("Product_Table")]
    public class Product
    {
        [Key]
        public int Pid { get; set; }

        [StringLength(30, ErrorMessage = "Product Name Can only be of 40 Characters")]
        public string Pname { get; set; }

        [ForeignKey("category")]
        public int CategoryId { get; set; }
        
        public virtual Category category { get; set; }

        [ForeignKey("punit")]
        public int UnitId { get; set; }
        
        public virtual ProductUnit punit { get; set; }

        [Range(0,999)]
        public int Quantity { get; set; }

        [Range(0,1000000)]
        public double Pprice { get; set; }
    }
}