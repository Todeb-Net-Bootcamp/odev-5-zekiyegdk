using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Entities
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ProductDetail { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public string QuantityPerUnit { get; set; }

        public int CategoryID { get; set; }


        [ForeignKey("CategoryID")]
        public Category Category { get; set; }
    }
}
