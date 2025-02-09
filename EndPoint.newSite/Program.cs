using newStore.Application.Services.Users.Queries.GetRoles;
using Microsoft.EntityFrameworkCore;
using newStore.Application.Interfaces.Contexts;
using newStore.Application.Services.Users.Queries.GetUsers;
using newStore.Application.Services.Users.Commands.RgegisterUser;
using newStore.Application.Services.Users.Commands.RemoveUser;
using newStore.Application.Services.Users.Commands.UserSatusChange;
using newStore.Application.Services.Users.Commands.EditUser;
using Microsoft.AspNetCore.Authentication.Cookies;
using newStore.Application.Services.Users.Commands.UserLogin;
using newStore.Persistence.Contexts;
using newStore.Application.Interfaces.FacadPatterns;
using newStore.Application.Services.Products.FacadPattern;
using newStore.Application.Services.Common.Queries.GetMenuItem;
using newStore.Application.Services.Common.Queries.GetCategory;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(options =>
{
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.LoginPath = new PathString("/");
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5.0);
});

builder.Services.AddScoped< IDataBaseContext, DataBaseContext>();
builder.Services.AddScoped<IGetUsersService, GetUsersService>();
builder.Services.AddScoped<IGetRolesService, GetRolesService>();
builder.Services.AddScoped<IRegisterUserService, RegisterUserService>();
builder.Services.AddScoped<IRemoveUserService, RemoveUserService>();
builder.Services.AddScoped<IUserSatusChangeService, UserSatusChangeService>();
builder.Services.AddScoped<IEditUserService, EditUserService>();
builder.Services.AddScoped<IUserLoginService, UserLoginService>();
builder.Services.AddScoped<IProductFacad, ProductFacad>();
builder.Services.AddScoped<IGetMenuItemService, GetMenuItemService>();
builder.Services.AddScoped<IGetCategoryService, GetCategoryService>();





string connectionString = @"Data Source=DESKTOP-OVLK4EA; Initial Catalog=newStoreDb; Integrated Security=True; TrustServerCertificate=True;";
builder.Services.AddDbContext<DataBaseContext>(options =>
    options.UseSqlServer(connectionString));
// Add services to the container.

builder.Services.AddControllersWithViews();

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
app.UseAuthentication();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

app.Run();
