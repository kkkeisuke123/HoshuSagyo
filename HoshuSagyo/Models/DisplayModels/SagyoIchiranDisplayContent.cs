namespace HoshuSagyo.Models.DisplayModels
{
    public class SagyoIchiranDisplayContent
    {
        // 作業開始日
        public string SagyoKaishiBi { get; set; }

        // 系統
        public string KeitoName { get; set; }

        // 管轄名
        public string KankatsuName { get; set; }

        // 作業種別名
        public string SagyoShubetsuName { get; set; }

        // 作業場所名
        public string SagyoBashoName { get; set; }

        // 作業内容
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
