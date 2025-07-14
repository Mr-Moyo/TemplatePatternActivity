public class AddAsset : Adaptor
{
    public AddAsset(TransactionHandler transaction) : base(transaction)
    {
    }

    public override void ExecutingCode()
    {
        // Console.WriteLine("Adding Asset.");
        throw new NotImplementedException("Something went wrong.");
    }
}