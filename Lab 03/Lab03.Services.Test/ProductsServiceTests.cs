using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lab03.Services.Test
{
    [TestClass]
    public class ProductsServiceTests
    {
        [TestMethod]
        public void GetProducts_Doesnt_Return_Null()
        {
            //Arrange
            ProductsService service = new ProductsService();
            //Act
            var result = service.GetProducts();
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
