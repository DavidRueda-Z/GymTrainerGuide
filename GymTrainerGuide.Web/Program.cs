using GymTrainerGuide.Web;
using GymTrainerGuide.Web.Repositories;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// 🔗 HttpClient apuntando a la API (ajusta el puerto si cambia)
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://localhost:7026/api/")
});

// 💾 Inyección del repositorio genérico
builder.Services.AddScoped<IRepository, Repository>();

await builder.Build().RunAsync();


