using HotelWEBAPP.Components;
using System.Text;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;

var handler = new HttpClientHandler
{
    ServerCertificateCustomValidationCallback = (message, cert, chain, errors) => true
};


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents()
    .Services.AddHttpClient();

builder.Services.AddHttpClient("NoSSL").ConfigurePrimaryHttpMessageHandler(() => handler);

// Register Blazored.LocalStorage


// Register the custom AuthenticationStateProvider


// Add authentication services

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}


app.UseStaticFiles();

app.UseRouting();



// Add anti-forgery middleware
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

