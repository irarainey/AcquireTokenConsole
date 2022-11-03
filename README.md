# Acquire Access Token from Console

This simple example uses the Microsoft Authentication Library (MSAL) to obtain an access token from Azure Active Directory from a .NET 6 console application.

The configuration information required is:

* `_tenant_id` - The instance of Azure Active Directory the client application is registered in
* `_client_id` - The application registration id for the client application
* `_redirect_uri` - This should be set to `http://localhost` and defined in the application registration as a `Mobile and desktop applications` platform
* `_scopes` - An array of scopes being requested in the access token
