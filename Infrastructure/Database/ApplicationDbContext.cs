using Infrastructure.Entity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Database
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<IncomeExpenditure> IncomeExpenditures { get; set; }
        public DbSet<IncomeExpenditureType> IncomeExpenditureTypes { get; set; }
        public DbSet<MoneyAccount> MoneyAccounts { get; set; }
    }
}
