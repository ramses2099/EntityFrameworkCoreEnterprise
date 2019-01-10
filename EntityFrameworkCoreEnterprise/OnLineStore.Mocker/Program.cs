using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OnLineStore.Common;

namespace OnLineStore.Mocker
{
    class Program
    {

        private static readonly ILogger Logger;

        static Program() {
            Logger = LoggingHelper.GetLogger<Program>();
        }


        static void Main(string[] args)
        {

            MainAsync(args).GetAwaiter().GetResult();


        }


        static async Task MainAsync(string[] args) {

            var salesService = ServiceMocker.GetSalesService();

            var customers = (await salesService.GetCustomersAsync()).Model.ToList();


            foreach (var item in customers)
            {

                Console.WriteLine(String.Format("CustomerID {0}", item.CustomerID));

                Console.ReadKey();

            }

           /// salesService.Dispose();

        }


    }
}
