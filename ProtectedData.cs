using FastEndpoints;

namespace JwtMinimalWebApi;

public class ProtectedData : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/data");
        //AllowAnonymous();
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        await SendAsync("You got it!");
    }
}


public class ProtectedData2 : EndpointWithoutRequest
{
    public override void Configure()
    {
        Get("/data2");
        // todo figure out policies!!!
        Claims("email", "noemail");
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
        await SendAsync("You got it!");
    }
}
