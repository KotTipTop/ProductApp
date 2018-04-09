using AppTestWebApi.Dao.Interfaces;
using AppTestWebApi.Data;
using AppTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppTestWebApi.Dao
{
    public class ProductDao : IProductDao
    {
        public void Delete(int id)
        {
            using (var db = new ProductDBEntities())
            {
                var obj = db.Products.SingleOrDefault(o => o.id == id);
                db.Products.Remove(obj);
                db.SaveChanges();
            }
        }

        public Product Get(int id)
        {
            using (var db = new ProductDBEntities())
            {
                var obj = db.Products.SingleOrDefault(o => o.id == id);
                return ConvertToModel(obj);
            }

        }

        public IList<Product> List()
        {
            using (var db = new ProductDBEntities())
            {
               return db.Products.ToList().Select(o => ConvertToModel(o)).ToList();
            }
        }

        public Product Save(Product model)
        {
            using (var db = new ProductDBEntities())
            {
                if (model.id != 0)
                {
                    var obj1 = db.Products.SingleOrDefault(o => o.id == model.id);
                    obj1.name = model.name;
                    obj1.category = model.category;
                    obj1.price = model.price;
                    db.SaveChanges();
                }
                else
                {
                    var obj2 = new Products();
                    obj2.name = model.name;
                    obj2.category = model.category;
                    obj2.price = model.price;
                    db.Products.Add(obj2);
                    model.id = obj2.id;
                    db.SaveChanges();
                }
                return model;
            }
        }
        public Product ConvertToModel(Products o)
        {
            return new Product() { id = o.id, name = o.name, category = o.category, price = o.price };
        }
    }
}