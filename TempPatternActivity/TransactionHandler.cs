public class TransactionHandler
{
    public void StartTransaction()
    {
        Console.WriteLine("Transaction Started.");
    }
    public void CommitTransaction()
    {
        Console.WriteLine("Transaction Committed.");
    }
    public void RollbackTransaction() {
     Console.WriteLine("Transaction Rolled back.");   
    }
}