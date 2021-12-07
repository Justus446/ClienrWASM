using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienrWASM.Shared
{
    public class ProdInfo
    {
        public int ProductID { get; set; }
        public string SKU { get; set; }

        public string Description { get; set; }
        public int WareID { get; set; }
        public string Warehouse { get; set; }
        public string Location { get; set; }

        public decimal InStock { get; set; }
    }
}
