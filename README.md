# .NET6 Web API Create JSON Web Tokens JWT - User Registration Login Authentication

Create JSON Web Tokens, User Registration, Login and Authentication in our  .NET 6 Web API.

## Packages
```
Microsoft.EntityFrameworkCore.Sqlite
Microsoft.EntityFrameworkCore.Tools
Microsoft.AspNetCore.Authentication.JwtBearer
Microsoft.AspNetCore.Identity.EntityFrameworkCore
Microsoft.AspNetCore.Identity.UI

Microsoft.IdentityModel.Tokens
System.IdentityModel.Tokens.Jwt
```

## Init Migration
```
Add-Migration InitialCreate
Update-Database
```

## Identity Migration
```
Add-Migration Identity
Update-Database
```

Get a token with wrong password:

<img src="/pictures/mez_wrong.png" title="user not found"  width="800">
