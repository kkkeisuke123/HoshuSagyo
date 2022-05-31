using Microsoft.EntityFrameworkCore;
using HoshuSagyo.Models.Transactions;

namespace HoshuSagyo.Data
{
    public class HoshuSagyoDbContext : DbContext
    {
        public HoshuSagyoDbContext(DbContextOptions<HoshuSagyoDbContext> options)
            : base(options)
        {
        }

        // 締切情報
        public DbSet<ShimekiriModel> T_Shimekiri { get; set; }
    }
}
