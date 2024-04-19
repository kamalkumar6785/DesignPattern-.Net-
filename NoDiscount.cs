class NoDiscount : DiscountInterface
{
    public double FinalAmount(double amount)
        // No discount is applied
    {
        return amount - 0; 
    }
}