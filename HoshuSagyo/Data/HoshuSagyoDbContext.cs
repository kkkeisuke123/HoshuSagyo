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

        // 作業実績情報
        public DbSet<SagyoJissekiModel> T_SagyoJisseki { get; set; }

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

        // 音声応答情報
        public DbSet<OnseiOtoModel> M_OnseiOto { get; set; }

        // 音声応答詳細情報
        public DbSet<OnseiOtoShosaiModel> M_OnseiOtoShosai { get; set; }

        // 進捗情報
        public DbSet<ShinchokuModel> M_Shinchoku { get; set; }

        /// <summary>
        /// テーブル作成
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // 複合主キーの設定
            modelBuilder.Entity<SagyoBangoModel>().HasKey(
                c => new { c.Nengetsu, c.Kankatsu });

            // マスタ情報作成
            modelBuilder.SeedMasterTable();
        }
    }
}
