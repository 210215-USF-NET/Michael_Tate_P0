using System;
using Xunit;
using StoreModels;

namespace StoreTest
{
    public class UnitTest1
    {
        private Product testProduct = new Product();
        [Fact]
        public void Test1()
        {
            int testPrice = 10;
            //Act
            testPrice.Price = testPrice;
            //Assert
            Assert.Equal(testPrice, testProduct.Price);;
        }
    }
}
