namespace metafos.Endpoints.GetAll;
using FastEndpoints;


public class GetEndpoint : Endpoint<MyRequest, MyResponse>
{
    public override void Configure()
    {
        Get("/api/user");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MyRequest req, CancellationToken ct)
    {
        await SendAsync(new () {
            Users = new List<string>() {"Tester"}
        });

    }
}

