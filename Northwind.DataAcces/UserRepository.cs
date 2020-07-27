using Dapper;
using Northwind.Models;
using Northwind.Reporsitories;
using System.Data.SqlClient;

namespace Northwind.DataAcces
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        public UserRepository(string connectionString)
            : base(connectionString)
        {

        }
        public User validateUser(string email, string password)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@email", email);
            parameters.Add("@password", password);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.QueryFirstOrDefault<User>(
                    "dbo.ValidateUser", parameters,
                    commandType: System.Data.CommandType.StoredProcedure
                    );
            }
        }
    }
}
