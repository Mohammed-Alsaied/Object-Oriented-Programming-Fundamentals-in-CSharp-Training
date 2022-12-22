using ACME.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Acme.CommonTest
{
    [TestClass]
    public class StringHandlerTest
    {
        [TestMethod]
        public void InsertSpacesTestValid()
        {
            // Arrange
            var source = "MohamedAlSaeed";
            var expected = "Mohamed Al Saeed";
            //var handler = new StringHandler();

            // Act
            //var actual = StringHandler.InsrtSpaces(source)
            var actual = source.InsrtSpaces();// Extension Methode
            // Assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void InsertSpacesTestWithExistingspace()
        {
            // Arrange
            var source = "Mohamed Al Saeed";
            var expected = "Mohamed Al Saeed";
            //var handler = new StringHandler();

            // Act
            //var actual = StringHandler.InsrtSpaces(source)
            var actual = source.InsrtSpaces();// Extension Method
            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
