using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Core.EntityLayer.Warehouse
{
    public class Product : IAuditableEntity
    {
        public Product() { }

        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public int ProductCategoryID { get; set; }
        public Decimal UnitPrice { get; set; }
        public String Description { get; set; }
        public byte Discontinued { get; set; }
        public int Stocks { get; set; }
        public string CreationUser { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
