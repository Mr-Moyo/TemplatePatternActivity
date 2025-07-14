// See https://aka.ms/new-console-template for more information

//we use static because we want to call it directly and it is a member of a static class (Main) 
static void runCode(Adaptor adaptor)
{
    adaptor.PerformActivity();
}

var transaction = new TransactionHandler();
runCode(new Country(transaction));
runCode(new Location(transaction));
runCode(new AddAsset(transaction));