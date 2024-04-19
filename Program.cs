class Program
{
    static void Main(string[] args)
    {

        DiscountInterface discountStrategy;

        Console.WriteLine("Enter the amount:");
        double amount = double.Parse(Console.ReadLine());


        Console.WriteLine("Enter customer's card type: [ Employee, Membership, None ]");
        string CardType = Console.ReadLine();

        switch (CardType.ToLower()) 
        {

            case "employee":
                discountStrategy = new HighDiscount();
                break;

            case "membership":
                discountStrategy = new LowDiscountStrategy();
                break;

            case "none":
                discountStrategy = new NoDiscount();
                break;

             default :
                discountStrategy = null;
                Console.WriteLine("Not a valid option ");
                break;
        }


        if(discountStrategy != null) 
        {

            DiscountSelector select = new DiscountSelector(discountStrategy);
            double amountAfterDiscount = select.GenerateBill(amount);

            Console.WriteLine($"Amount after applying discount: INR {amountAfterDiscount}");
        }
  
 
    }
}
