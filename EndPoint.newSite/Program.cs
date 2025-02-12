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
using newStore.Application.Services.HomePages.AddNewSlider;
using newStore.Application.Services.Common.Queries.GetSlider;
using newStore.Application.Services.HomePages.AddHomePageImages;
using newStore.Application.Services.Common.Queries.GetHomePageImages;
using newStore.Application.Services.Carts;
using newStore.Application.Services.Fainances.Commands.AddRequestPay;
using newStore.Common.Roles;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthorization(options =>
{
    options.AddPolicy(UserRoles.Admin, policy => policy.RequireRole(UserRoles.Admin));
    options.AddPolicy(UserRoles.Customer, policy => policy.RequireRole(UserRoles.Customer));
    options.AddPolicy(UserRoles.Operator, policy => policy.RequireRole(UserRoles.Operator));
});


builder.Services.AddAuthentication(options =>
{
    options.DefaultSignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultAuthenticateScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = CookieAuthenticationDefaults.AuthenticationScheme;
}).AddCookie(options =>
{
    options.LoginPath = new PathString("/Authentication/Signin");
    options.ExpireTimeSpan = TimeSpan.FromMinutes(5.0);
    options.AccessDeniedPath = new PathString("/Authentication/Signin");
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

/////////////////////////////////////////////

builder.Services.AddScoped<IAddNewSliderService, AddNewSliderService>();
builder.Services.AddScoped<IGetSliderService, GetSliderService>();
builder.Services.AddScoped<IAddHomePageImagesService, AddHomePageImagesService>();
builder.Services.AddScoped<IGetHomePageImagesService, GetHomePageImagesService>();

///////////////////////////////////////////
builder.Services.AddScoped<ICartService, CartService>();
builder.Services.AddScoped<IAddRequestPayService, AddRequestPayService>();





//string connectionString = @"Data Source=DESKTOP-OVLK4EA; Initial Catalog=newStoreDb; Integrated Security=True; TrustServerCertificate=True;";
string connectionString = @"Data Source=DESKTOP-OVLK4EA; Initial Catalog=newStoreDb; Integrated Security=True; TrustServerCertificate=True; Connect Timeout=60;";

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

app.UseAuthentication();

app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
);

app.Run();
