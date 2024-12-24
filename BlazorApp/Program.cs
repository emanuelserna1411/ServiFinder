using BlazorApp.Components;
using Microsoft.Win32;
using MudBlazor.Services;
using ServiFinder.Domain;
using ServiFinder.Repository;
using ServiFinder.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
// Registrar el servicio para el repositorio
builder.Services.AddTransient<IRepository<Employed>, EmployedRepositoryImpl>();

//Registrar el servicio de employed
builder.Services.AddTransient<IEmployedServices, EmployedService>();
//MudBlazor
builder.Services.AddMudServices();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
