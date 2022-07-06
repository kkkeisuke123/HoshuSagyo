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

            // 音声応答
            modelBuilder.Entity<OnseiOtoModel>().HasData(
                new OnseiOtoModel { OtoShubetsu = 1, OtoShubetsuNaiyo = "作業開始", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoModel { OtoShubetsu = 2, OtoShubetsuNaiyo = "作業終了", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoModel { OtoShubetsu = 3, OtoShubetsuNaiyo = "施設", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoModel { OtoShubetsu = 4, OtoShubetsuNaiyo = "電力", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoModel { OtoShubetsu = 5, OtoShubetsuNaiyo = "通信", RegisterDateTime = now, UpdateDateTime = now }
                );

            // 音声応答詳細
            modelBuilder.Entity<OnseiOtoShosaiModel>().HasData(
                new OnseiOtoShosaiModel { Id = 1, OtoShubetsu = 1, Message = "周りの安全を確保しましたか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 2, OtoShubetsu = 1, Message = "作業員は全員揃いましたか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 3, OtoShubetsu = 1, Message = "作業場所は間違っていませんか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 4, OtoShubetsu = 2, Message = "道具の忘れ物はありませんか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 5, OtoShubetsu = 2, Message = "機材のメンテナンスは行いましたか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 6, OtoShubetsu = 2, Message = "作業の最終確認は済みましたか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 7, OtoShubetsu = 3, Message = "施設の責任者から作業許可は出ていますか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 8, OtoShubetsu = 3, Message = "各エリアの施錠は行いましたか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 9, OtoShubetsu = 3, Message = "電気の供給が停止していますか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 10, OtoShubetsu = 3, Message = "電気の供給を再開しましたか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 11, OtoShubetsu = 3, Message = "通信状態をメンテナンス状態にしましたか", RegisterDateTime = now, UpdateDateTime = now },
                new OnseiOtoShosaiModel { Id = 12, OtoShubetsu = 3, Message = "通信状態を通常状態に戻しましたか", RegisterDateTime = now, UpdateDateTime = now }
                );

            // 進捗
            modelBuilder.Entity<ShinchokuModel>().HasData(
                new ShinchokuModel { Shinchoku = 1, ShinchokuName = "未着手", RegisterDateTime = now, UpdateDateTime = now },
                new ShinchokuModel { Shinchoku = 2, ShinchokuName = "着手済", RegisterDateTime = now, UpdateDateTime = now },
                new ShinchokuModel { Shinchoku = 3, ShinchokuName = "完了済", RegisterDateTime = now, UpdateDateTime = now },
                new ShinchokuModel { Shinchoku = 4, ShinchokuName = "着手遅延", RegisterDateTime = now, UpdateDateTime = now },
                new ShinchokuModel { Shinchoku = 5, ShinchokuName = "終了遅延", RegisterDateTime = now, UpdateDateTime = now },
                new ShinchokuModel { Shinchoku = 6, ShinchokuName = "中止", RegisterDateTime = now, UpdateDateTime = now }
                );
        }
    }
}
