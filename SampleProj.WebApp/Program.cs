using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SampleProj.DataAccess;
using SampleProj.DataAccessContract.Common;
using SampleProj.Services;
using SampleProj.Services.Mappers;
using SampleProj.ServicesContract;
using SampleProj.WebApp.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var constr = builder.Configuration.GetConnectionString("sampleDbConstr");
builder.Services.AddDbContext<SampleDbContext>(options => options.UseSqlServer(constr));


var mapperConfig = new MapperConfiguration(mc =>
{
    mc.AddProfile(new MapperProfile());
});

IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);

builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddTransient<IPersonService, PersonService>();

var app = builder.Build();

app.UseMiddleware<ExceptionHandlingMiddleware>();

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

app.Run();
