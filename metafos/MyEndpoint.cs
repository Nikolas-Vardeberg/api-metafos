using FastEndpoints;

public class MyEndpoint : Endpoint<MyRequest, MyResponse>
{
    public override void Configure()
    {
        Post("/api/users");
        AllowAnonymous();
    }

    public override async Task HandleAsync(MyRequest req, CancellationToken ct)
    {
        await SendAsync(new()
        {
            EMAIL = req.EMAIL,
            USERNAME = req.USERNAME,
            PASSWORD = req.PASSWORD,
        });
    }
}
