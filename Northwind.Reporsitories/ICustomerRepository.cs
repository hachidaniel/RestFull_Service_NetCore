using Northwind.Models;
using System.Collections.Generic;

namespace Northwind.Reporsitories
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        IEnumerable<CustomerList> CustomerPageList(int page, int rows);

    }
}
