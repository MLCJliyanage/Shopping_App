using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Interfaces
{
    public interface Iproduct
    {
        List<Product> GetAllProductsByCategory(int id);
    }
}
