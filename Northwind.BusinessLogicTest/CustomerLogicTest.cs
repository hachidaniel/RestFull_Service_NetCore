using FluentAssertions;
using Northwind.BusinessLogic.Implemetations;
using Northwind.Models;
using Northwind.UnitOfWork;
using Xunit;

namespace Northwind.BusinessLogicTest.Mocked
{
    public class CustomerLogicTest
    {
        private readonly IUnitOfWork _unitMocked;
        private readonly CustomerLogic _customerLogic;

        public CustomerLogicTest()
        {
            var unitMocked = new CustomerRepositoryMocked();
            _unitMocked = unitMocked.GetInstance();
            _customerLogic = new CustomerLogic(_unitMocked);
        }
        [Fact]
        public void GetById_Customer_Test()
        {
            var result = _customerLogic.GetById(1);
            result.Should().NotBeNull();
            result.Id.Should().BeGreaterThan(0);
        }
        [Fact(DisplayName = "[CustomerLogic] Insert")]
        public void Insert_Customer_Test()
        {
            var customer = new Customer
            {
                Id = 101,
                City = "lima",
                Country = "peru",
                FirstName = "cesar",
                LastName = "vallejo",
                Phone ="5578896987"
            };

            var result = _customerLogic.Insert(customer);
            result.Should().Be(101);
        }

        [Fact(DisplayName = "[CustomerLogic] Update")]
        public void Update_Customer_Test()
        {
            var customer = new Customer
            {
                Id = 1,
                City = "lima",
                Country = "peru",
                FirstName = "cesar",
                LastName = "vallejo",
                Phone = "5578896"
            };

            var result = _customerLogic.Update(customer);
            var currentCustomer = _customerLogic.GetById(1);
            currentCustomer.Should().NotBeNull();
            currentCustomer.Id.Should().Be(customer.Id);
            currentCustomer.City.Should().Be(customer.City);
            currentCustomer.Country.Should().Be(customer.Country);
            currentCustomer.FirstName.Should().Be(customer.FirstName);
            currentCustomer.LastName.Should().Be(customer.LastName);
            currentCustomer.Phone.Should().Be(customer.Phone);

        }

    }
}
