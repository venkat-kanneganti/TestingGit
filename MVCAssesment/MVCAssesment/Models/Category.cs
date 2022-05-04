using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCAssesment.Models
{
    [Table("Category_Table")]
    public class Category
    {
        
        [Key]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Please Enter Category Name")]
        [Display(Name = "Category Name : ")]
        [StringLength(30, ErrorMessage = "Category Name Can only be of 30 Characters")]
        public string CategoryName { get; set; }
       

    }
}