using AppTestWebApi.Dao;
using AppTestWebApi.Dao.Interfaces;
using AppTestWebApi.Data;
using AppTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AppTestWebApi.Controllers
{
    public class ProductController : ApiController
    {
        private readonly IProductDao productService;
        public ProductController()
        {
            this.productService = new ProductDao();
        }
        public IHttpActionResult GetAll()
        {
            if(productService.List().Count == 0)
            {
                return NotFound();
            }
            return Ok(productService.List());
            
        }
        public IHttpActionResult Get(int id)
        {
            return Ok(productService.Get(id));
        }
       public IHttpActionResult Post(Product model)
        {
            return Ok(productService.Save(model));
        }
        public IHttpActionResult Put(int id, Product model)
        {
            model.id = id;
            return Ok(productService.Save(model));
        }
        public IHttpActionResult Delete(int id)
        {
            productService.Delete(id);
            return Ok();
        }
    }
}
