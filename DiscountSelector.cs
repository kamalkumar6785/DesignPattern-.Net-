class DiscountSelector
{
    private DiscountInterface _discountStrategy;

    //setting the strategy through constructor
    public DiscountSelector(DiscountInterface discounStrategyt)
    {
        _discountStrategy = discounStrategyt;
    }


    // method to generate bill amount 
    public double GenerateBill(double amount)
    {
        return _discountStrategy.FinalAmount(amount);
    }
}
