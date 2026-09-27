using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using APP_avanzo.Client;
using APP.avanzo.Client.datos;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("http://localhost:5036") });

//Agregamos el servicio
builder.Services.AddScoped<Calcular2Servicios>();


await builder.Build().RunAsync();
