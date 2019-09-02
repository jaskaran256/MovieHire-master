using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieHire;

namespace MovieHireUnitTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_Config_Output()
        {
            // Arrange
            var hire = new Helpers();

            // Act
            var actual = hire.TestConfig();

            // Assert
            Assert.AreEqual(@"Data Source=DESKTOP-POQE336\SQLEXPRESS;Initial Catalog=Movies_Rentals;Integrated Security=True", actual);
        }

        [TestMethod]
        public void Test_Item_Count()
        {
            // Arrange
            var hire = new Helpers();

            // Act
            var actual = hire.CountList("Rentals", "CustomerID", 1);

            // Assert
            Assert.AreEqual(1, actual);
        }
    }
}
