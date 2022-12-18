using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AspNetAtmApp.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AspNetAtmAppContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("AspNetAtmAppContext") ?? throw new InvalidOperationException("Connection string 'AspNetAtmAppContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedDataContext.Initialize(services);
}

app.Run();
