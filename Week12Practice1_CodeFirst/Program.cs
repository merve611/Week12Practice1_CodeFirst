using Microsoft.EntityFrameworkCore;
using Week12Practice1_CodeFirst.Context;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionString = builder.Configuration.GetConnectionString("default");

builder.Services.AddDbContext<PatikaFirstDbContext>(options => options.UseSqlServer(connectionString));

var app = builder.Build();

app.MapDefaultControllerRoute();


app.Run();
