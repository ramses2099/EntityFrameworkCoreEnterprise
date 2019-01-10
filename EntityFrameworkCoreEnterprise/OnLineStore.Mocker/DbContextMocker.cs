using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using Microsoft.Extensions.Configuration;
using OnLineStore.Core.DataLayer;


namespace OnLineStore.Mocker
{
    public static class DbContextMocker
    {
        private static readonly string ConnectionString;

        static DbContextMocker()
        {            
            ConnectionString = Connection.ConnectionString; 
        }

        public static OnLineStoreDbContext GetOnLineStoreDbContext()
            => new OnLineStoreDbContext(new DbContextOptionsBuilder<OnLineStoreDbContext>().UseSqlServer(ConnectionString).Options);

    }
}
