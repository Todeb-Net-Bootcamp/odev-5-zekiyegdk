using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO.Product
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductDetail { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public string QuantityPerUnit { get; set; }
    }
}
