using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Core.BusinessLayer.Contracts
{
    public class OnLineStoreException : Exception
    {
        public OnLineStoreException()
            : base()
        {
        }

        public OnLineStoreException(string message)
            : base(message)
        {
        }
    }
}
