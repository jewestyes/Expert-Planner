using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;


var hostBuilder = Host.CreateDefaultBuilder(args)
    .ConfigureWebHostDefaults(webBuilder =>
    {
        webBuilder.UseStartup<Startup>();
    });

var host = hostBuilder.Build();

host.Run();
