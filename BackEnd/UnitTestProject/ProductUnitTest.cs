using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp_Backend.Controllers;
using System;
using System.Collections.Generic;
using Xunit;

namespace UnitTestProject
{
    public class ProductUnitTest
    {
        ProductController productController;
        public ProductUnitTest()
        {
            productController = new ProductController();
        }

        [Fact]
        public void validateProducts()
        {
            //Arrange
            int testcategoryid = 1;

            //Act
            var result = productController.GetProductsByCategory(testcategoryid);

            //Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void validateCategoryIdOfProduct()
        {
            //Arrange
            int testcategoryid = 0;
            
            //Assert
            Assert.Throws<ArgumentOutOfRangeException>(
                    () => productController.GetProductsByCategory(testcategoryid)
                );
        }

    }
}
