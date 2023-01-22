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

Register unsuccessful:
<img src="/pictures/register_unsuccessful.png" title="register unsuccessful"  width="800">

Register with good password:
<img src="/pictures/register_good_password.png" title="register good password"  width="800">

Login unsuccessful:
<img src="/pictures/login_unsuccessful.png" title="login unsuccessful"  width="800">

Login successful:
<img src="/pictures/login_successful.png" title="login successful"  width="800">
