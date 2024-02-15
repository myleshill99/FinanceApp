namespace FinanceApp.Models
{
    public class Transaction
    {
        public int ID { get; set; }
        public DateOnly Date { get; set; }
        public double Amount { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Account { get; set; }
    }
}
