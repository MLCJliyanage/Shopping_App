using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Category
    {
        [Key]
        public int Category_id { get; set; }
        [Required]
        public string Category_name { get; set; }
        
        [Column(TypeName ="text")]
        public string Description { get; set; }
       
        public List<Product> Products { get; set; }
    }
}
