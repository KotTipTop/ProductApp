using AppTestWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTestWebApi.Dao.Interfaces
{
    public interface IProductDao
    {
        Product Get(int id);
        IList<Product> List();
        Product Save(Product model);
        void Delete(int id);
    }
}
