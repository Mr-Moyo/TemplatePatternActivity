public abstract class Adaptor : IOperation
{
    private readonly TransactionHandler _transaction;

    protected Adaptor(TransactionHandler transaction)
    {
        _transaction = transaction;
    }

//abstract method (without implementation)
    public abstract void ExecutingCode();//inherited from IOperation INTERFACE

//concrete methods (with implementation)
    public void PerformActivity()
    {
        try
        {
            Console.WriteLine("");
            Console.WriteLine("Performing activity.");
            Console.WriteLine("------------------START--------------------");

            _transaction.StartTransaction();
            ExecutingCode();
            _transaction.CommitTransaction();

            Console.WriteLine("------------------End----------------------");
            Console.WriteLine("");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Exception: {ex.Message}");

            _transaction.RollbackTransaction();

            Console.WriteLine("------------------End----------------------");
            Console.WriteLine("");
        }

    }
}