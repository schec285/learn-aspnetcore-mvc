using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using learn_dotNetCoreMvc.Data;
using learn_dotNetCoreMvc.Models;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<learn_dotNetCoreMvcContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("learn_dotNetCoreMvcContext") ?? throw new InvalidOperationException("Connection string 'learn_dotNetCoreMvcContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var service = scope.ServiceProvider;

    SeedData.Initialize(service);
}
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
