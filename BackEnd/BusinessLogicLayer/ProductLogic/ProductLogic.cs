using DataAccessLayer.Interfaces;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.ProductLogic
{
    public class ProductLogic
    {
        private Iproduct _product = new DataAccessLayer.Functions.ProductFunctions();
        public List<Product> GetAllProductsByCategory(int id)
        {
            List<Product> products = _product.GetAllProductsByCategory(id);
            return products;
        }
    }
}
