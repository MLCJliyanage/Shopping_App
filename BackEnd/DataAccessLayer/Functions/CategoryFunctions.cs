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
    public class CategoryFunctions: Icategory
    {
        //add new category
        public async Task<Category> Addcategory(string category_name)
        {
            Category newcategory = new Category
            {
                Category_name = category_name
            };
            using(var context = new ShoppingAppContext(ShoppingAppContext.ops.dbOptions))
            {
                await context.AddAsync(newcategory);
                await context.SaveChangesAsync();
            }

            return newcategory;
        }

        //get all categories
        public List<Category> GetAllCategories()
        {
            List<Category> categories = new List<Category>();
            using (var context = new ShoppingAppContext(ShoppingAppContext.ops.dbOptions))
            {
                categories = context.Categories.ToList();
            }
            return categories;
        }
    }
}
