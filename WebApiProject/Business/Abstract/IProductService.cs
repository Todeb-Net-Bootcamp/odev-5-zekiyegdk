using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Configuration.Response;
using DTO.Product;
using Models.Entities;


namespace Business.Abstract
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAll();
        public CommandResponse Insert(CreateProductRequest request);
        public CommandResponse Update(UpdateProductRequest request);
        public CommandResponse Delete(Product product);
    }
}
