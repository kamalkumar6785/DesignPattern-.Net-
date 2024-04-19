class HighDiscount : DiscountInterface
{
    // applying high discoutn of 20%
    public double FinalAmount(double amount)
    {
        return amount - amount * 0.2;
    }
}