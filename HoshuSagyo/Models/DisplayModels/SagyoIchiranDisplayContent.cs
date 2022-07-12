namespace HoshuSagyo.Models.DisplayModels
{
    public class SagyoIchiranDisplayContent
    {
        // ID
        public int Id { get; set; }

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
    }
}
