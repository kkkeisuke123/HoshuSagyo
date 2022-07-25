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
                new KeitoModel { Keito = 1, KeitoName = "指令" },
                new KeitoModel { Keito = 2, KeitoName = "現地" },
                new KeitoModel { Keito = 99, KeitoName = "未定" }
                );

            // 管轄情報
            modelBuilder.Entity<KankatsuModel>().HasData(
                new KankatsuModel { Kankatsu = 1, KankatsuName = "東京"},
                new KankatsuModel { Kankatsu = 2, KankatsuName = "神奈川" },
                new KankatsuModel { Kankatsu = 3, KankatsuName = "千葉" },
                new KankatsuModel { Kankatsu = 4, KankatsuName = "埼玉" },
                new KankatsuModel { Kankatsu = 5, KankatsuName = "群馬" },
                new KankatsuModel { Kankatsu = 6, KankatsuName = "栃木" },
                new KankatsuModel { Kankatsu = 7, KankatsuName = "茨城" }
                );

            // 作業種別
            modelBuilder.Entity<SagyoShubetsuModel>().HasData(
                new SagyoShubetsuModel { SagyoShubetsu = 1, SagyoShubetsuName = "種別A" },
                new SagyoShubetsuModel { SagyoShubetsu = 2, SagyoShubetsuName = "種別B" },
                new SagyoShubetsuModel { SagyoShubetsu = 3, SagyoShubetsuName = "種別C" }
                );

            // 作業場所
            modelBuilder.Entity<SagyoBashoModel>().HasData(
                new SagyoBashoModel { SagyoBasho = 1, SagyoBashoName = "場所A" },
                new SagyoBashoModel { SagyoBasho = 2, SagyoBashoName = "場所B" },
                new SagyoBashoModel { SagyoBasho = 3, SagyoBashoName = "場所C" }
                );

            // 音声応答
            modelBuilder.Entity<OnseiOtoModel>().HasData(
                new OnseiOtoModel { OtoShubetsu = 1, OtoShubetsuNaiyo = "共通" },
                new OnseiOtoModel { OtoShubetsu = 2, OtoShubetsuNaiyo = "施設" },
                new OnseiOtoModel { OtoShubetsu = 3, OtoShubetsuNaiyo = "電力" },
                new OnseiOtoModel { OtoShubetsu = 4, OtoShubetsuNaiyo = "通信" }
                );

            // 音声応答詳細
            modelBuilder.Entity<OnseiOtoShosaiModel>().HasData(
                new OnseiOtoShosaiModel { Id = 1, OtoShubetsu = 1, Message = "関係者以外の人はいませんか" },
                new OnseiOtoShosaiModel { Id = 2, OtoShubetsu = 1, Message = "作業場所は間違っていませんか" },
                new OnseiOtoShosaiModel { Id = 3, OtoShubetsu = 1, Message = "作業員は全員揃いましたか" },
                new OnseiOtoShosaiModel { Id = 4, OtoShubetsu = 1, Message = "道具の忘れ物はありませんか" },
                new OnseiOtoShosaiModel { Id = 5, OtoShubetsu = 2, Message = "施設の責任者から作業許可は出ていますか" },
                new OnseiOtoShosaiModel { Id = 6, OtoShubetsu = 2, Message = "各エリアの施錠は行いましたか" },
                new OnseiOtoShosaiModel { Id = 7, OtoShubetsu = 3, Message = "電気の供給が停止していますか" },
                new OnseiOtoShosaiModel { Id = 8, OtoShubetsu = 3, Message = "電気の供給を再開しましたか" },
                new OnseiOtoShosaiModel { Id = 9, OtoShubetsu = 4, Message = "通信状態をメンテナンス状態にしましたか" },
                new OnseiOtoShosaiModel { Id = 10, OtoShubetsu = 4, Message = "通信状態を通常状態に戻しましたか" }
                );

            // 進捗
            modelBuilder.Entity<ShinchokuModel>().HasData(
                new ShinchokuModel { Shinchoku = 1, ShinchokuName = "未着手", ShinchokuColor = "#FFFFFF" },
                new ShinchokuModel { Shinchoku = 2, ShinchokuName = "着手済", ShinchokuColor = "#00BFFF" },
                new ShinchokuModel { Shinchoku = 3, ShinchokuName = "完了済", ShinchokuColor = "#90EE90" },
                new ShinchokuModel { Shinchoku = 4, ShinchokuName = "着手遅延", ShinchokuColor = "#FFFF00" },
                new ShinchokuModel { Shinchoku = 5, ShinchokuName = "終了遅延", ShinchokuColor = "#FFA500" },
                new ShinchokuModel { Shinchoku = 6, ShinchokuName = "中止", ShinchokuColor = "#D3D3D3" }
                );
        }
    }
}
