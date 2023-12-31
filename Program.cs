using GrupoGPS_Proto.Models;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
// builder.Services.AddDbContext<DatabaseContext>(options => options.UseMySQL("conn"));

builder.Services.AddControllersWithViews();

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.WithOrigins("https://localhost:7056/")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

//builder.Services.AddCors(options =>
//{
//    options.AddDefaultPolicy(
//        builder =>
//        {
//            builder
//                .AllowAnyOrigin()
//                .AllowAnyHeader()
//                .AllowAnyMethod();
//        });
//});

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
//app.UseCors();
app.UseCors(MyAllowSpecificOrigins);
app.UseAuthorization();
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Empresa}/{action=BuscarEmpresa}/{id?}");
app.Run();
