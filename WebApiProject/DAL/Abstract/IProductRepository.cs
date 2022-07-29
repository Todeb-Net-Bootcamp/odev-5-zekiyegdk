using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Abstract
{
    public interface IProductRepository
    {

        public IEnumerable<Product> GetAll();
        public void Insert(Product product);
        public void Update(Product product);
        public void Delete(Product product);


    }
}
