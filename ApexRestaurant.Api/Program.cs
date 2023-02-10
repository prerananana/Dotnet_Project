// 
using System;
using Microsoft.AspNetCore.Hosting;
using Apexrestaurant.Api;
namespace Apexrestaurant.Api
{
    public class Program
    {
         public static void Main(String[] args)
         {
             var host = new WebHostBuilder()
             .UseKestrel()
             .UseStartup<Startup>()
             .Build();
             host.Run();
         }
    }
}