namespace Acme.CommonTest
{
    [TestClass]
    public class LoggingServiceTest
    {
        [TestMethod]
        public void WriteToFileTest()
        {
            //Arrange
            var changedItem = new List<ILoggable>();
            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null


            };
            changedItem.Add(customer);

            var product = new Product(2)
            {
                ProductName = "Raka",
                ProductDescription = "Garden Raka with Steel Head",
                CurrentPrice = 6M,



            };
            changedItem.Add(product);

            //Act
            LoggingService.WriteToFile(changedItem);

            // Assert
            // Nothing Here to assert


        }
    }
}
