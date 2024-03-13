using FastEndpoints;
using metafos.Models.Users;
using metafos.Services.Users;

public class MyEndpoint : Endpoint<MyRequest, User>
{
    public IUserService UserService { get; set; }
    
    public override void Configure()
    {
        Post("/api/user/create");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MyRequest req, CancellationToken ct)
    {
        var user =new User {
            Email = req.Email,
            Username = req.Username,
            Password = req.Password,
        };
        var success = await UserService.CreateUser(user);
        await SendAsync(user);

    }
}

