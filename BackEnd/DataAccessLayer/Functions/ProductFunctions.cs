using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Functions
{
    public class ProductFunctions: Iproduct
    {
        public List<Product> GetAllProductsByCategory(int id)
        {

            if(id <= 0)
            {
                throw new ArgumentException("Category id is invalid");
            }

            List<Product> products = new List<Product>();
            using (var context = new ShoppingAppContext(ShoppingAppContext.ops.dbOptions))
            {
                products = context.Products.Where(s => s.category_id == id).ToList();
            }
            return products;
        }
    }
}
