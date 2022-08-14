using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.Entities;
using Business.Configuration.Response;
using DAL.Abstract;
using DTO.Product;
using Business.Configuration.Validator.FluentValidation;
using Business.Configuration.Extensions;
using AutoMapper;

namespace Business.Concrete
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        private IMapper _mapper;

        public ProductService(IProductRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;

        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public CommandResponse Insert(CreateProductRequest request)
        {
            //Validation
            var validator = new CreateProductRequestValidator();
            validator.Validate(request).ThrowIfException();


            var entity = _mapper.Map<Product>(request);
            _repository.Insert(entity);

            return new CommandResponse
            {
                Status = true,
                Message = $"Ürün eklendi."
            };
        }

        public CommandResponse Update(UpdateProductRequest request)
        {
            var validator = new UpdateProductRequestValidator();
            validator.Validate(request).ThrowIfException();

            var entity = _repository.Get(request.Id);
            if(entity == null)
            {
                return new CommandResponse()
                {
                    Status = false,
                    Message = "Kayıt bulunamadı."
                };
            }

            var mapped = _mapper.Map(request,entity);

            _repository.Update(mapped);

            return new CommandResponse
            {
                Status = true,
                Message = $"Ürün güncellendi."
            };
        }
        public CommandResponse Delete(Product product)
        {
            _repository.Delete(product);

            return new CommandResponse
            {
                Status = true,
                Message = $"Ürün silindi. Id={product.Id}"
            };

        }
    }
}

