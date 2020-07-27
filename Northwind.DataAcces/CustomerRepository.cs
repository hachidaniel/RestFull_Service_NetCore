using System.Collections.Generic;
using System.Data.SqlClient;
using Dapper;
using Northwind.Models;
using Northwind.Reporsitories;

namespace Northwind.DataAcces
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(string connectionString)
            : base(connectionString)
        {

        }

        public IEnumerable<CustomerList> CustomerPageList(int page, int rows)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@page", page);
            parameters.Add("@rows", rows);

            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<CustomerList>("dbo.CustomerPagedList", 
                                                  parameters,
                                                  commandType: System.Data.CommandType.StoredProcedure);
            }
                
        }
    }
}
