public class Country : Adaptor
{
    public Country(TransactionHandler transaction) : base(transaction)
    {
        //transactionHandler is injected once in the base class - so we're inheriting that shared behavior here
        //calling the constructor of a base class through the derived class constructor - (is called constructor chaining)
    }
    
    public override void ExecutingCode()
    {
        Console.WriteLine("Executing Country Code.");
    }
}