﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OnLineStore.Core.BusinessLayer.Contracts;

namespace OnLineStore.Core.BusinessLayer.Responses
{
    public static class ResponseExtensions
    {
        public static void SetError(this IResponse response, ILogger logger, string actionName, Exception ex)
        {
            // todo: Save error in log file

            response.DidError = true;

            if (ex is OnLineStoreException cast)
            {
                logger?.LogError("There was an error on '{0}': {1}", actionName, ex);

                response.ErrorMessage = ex.Message;
            }
            else
            {
                logger?.LogCritical("There was a critical error on '{0}': {1}", actionName, ex);

                response.ErrorMessage = "There was an internal error, please contact to technical support.";
            }
        }
    }
}
