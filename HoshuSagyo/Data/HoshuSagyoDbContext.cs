using Microsoft.EntityFrameworkCore;
using HoshuSagyo.Models.Transactions;
using HoshuSagyo.Models.Master;
using HoshuSagyo.Helper;

namespace HoshuSagyo.Data
{
    public class HoshuSagyoDbContext : DbContext
    {
        public HoshuSagyoDbContext(DbContextOptions<HoshuSagyoDbContext> options)
            : base(options)
        {
        }

        /*
         * トランザクションテーブル
         */
        
        // 締切情報
        public DbSet<ShimekiriModel> T_Shimekiri { get; set; }



        /*
         * マスタテーブル
         */
        
        // 管轄情報
        public DbSet<UserInfoModel> M_UserInfo { get; set; }

        // 系統情報
        public DbSet<KeitoModel> M_Keito { get; set; }

        // 管轄情報
        public DbSet<KankatsuModel> M_Kankatsu { get; set; }


        /// <summary>
        /// テーブル作成
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedMasterTable();
        }
    }
}
