using System.Transactions;

namespace FinanceApp
{
    public interface ITransactionRepository
    {
        IEnumerable<Transaction> GetAllTransactions();
    }
}
