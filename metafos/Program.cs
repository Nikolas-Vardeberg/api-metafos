using FastEndpoints;
using FastEndpoints.Security; //add this

var bld = WebApplication.CreateBuilder();
bld.Services
   .AddAuthenticationJwtBearer(s => s.SigningKey = "The secret used to sign tokens") //add this
   .AddAuthorization() //add this
   .AddFastEndpoints();

var app = bld.Build();
app.UseAuthentication() //add this
   .UseAuthorization() //add this
   .UseFastEndpoints();
app.Run();
