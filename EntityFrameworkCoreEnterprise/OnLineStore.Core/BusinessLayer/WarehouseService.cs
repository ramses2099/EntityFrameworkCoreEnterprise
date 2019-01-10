
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using OnLineStore.Core.BusinessLayer.Contracts;
using OnLineStore.Core.BusinessLayer.Responses;
using OnLineStore.Core.DataLayer;
using OnLineStore.Core.DataLayer.Repositories;
using OnLineStore.Core.EntityLayer.Warehouse;

namespace OnLineStore.Core.BusinessLayer
{
    public class WarehouseService : Service, IWarehouseService
    {
        public WarehouseService(ILogger<WarehouseService> logger, IUserInfo userInfo, OnLineStoreDbContext dbContext) : base(logger, userInfo, dbContext) { }

        public IPagedResponse<Product> GetProduct(int pageSize = 10, int pageNumber = 1)
        {
            Logger?.LogDebug("{0} has been invoked", nameof(GetProduct));

            var response = new PagedResponse<Product>();

            try
            {
                //Get Query
                var query = DbContext.Product;

                //Set information for paging
                response.PageSize = pageSize;
                response.PageNumber = pageNumber;
                response.ItemsCount = query.Count();

                response.Model = query
                    .Paging(pageSize, pageNumber)
                    .ToList();

            }
            catch (Exception ex)
            {

                response.SetError(Logger, nameof(GetProductsAsync), ex);
            }


            return response;
        }

        public async Task<IPagedResponse<Product>> GetProductsAsync(int pageSize = 10, int pageNumber = 1)
        {

            Logger?.LogDebug("{0} has been invoked", nameof(GetProductsAsync));

            var response = new PagedResponse<Product>();

            try
            {
                //Get Query
                var query = DbContext.Product;

                //Set information for paging
                response.PageSize = pageSize;
                response.PageNumber = pageNumber;
                response.ItemsCount = await query.CountAsync();

                response.Model = await query
                    .Paging(pageSize, pageNumber)
                    .ToListAsync();
                
            }
            catch (Exception ex)
            {

                response.SetError(Logger, nameof(GetProductsAsync), ex);
            }


            return response;
        }


    }
}
