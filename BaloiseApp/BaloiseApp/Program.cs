using BaloiseApp;
using ServicesLibrary.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration.Memory;
using MyComponentsLibrary.Services;

var confData = new Dictionary<string, string>()
{
    {"menuBgColor" , "red" },
    {"urlApiAuth" , "https://..." },
};

var memoryConfig = new MemoryConfigurationSource { InitialData= confData };

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Configuration.Add(memoryConfig);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(@"https://formation.inow.fr/demo/api/v1/") });
builder.Services.AddScoped<CarsService>();
builder.Services.AddScoped<BrandsService>();
builder.Services.AddScoped<ToastService>();

await builder.Build().RunAsync();
