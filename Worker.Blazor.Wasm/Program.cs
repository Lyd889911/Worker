using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Worker.Blazor.Wasm;
using Worker.Blazor.Wasm.Shared;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
// Add services to the container.
builder.Services.AddMasaBlazor();
builder.Services.AddScoped<NavBar>();

await builder.Build().RunAsync();
