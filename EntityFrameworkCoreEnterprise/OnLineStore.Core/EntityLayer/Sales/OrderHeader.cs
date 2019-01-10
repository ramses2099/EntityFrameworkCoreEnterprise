using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace OnLineStore.Core.EntityLayer.Sales
{
    public class OrderHeader: IAuditableEntity
    {

        public OrderHeader() { }

        public OrderHeader(long? orderHeaderID)
        {
            OrderHeaderID = orderHeaderID;
        }

        public long? OrderHeaderID { get; set; }

        public short? OrderStatusID { get; set; }

        public DateTime? OrderDate { get; set; }

        public int? CustomerID { get; set; }

        public int? EmployeeID { get; set; }

        public int? ShipperID { get; set; }

        public decimal? Total { get; set; }

        public short? CurrencyID { get; set; }

        public Guid? PaymentMethodID { get; set; }

        public int? DetailsCount { get; set; }

        public long? ReferenceOrderID { get; set; }

        public string Comments { get; set; }

        public string CreationUser { get; set; }

        public DateTime? CreationDateTime { get; set; }

        public string LastUpdateUser { get; set; }

        public DateTime? LastUpdateDateTime { get; set; }

        public byte[] Timestamp { get; set; }

        public virtual Collection<OrderDetail> OrderDetails { get; set; } = new Collection<OrderDetail>();
        

    }
}
