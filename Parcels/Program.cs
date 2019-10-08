using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

// now that this contains the boilerplate (which instantiates the webhost server) we dont add anything to this file.
namespace Parcels
{
    public class Program
    {
        public static void Main(string[] args)
        {
         var host = new WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(Directory.GetCurrentDirectory())
        .UseIISIntegration()
        .UseStartup<Startup>()
        .Build();

        host.Run();
        }
    }
}
