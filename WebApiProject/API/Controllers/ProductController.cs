using Business.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = _service.GetAll();
            return Ok(data);
        }

        [HttpPost]
        public IActionResult Post(Product product)
        {
            var response = _service.Insert(product);
            return Ok(response);
        }

        [HttpPut]
        public IActionResult Put(Product product)
        {
            var response = _service.Update(product);
            return Ok(response);
        }

        [HttpDelete]
        public IActionResult Delete(Product product)
        {
            var response = _service.Delete(product);
            return Ok(response);
        }
    }
}
