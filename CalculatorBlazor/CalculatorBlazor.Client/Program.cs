using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddBlazorBootstrap();

builder.Services.AddSingleton<CalcService>();
builder.Services.AddSingleton<CalcHistoryService>();


await builder.Build().RunAsync();
