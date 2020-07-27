﻿using FluentAssertions;
using Northwind.BusinessLogic.Implemetations;
using Northwind.BusinessLogicTest.Mocked;
using Northwind.UnitOfWork;
using Xunit;

namespace Northwind.BusinessLogicTest
{
    public class OrderLogicTest
    {
        private readonly IUnitOfWork _unitMocked;
        private readonly OrderLogic _orderLogic;
        public OrderLogicTest()
        {
            var unitMocked = new OrderRepositoryMocked();
            _unitMocked = unitMocked.GetInstance();
            _orderLogic = new OrderLogic(_unitMocked);
        }

        [Fact]
        public void GetOrderNumber_Order_Test()
        {
            var result = _orderLogic.GetOrderNumber(1);
            result.Should().NotBeNull();
            result.Should().NotBeEmpty();
        }
    }
}