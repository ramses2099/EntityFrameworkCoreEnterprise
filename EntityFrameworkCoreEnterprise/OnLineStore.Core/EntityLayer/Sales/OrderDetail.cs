using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Core.EntityLayer.Sales
{
    public class OrderDetail : IAuditableEntity
    {

        public OrderDetail() { }

        public OrderDetail(long orderHeaderID)
        {
            OrderHeaderID = orderHeaderID;
        }

        public long OrderDetailID { get; set; }
        public long OrderHeaderID { get; set; }

        public int ProductID { get; set; }
        public String ProductName { get; set; }
        public Decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public Decimal Total { get; set; }

        public String CreationUser { get; set; }
        public DateTime? CreationDateTime { get; set; }
        public String LastUpdateUser { get; set; }
        public DateTime? LastUpdateDateTime { get; set; }
        public byte[] Timestamp { get; set; }
        
    }
}
