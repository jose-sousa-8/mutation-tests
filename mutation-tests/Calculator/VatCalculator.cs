namespace mutation_tests
{
    public static class VatCalculator
    {
        public static double CalculateFinalPrice(double productPrice)
        {
            if (productPrice < 200)
            {
                return productPrice + (productPrice * 0.23);
            }

            return productPrice;
        }
    }
}