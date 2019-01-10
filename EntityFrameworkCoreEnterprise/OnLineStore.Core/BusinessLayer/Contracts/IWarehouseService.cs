using OnLineStore.Core.BusinessLayer.Responses;
using OnLineStore.Core.EntityLayer.Warehouse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Core.BusinessLayer.Contracts
{
    public interface IWarehouseService : IService
    {

        Task<IPagedResponse<Product>> GetProductsAsync(int pageSize = 10, int pageNumber = 1);
        IPagedResponse<Product> GetProduct(int pageSize = 10, int pageNumber = 1);

    }
}
