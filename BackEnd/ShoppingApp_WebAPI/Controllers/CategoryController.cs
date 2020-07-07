using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.Models;
using BusinessLogicLayer.CateegoryLogic;
using Microsoft.AspNetCore.Cors;
using System;
using System.Security.Cryptography;
using System.IO;
using Newtonsoft.Json;
using System.Text;
using ShoppingApp_Backend.Security;
using Microsoft.Extensions.Configuration;

namespace ShoppingApp_Backend.Controllers
{
    //[Microsoft.AspNetCore.Cors.EnableCors(origins: "*", headers: "*", methods: "*")]
    [EnableCors("MyPolicy")]
    [Route("Category/")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private CategoryLogic categoryLogic = new CategoryLogic();
        private EncryptDecrypt encryptDecrypt = new EncryptDecrypt();

        [Route("get")]
        [HttpGet]
        public IActionResult GetCategories()
        {
                try
                {
                    
                    var categories = categoryLogic.GetAllCategories();
                    string doi = JsonConvert.SerializeObject(categories);
                    byte[] encrypted =  encryptDecrypt.EncryptStringToBytes_Aes(doi);
                    //var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(original);
                    //var pts =  System.Convert.ToBase64String(plainTextBytes);
                    //Console.WriteLine(pts);
                    return Ok(encrypted);
                }
                catch (Exception e)
                {
                    return NotFound(e);
                }     
        }



    }
}
