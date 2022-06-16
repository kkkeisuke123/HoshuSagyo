using HoshuSagyo.Models.Master;
using Microsoft.EntityFrameworkCore;

namespace HoshuSagyo.Helper
{
    public static class HoshuSagyoSeedingData
    {
        /// <summary>
        /// マスタ情報を登録する
        /// </summary>
        /// <param name="modelBuilder"></param>
        public static void SeedMasterTable(this ModelBuilder modelBuilder)
        {
            var now = DateTime.Now;

            // 系統情報
            modelBuilder.Entity<KeitoModel>().HasData(
                new KeitoModel { Keito = 1, KeitoName = "指令", RegisterDateTime = now, UpdateDateTime = now },
                new KeitoModel { Keito = 2, KeitoName = "現地", RegisterDateTime = now, UpdateDateTime = now },
                new KeitoModel { Keito = 99, KeitoName = "未定", RegisterDateTime = now, UpdateDateTime = now }
                );

            // 管轄情報
            modelBuilder.Entity<KankatsuModel>().HasData(
                new KankatsuModel { Kankatsu = 1, KankatsuName = "東京", RegisterDateTime = now, UpdateDateTime = now},
                new KankatsuModel { Kankatsu = 2, KankatsuName = "神奈川", RegisterDateTime = now, UpdateDateTime = now },
                new KankatsuModel { Kankatsu = 3, KankatsuName = "千葉", RegisterDateTime = now, UpdateDateTime = now },
                new KankatsuModel { Kankatsu = 4, KankatsuName = "埼玉", RegisterDateTime = now, UpdateDateTime = now },
                new KankatsuModel { Kankatsu = 5, KankatsuName = "群馬", RegisterDateTime = now, UpdateDateTime = now },
                new KankatsuModel { Kankatsu = 6, KankatsuName = "栃木", RegisterDateTime = now, UpdateDateTime = now },
                new KankatsuModel { Kankatsu = 7, KankatsuName = "茨城", RegisterDateTime = now, UpdateDateTime = now }
                );

            // 作業種別
            modelBuilder.Entity<SagyoShubetsuModel>().HasData(
                new SagyoShubetsuModel { SagyoShubetsu = 1, SagyoShubetsuName = "種別A", RegisterDateTime = now, UpdateDateTime = now},
                new SagyoShubetsuModel { SagyoShubetsu = 2, SagyoShubetsuName = "種別B", RegisterDateTime = now, UpdateDateTime = now },
                new SagyoShubetsuModel { SagyoShubetsu = 3, SagyoShubetsuName = "種別C", RegisterDateTime = now, UpdateDateTime = now }
                );

            // 作業場所
            modelBuilder.Entity<SagyoBashoModel>().HasData(
                new SagyoBashoModel { SagyoBasho = 1, SagyoBashoName = "場所A", RegisterDateTime = now, UpdateDateTime = now },
                new SagyoBashoModel { SagyoBasho = 2, SagyoBashoName = "場所B", RegisterDateTime = now, UpdateDateTime = now },
                new SagyoBashoModel { SagyoBasho = 3, SagyoBashoName = "場所C", RegisterDateTime = now, UpdateDateTime = now }
                );
        }
    }
}
