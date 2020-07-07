using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using BusinessLogicLayer.ProductLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Models;
using Newtonsoft.Json;
using ShoppingApp_Backend.Security;

namespace ShoppingApp_Backend.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("Product/")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private ProductLogic productLogic = new ProductLogic();
        private EncryptDecrypt encryptDecrypt = new EncryptDecrypt();

        [Route("get/{id}")]
        [HttpGet]
        public IActionResult GetProductsByCategory(int id) 
        {
            if(id <= 0)
            {
                throw new ArgumentOutOfRangeException("Category id is not valid");
            }
            try
            {
                var products = productLogic.GetAllProductsByCategory(id);
                string jsonstring = JsonConvert.SerializeObject(products);
                byte[] encrypted = encryptDecrypt.EncryptStringToBytes_Aes(jsonstring);
                return Ok(encrypted);
            } catch(Exception e)
            {
                return NotFound(e);
            }
            
        }
    }
}
