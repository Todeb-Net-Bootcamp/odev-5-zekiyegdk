using DTO.Product;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Configuration.Validator.FluentValidation
{
    public class CreateProductRequestValidator: AbstractValidator<CreateProductRequest>
    {
        public CreateProductRequestValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ürün adı yazılması zorunludur.");
            RuleFor(x => x.UnitPrice).NotEmpty().WithMessage("Ürün fiyatı yazılması zorunludur.");
            RuleFor(x => x.ProductDetail).NotEmpty();
            RuleFor(x => x.UnitInStock).NotEmpty();
            RuleFor(x => x.UnitsOnOrder);
            RuleFor(x => x.QuantityPerUnit);




        }
    }
}
