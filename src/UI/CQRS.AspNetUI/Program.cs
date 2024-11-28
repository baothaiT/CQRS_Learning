using CQRS.AspNetUI.Services.Interfaces;
using CQRS.AspNetUI.Services;
using CQRS.Infrastructure.Services;
using CQRS.Infrastructure.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IFileService, FileService>();
builder.Services.AddHttpClient<IProductClientService, ProductClientService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5199/"); // Replace with your API URL
});

builder.Services.AddHttpClient <IProxyClientService, ProxyClientService>(client =>
{
    client.BaseAddress = new Uri("http://localhost:5199/"); // Replace with your API URL
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
