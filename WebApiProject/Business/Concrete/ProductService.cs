using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Business.Configuration.Response;
using DAL.Abstract;

namespace Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;

        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public CommandResponse Insert(Product product)
        {
            _repository.Insert(product);

            return new CommandResponse
            {
                Status = true,
                Message = $"Ürün eklendi. Id={product.Id}"
            };
        }

        public CommandResponse Update(Product product)
        {
            return new CommandResponse
            {
                Status = true,
                Message = $"Ürün güncellendi. Id={product.Id}"
            };
        }
        public CommandResponse Delete(Product product)
        {
            _repository.Delete(product);

        }
    }
}
