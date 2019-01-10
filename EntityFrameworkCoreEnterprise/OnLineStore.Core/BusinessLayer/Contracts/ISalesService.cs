using OnLineStore.Core.BusinessLayer.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnLineStore.Core.EntityLayer;
using OnLineStore.Core.EntityLayer.Sales;
using OnLineStore.Core.BusinessLayer.Contracts;
using OnLineStore.Core.BusinessLayer.Requests;

namespace OnLineStore.Core.BusinessLayer.Contracts
{
    public interface ISalesService: IService
    {

       Task<IPagedResponse<Customer>> GetCustomersAsync(int pageSize = 10, int pageNumber = 1);

       // Task<IPagedResponse<Shipper>> GetShippersAsync(int pageSize = 10, int pageNumber = 1);

       // Task<IPagedResponse<Currency>> GetCurrenciesAsync(int pageSize = 10, int pageNumber = 1);

       // Task<IPagedResponse<PaymentMethod>> GetPaymentMethodsAsync(int pageSize = 10, int pageNumber = 1);

       // Task<IPagedResponse<OrderInfo>> GetOrdersAsync(int pageSize = 10, int pageNumber = 1, short? orderStatusID = null, int? customerID = null, int? employeeID = null, int? shipperID = null, short? currencyID = null, Guid? paymentMethodID = null);

        Task<ISingleResponse<OrderHeader>> GetOrderAsync(long id);

        //Task<ISingleResponse<CreateOrderRequest>> GetCreateOrderRequestAsync();

        Task<ISingleResponse<OrderHeader>> CreateOrderAsync(OrderHeader header, OrderDetail[] details);

        Task<ISingleResponse<OrderHeader>> CloneOrderAsync(long id);

        Task<IResponse> RemoveOrderAsync(long id);

    }
}
