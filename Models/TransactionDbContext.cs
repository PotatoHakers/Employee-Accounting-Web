using Microsoft.EntityFrameworkCore;

namespace BankTransactions.Models
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext(DbContextOptions<TransactionDbContext> options) : base(options)
        {
           
            //Database.EnsureDeleted();
        }
            
        public DbSet<Transaction> Transactions { get; set; }
    }
}
