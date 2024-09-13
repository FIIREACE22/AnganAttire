using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnganAttire.Entities
{
    public class Category : BaseAntity
    {
        public List<Product> Products { get; set; }
    }
}
