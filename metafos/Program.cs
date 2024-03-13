using FastEndpoints;
using metafos.Data;
using metafos.Services.Users;
using Microsoft.EntityFrameworkCore;

var bld = WebApplication.CreateBuilder();


bld.Services.AddFastEndpoints();

bld.Services.AddDbContext<DataContext>(options => {
    options.UseNpgsql(bld.Configuration.GetConnectionString("Metafoos"));
});

bld.Services.AddScoped<IUserService, UserService>();

var app = bld.Build();
app.UseFastEndpoints();
app.Run();
