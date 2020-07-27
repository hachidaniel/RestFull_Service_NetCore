using Microsoft.IdentityModel.Tokens;
using Northwind.Models;
using System;

namespace Northwind.WebApi.Autentication
{
    public interface ITokenProvider
    {
        string CreateToken(User user, DateTime expiry);
        TokenValidationParameters GetValidationParameters();
    }
}
