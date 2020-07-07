using DataAccessLayer.Models;
using Microsoft.AspNetCore.Mvc;
using ShoppingApp_Backend.Controllers;
using System.Collections.Generic;
using Xunit;

namespace UnitTestProject
{
    public class CategoryUnitTest
    {
        CategoryController categoryController;
        public CategoryUnitTest()
        {
            categoryController = new CategoryController();
        }

        [Fact]
        public void validateGetCategories()
        {
            var result = categoryController.GetCategories();
            Assert.IsType<OkObjectResult>(result);
        }

    }
}
