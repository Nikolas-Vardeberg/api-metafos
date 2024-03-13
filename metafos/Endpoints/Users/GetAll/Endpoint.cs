namespace metafos.Endpoints.GetAll;
using FastEndpoints;
using metafos.Services.Users;
using Microsoft.Net.Http.Headers;

public class GetEndpoint : Endpoint<MyRequest, MyResponse>
{
    public IUserService UserService { get; set; }

    public override void Configure()
    {
        Get("/api/user");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MyRequest req, CancellationToken ct)
    {
        await SendAsync(new () {
            Users = await UserService.GetUsersAsync()
        });

    }
}

