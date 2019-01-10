using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnLineStore.Core.BusinessLayer.Responses
{
    public class Response : IResponse
    {
        public string Message { get; set; }
        public bool DidError { get; set; }
        public string ErrorMessage { get; set; }
    }
}
