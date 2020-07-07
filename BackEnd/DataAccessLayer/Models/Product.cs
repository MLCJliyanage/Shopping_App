using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DataAccessLayer.Models
{
    public class Product
    {
        [Key]
        public int Product_id { get; set; } 
        [Required]
        public string Product_name { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public double Discount { get; set; }
        [Required]
        public string Image { get; set; }
        [Required]
        public int Quantity { get; set; }
        [ForeignKey("Category")]
        public int category_id { get; set; }
        public Category Category { get; set; }
    }
}
