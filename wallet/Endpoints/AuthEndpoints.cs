namespace wallet.Endpoints;

public static class AuthEndpoints
{
    public static void MapAuthEndpoints(this IEndpointRouteBuilder routes)
    {
        var group = routes.MapGroup("/api/auth");

        group.MapGet("/", ()=> "Testing auth endpoints");
        group.WithTags("Auth");
    }
}
