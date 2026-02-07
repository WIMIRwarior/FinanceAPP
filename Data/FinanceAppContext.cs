using FinanceAPP.Models;
using Microsoft.EntityFrameworkCore;

namespace FinanceAPP.Data
{
    public class FinanceAppContext : DbContext 
    {
        public FinanceAppContext(DbContextOptions<FinanceAppContext> options):base(options) { }  //What this line does?


        DbSet<Expense> Expenses { get; set; }
    }
}
