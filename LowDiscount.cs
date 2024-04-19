class LowDiscountStrategy : DiscountInterface
{
    // applying 10% discount reate
    public double FinalAmount(double amount)
    {
        return amount - amount * 0.1;
    }
}