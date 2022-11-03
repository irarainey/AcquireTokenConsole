using Microsoft.Identity.Client;

string _tenant_id = "";
string _client_id = "";
string _redirect_uri = "";
string[] _scopes = new[] { "" };

var clientApp = PublicClientApplicationBuilder
            .Create(_client_id)
            .WithTenantId(_tenant_id)
            .WithRedirectUri(_redirect_uri)
            .Build();

AuthenticationResult authResult = await clientApp
    .AcquireTokenInteractive(_scopes)
    .ExecuteAsync();

Console.WriteLine(authResult.AccessToken);
