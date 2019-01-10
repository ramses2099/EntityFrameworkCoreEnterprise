using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnLineStore.Core.DataLayer;

namespace OnLineStore.Core.BusinessLayer.Contracts
{
    public interface IService
    {
        OnLineStoreDbContext DbContext { get; }
    }
}
