﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using System.Threading.Tasks;

namespace MeowvBlog.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await WebHost.CreateDefaultBuilder(args)
                         .UseStartup<Startup>()
                         .Build()
                         .RunAsync();
        }
    }
}