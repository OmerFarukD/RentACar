using System.Reflection;
using Microsoft.Extensions.FileProviders;
using RentACar.WebApp.Extensions;
using RentACar.WebApp.Repositories.Abstract;
using RentACar.WebApp.Repositories.Concrete;
using RentACar.WebApp.Services;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();
builder.Services.AddSingleton<IFileProvider>(new PhysicalFileProvider(
    Directory.GetCurrentDirectory())
);


builder.Services.AddPersistenceService(builder.Configuration);
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());
builder.Services.AddServiceDependencies();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); 
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Cars}/{action=Index}/{id?}");

app.Run();