using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.BusinessLogic.Interfaces
{
    public interface ITokenLogic
    {
        User validateUser(string email, string password);
    }
}
