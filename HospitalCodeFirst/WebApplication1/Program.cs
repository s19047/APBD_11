using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using HospitalDB.Entities;
using WebApplication1.Entities;

namespace WebApplication1
{
    public class Program
    {
        //Get a database context instance from the dependency injection container.
        //Call the seed method, passing to it the context.
        //Dispose the context when the seed method is done.

        public static void Main(string[] args)
        {
            /*
           var host = CreateHostBuilder(args).Build();

           using (var scope = host.Services.CreateScope())
           {

               var services = scope.ServiceProvider;
               try
               {
                   var context = services.GetRequiredService<HospitalDbContext>();
                   HospitalDbInitializer.Initialize(context);
               }
               catch (Exception ex)
               {
                   var logger = services.GetRequiredService<ILogger<Program>>();
                   logger.LogError(ex, "An error occurred while seeding the database.");
               }
           }

           host.Run();*/

            CreateHostBuilder(args).Build().Run();
            }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
