using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCAssesment.Models
{
    [Table("UnitTable")]
    public class ProductUnit
    {
        [Key]
        public int UnitId { get; set; }

        public string Name { get; set; }
    }
}