using Northwind.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Reporsitories
{
    public interface ISupplierRepository : IRepository<Supplier>
    {
        IEnumerable<Supplier> SupplierPagedList(int page, int rows, string searchTerm);
    }
}
