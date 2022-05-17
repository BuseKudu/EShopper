using EShopper.DataAccess.Abstract;
using EShopper.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EShopper.DataAccess.Concrete.Memory
{
    public class MemoryProductDal : IProductDal
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            var products = new List<Product>()
            {
                new Product() { Id = 1, Name = "İPhone X", ImageUrl = "1.jpg", Price = 10000 },
                new Product() { Id = 1, Name = "İPhone 10S", ImageUrl = "2.jpg", Price = 15000 },
                new Product() { Id = 1, Name = "Samsung XS10", ImageUrl = "3.jpg", Price = 20000 },
                new Product() { Id = 1, Name = "Xiaomi RedMi10", ImageUrl = "4.jpg", Price = 17000 },
                new Product() { Id = 1, Name = "İPhone XR9", ImageUrl = "5.jpg", Price = 23000 }
            };
            return products;
        }

        public Product GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Product GetOne(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetPopularProducts()
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
