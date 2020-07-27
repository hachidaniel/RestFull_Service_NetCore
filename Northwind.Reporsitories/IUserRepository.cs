using Northwind.Models;

namespace Northwind.Reporsitories
{
    public interface IUserRepository:IRepository<User>
    {
        User validateUser(string email, string password);
    }
}
