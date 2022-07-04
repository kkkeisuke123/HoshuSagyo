using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Transactions
{
    public class SagyoKeikakuModel : EntityBase
    {
        // 作業開始日時
        [Required]
        public DateTime SagyoKaishiNichiji { get; set; }

        // 作業終了日時
        [Required]
        public DateTime SagyoShuryoNichiji { get; set; }

        // 系統
        [Required]
        public int Keito { get; set; }

        // 管轄
        [Required]
        public int Kankatsu { get; set; }

        // 作業種別
        [Required]
        public int SagyoShubetsu { get; set; }

        // 作業場所
        [Required]
        public int SagyoBasho { get; set; }

        // 作業番号
        public int? SagyoBango { get; set; }

        // 作業内容
        [Required]
        public string SagyoNaiyo { get; set; }

        // 自社責任者名
        public string? JishaSekininshaMei { get; set; }

        // 自社作業員数
        public int? JishaSagyoinSu { get; set; }

        // 協力会社責任者名
        public string? KyoryokuGaishaSekininshaMei { get; set; }

        // 協力会社作業員数
        public int? KyoryokuGaishaSagyoinSu { get; set; }
    }
}
