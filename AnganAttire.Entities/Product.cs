using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnganAttire.Entities
{
    public class Product : BaseAntity
    {
        public Category Category { get; set; }
        public decimal Price { get; set; }
    }
}
