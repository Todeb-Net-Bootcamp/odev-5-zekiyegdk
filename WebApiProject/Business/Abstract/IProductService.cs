using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Configuration.Response;
using Models.Entities;


namespace Business.Abstract
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAll();
        public CommandResponse Insert(Product product);
        public CommandResponse Update(Product product);
        public CommandResponse Delete(Product product);
    }
}
