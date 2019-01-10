using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnLineStore.Core.BusinessLayer.Contracts;
using OnLineStore.Core.BusinessLayer.Requests;
using OnLineStore.Core.BusinessLayer.Responses;
using OnLineStore.Core.DataLayer;
using OnLineStore.Core.DataLayer.Repositories;
using OnLineStore.Core.EntityLayer.Sales;

namespace OnLineStore.Core.BusinessLayer
{
    public class SalesService : Service, ISalesService
    {


        public SalesService(ILogger<SalesService> logger, IUserInfo userInfo, OnLineStoreDbContext dbContext)
            : base(logger, userInfo, dbContext)
        {
        }

        public async Task<IPagedResponse<Customer>> GetCustomersAsync(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogDebug("{0} has been invoked", nameof(GetCustomersAsync));

            var response = new PagedResponse<Customer>();

            try
            {
                // Get query
                var query = DbContext.Customer;

                // Set information for paging
                response.PageSize = pageSize;
                response.PageNumber = pageNumber;
                response.ItemsCount = await query.CountAsync();

                // Retrieve items, set model for response
                response.Model = await query
                    .Paging(pageSize, pageNumber)
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                response.SetError(Logger, nameof(GetCustomersAsync), ex);
            }

            return response;
        }


        public Task<ISingleResponse<OrderHeader>> CloneOrderAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<ISingleResponse<OrderHeader>> CreateOrderAsync(OrderHeader header, OrderDetail[] details)
        {
            throw new NotImplementedException();
        }

       
        /*--
        public async Task<ISingleResponse<CreateOrderRequest>> GetCreateOrderRequestAsync()
        {
            throw new NotImplementedException();
        }
        --*/
        public Task<ISingleResponse<OrderHeader>> GetOrderAsync(long id)
        {
            throw new NotImplementedException();
        }

        public Task<IResponse> RemoveOrderAsync(long id)
        {
            throw new NotImplementedException();
        }
    }



}

