using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using PhoneBookClient;
using PhoneBookClient.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddSingleton<PhoneBookClient.Services.ContactDataService>();

//await builder.Build().RunAsync();

var host = builder.Build();

var contactService = host.Services.GetRequiredService<ContactDataService>();

await host.RunAsync();