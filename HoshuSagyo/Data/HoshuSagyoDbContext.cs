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
        
        // 作業計画情報
        public DbSet<SagyoKeikakuModel> T_SagyoKeikaku { get; set; }

        // 締切情報
        public DbSet<ShimekiriModel> T_Shimekiri { get; set; }

        // 作業番号情報
        public DbSet<SagyoBangoModel> T_SagyoBango { get; set; }


        /*
         * マスタテーブル
         */
        
        // 管轄情報
        public DbSet<UserInfoModel> M_UserInfo { get; set; }

        // 系統情報
        public DbSet<KeitoModel> M_Keito { get; set; }

        // 管轄情報
        public DbSet<KankatsuModel> M_Kankatsu { get; set; }

        // 作業種別情報
        public DbSet<SagyoShubetsuModel> M_SagyoShubetsu { get; set; }

        // 作業場所情報
        public DbSet<SagyoBashoModel> M_SagyoBasho { get; set; }

        /// <summary>
        /// テーブル作成
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 複合主キーの設定
            modelBuilder.Entity<SagyoKeikakuModel>().HasKey(
                c => new { c.SagyoKaishiBi, c.Keito, c.Kankatsu, c.SagyoShubetsu, c.SagyoBasho });
            
            modelBuilder.Entity<ShimekiriModel>().HasKey(
                c => new { c.Keito, c.Kankatsu });

            modelBuilder.Entity<SagyoBangoModel>().HasKey(
                c => new { c.SagyoKaishiBi, c.Keito, c.Kankatsu });

            // マスタ情報作成
            modelBuilder.SeedMasterTable();
        }
    }
}
