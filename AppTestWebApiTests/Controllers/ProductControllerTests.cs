using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppTestWebApi.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppTestWebApi.Models;

namespace AppTestWebApi.Controllers.Tests
{
    [TestClass()]
    public class ProductControllerTests
    {

        [TestMethod()]
        public void GetAllTest()
        {
           
        }

        [TestMethod()]
        public void GetTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PostTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void PutTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void DeleteTest()
        {
            Assert.Fail();
        }
        private List<Product> GetTestProducts()
        {
            var testProducts = new List<Product>();
            testProducts.Add(new Product { id = 1, name = "Demo1", category = "test",  price = 1 });
            testProducts.Add(new Product { id = 2, name = "Demo2", category = "test", price = 1 });
            testProducts.Add(new Product { id = 3, name = "Demo3", category = "test", price = 1 });
            testProducts.Add(new Product { id = 4, name = "Demo4", category = "test", price = 1 });

            return testProducts;
        }
    }
}