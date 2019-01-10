using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Core.EntityLayer.Sales
{
    public class Customer : IAuditableEntity
    {

        public Customer() { }

        public int CustomerID { get; set; }
        public String CompanyName { get; set; }
        public String ContactName { get; set; }
        public string CreationUser { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public string LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }
    }
}
