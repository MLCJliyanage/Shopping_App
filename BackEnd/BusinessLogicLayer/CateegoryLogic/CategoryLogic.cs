using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.CateegoryLogic
{
    public class CategoryLogic
    {
        private Icategory _category = new DataAccessLayer.Functions.CategoryFunctions();

        //Add new Category
        public async Task<Boolean> CreateNewUser(string category_name)
        {
            try
            {
                var result = await _category.Addcategory(category_name);
                if (result.Category_id > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            } catch(Exception e)
            {
                return false;
            }
        }

        public List<Category> GetAllCategories()
        {
            List<Category> categories = _category.GetAllCategories();
            return categories;
        }
    }
}
