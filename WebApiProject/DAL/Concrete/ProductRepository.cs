using DAL.Abstract;
using DAL.DbContexts;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Concrete
{
    public class ProductRepository : IProductRepository
    {
        private ApiProjectContexts contexts;

        public ProductRepository(ApiProjectContexts contexts)
        {
            this.contexts = contexts;

        }

        public IEnumerable<Product> GetAll()
        {
            return contexts.Products.ToList();
        }

        public void Insert(Product product)
        {
            contexts.Products.Add(product);
            contexts.SaveChanges();
        }

        public void Update(Product product)
        {
            contexts.Products.Update(product);
            contexts.SaveChanges();

        }

        public void Delete(Product product)
        {
            contexts.Products.Remove(product);
            contexts.SaveChanges();
        }
        public Product Get(int id)
        {
            return contexts.Products.FirstOrDefault(x => x.Id == id);
        }
    }
}
