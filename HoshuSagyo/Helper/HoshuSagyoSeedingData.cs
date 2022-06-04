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
        }
    }
}
