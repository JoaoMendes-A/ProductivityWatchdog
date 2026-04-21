using ProductivityWatchdog.Worker;
using Microsoft.EntityFrameworkCore;
using Productivity.Infrastructure.Persistence;

var builder = Host.CreateApplicationBuilder(args);
builder.Services.AddHostedService<Worker>();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(
        builder.Configuration.GetConnectionString("DefaultConnection")));
        
var host = builder.Build();
host.Run();

