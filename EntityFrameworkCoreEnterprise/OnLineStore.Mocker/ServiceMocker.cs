using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnLineStore.Common;
using OnLineStore.Core;
using OnLineStore.Core.BusinessLayer;
using OnLineStore.Core.BusinessLayer.Contracts;



namespace OnLineStore.Mocker
{
    public static class ServiceMocker
    {

        public static ISalesService GetSalesService()
                    => new SalesService(LoggingHelper.GetLogger<SalesService>(), new UserInfo("mocker"), DbContextMocker.GetOnLineStoreDbContext());
        /*--
        public static IWarehouseService GetWarehouseService()
            => new WarehouseService(LoggingHelper.GetLogger<WarehouseService>(), new UserInfo("mocker"), DbContextMocker.GetOnLineStoreDbContext());

        --*/


    }
}
