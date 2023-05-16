using System.Data.Entity;
using Bank.Models;

namespace Bank.EF
{
    public class BankEntity : DbContext
    {
        public BankEntity() : base("name=BankConnection") { }

        public virtual DbSet<User> Users { get; set; }
    }
}
