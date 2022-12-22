using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRipositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            //-- Arrange
            var productRipository = new ProductRipository();
            var expected = new Product(2)
            {
                CurrentPrice = 15.96M,
                ProductName = "Sunflowers",
                ProductDescription = "simple"
            };

            //-- Act
            var actual = productRipository.Retrieve(2);
            //-- Assert
            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);


        }


        [TestMethod]
        public void SaveTestValid()
        {
            //-- Arrange
            var productRipository = new ProductRipository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-- Act
            var actual = productRipository.Save(updatedProduct);

            //-- Assert
            Assert.AreEqual(true, actual);
        }

        [TestMethod]
        public void SaveTestMissingPrice()
        {
            //-- Arrange
            var productRipository = new ProductRipository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = null,
                ProductDescription = "Assorted",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            //-- Act
            var actual = productRipository.Save(updatedProduct);

            //-- Assert
            Assert.AreEqual(false, actual);

        }



    }
}
