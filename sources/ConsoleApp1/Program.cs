using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = Microsoft.Extensions.Hosting.Host.CreateApplicationBuilder(args);
            builder.Services.AddStackExchangeRedisCache(x =>
            {
                x.Configuration = "127.0.0.1:6379,defaultDatabase=0";
            });
            var host = builder.Build();
            var options = new DistributedCacheEntryOptions();
            options.AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(90);
            var cache = host.Services.GetService<IDistributedCache>();

            var config = host.Services.GetService<IConfiguration>();
            var x = config["Logging:LogLevel:Default"];
            var t = config.GetSection("ConnectionStrings");

            Console.WriteLine("Hello, World!");
        }
    }
}
