using Intranet.Interview.UI.Client.Services.FormSrv;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["ApplicationSettings:WebApiBaseUrl"]!) });
builder.Services.AddMudServices();
builder.Services.AddTransient<IFormService, FormService>();

await builder.Build().RunAsync();