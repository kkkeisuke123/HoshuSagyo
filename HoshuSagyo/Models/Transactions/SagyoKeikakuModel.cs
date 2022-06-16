using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Transactions
{
    public class SagyoKeikakuModel : EntityBase
    {
        // 作業開始日
        [Required]
        public string SagyoKaishiBi { get; set; }

        // 作業開始時間
        [Required]
        public string SagyoKaishiJikan { get; set; }

        // 作業終了日
        [Required]
        public string SagyoShuryoBi { get; set; }

        // 作業終了時間
        [Required]
        public string SagyoShuryoJikan { get; set; }

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
