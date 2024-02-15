using Microsoft.AspNetCore.Mvc;

namespace FinanceApp.Controllers
{
    public class TransactionController : Controller
    {
        private readonly ITransactionRepository _repo;

        public TransactionController(ITransactionRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var transactions = _repo.GetAllTransactions();
            return View(transactions);
        }
    }
}
