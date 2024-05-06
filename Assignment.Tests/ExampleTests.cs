//using Assignment.Repository.Models;

namespace Assignment.Tests
{
    // TODO: use CodiumAI in Visual Studio Code to generate unit tests

#if EXAMPLE
    public class AlphabeticalListOfProductTests
    {
        // The class can be instantiated without any errors.
        [Fact]
        public void test_instantiation()
        {
            // Arrange
    
            // Act
            var product = new AlphabeticalListOfProduct();

            // Assert
            Assert.NotNull(product);
        }

        // When the ProductName property is set to null, an ArgumentNullException should be thrown.
        [Fact]
        public void test_product_name_null()
        {
            // Arrange
            var product = new AlphabeticalListOfProduct();

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => product.ProductName = null);
        }
    }
#endif
}