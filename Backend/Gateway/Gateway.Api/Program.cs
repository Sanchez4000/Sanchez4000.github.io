var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

builder.Services
    .AddReverseProxy()
    .LoadFromConfig(config.GetSection("ReverseProxy"));

var app = builder.Build();

app.MapReverseProxy();

app.Run();
