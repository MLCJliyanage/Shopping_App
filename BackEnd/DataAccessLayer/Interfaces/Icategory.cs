using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface Icategory
    {
        Task<Category> Addcategory(string category_name);
        List<Category> GetAllCategories();
    }
}
