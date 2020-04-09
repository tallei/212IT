using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HarrisContactWeb.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration; // the dbcontext carries extension methods 
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace HarrisContactWeb
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();    /// create var host as variable 
            using (var scope = host.Services.CreateScope()) // using extension dependency injection 
            {  
                var services = scope.ServiceProvider;
                try // try and catch block 
                {
                    var context = services.GetRequiredService<HarrisDbContext>(); // get the database using harris contact web data 
                    DbInitializer.Initialize(context); // call the Initialize method  
                }
                catch (Exception ex)
                {
                    var logger = services.GetRequiredService<ILogger<Program>>();
                    logger.LogError(ex, "An Error has occured while creating the database"); // print error out and bring this message when neccessary
                }
            }
                host.Run();  
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
