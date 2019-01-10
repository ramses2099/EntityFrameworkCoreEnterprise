using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace OnLineStore.Mocker
{
   public class Connection
    {
        public static String ConnectionString { get { return ConfigurationManager.ConnectionStrings["OnLineStoreConnectionString"].ConnectionString; } }

    }
}
