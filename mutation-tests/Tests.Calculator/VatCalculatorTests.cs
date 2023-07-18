namespace medium_mutation_tests
{
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using mutation_tests;

    [TestClass]
    public class VatCalculatorTests
    {
        [TestMethod]
        public void VatCalculator_ProductMoreThan200_VatFree()
        {
            const double productValue = 485;

            var finalPrice = VatCalculator.CalculateFinalPrice(productPrice: productValue);

            productValue.Should().Be(finalPrice);
        }
        
        [TestMethod]
        public void VatCalculator_ProductLessThan200_VatFree()
        {
            const double productValue = 8.8;

            var finalPrice = VatCalculator.CalculateFinalPrice(productPrice: productValue);

            finalPrice.Should().Be((productValue + (productValue * 0.23)));
        }
    }
}