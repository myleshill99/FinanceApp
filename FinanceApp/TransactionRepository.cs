using Dapper;
using System.Data;
using System.Transactions;

namespace FinanceApp
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly IDbConnection _conn;

        public TransactionRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Transaction> GetAllTransactions()
        {
            return _conn.Query<Transaction>("SELECT * FROM transactions;");
        }
    }
}
