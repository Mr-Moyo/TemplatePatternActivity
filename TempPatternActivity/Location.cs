public class Location : Adaptor
{
    public Location(TransactionHandler transaction) : base(transaction)
    {
        //calling the constructor of a base class through the derived class constructor - (is called constructor chaining)
    }

    public override void ExecutingCode()
    {
        Console.WriteLine("Executing Location Code.");
    }
}