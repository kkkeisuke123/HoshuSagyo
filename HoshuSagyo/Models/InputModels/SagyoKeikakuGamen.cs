using HoshuSagyo.Models.Components;
using HoshuSagyo.Models.DisplayModels;
using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.InputModels
{
    public class SagyoKeikakuGamen
    {
        // ドロップダウンリスト
        public List<Itemlist> KeitoList;
        public List<Itemlist> KankatsuList;
        public List<Itemlist> SagyoShubetsuList;
        public List<Itemlist> SagyoBashoList;

        // 音声応答画面のパーツ
        public OnseiOtoDisplayContent onseiOtoDisplayContent;

        // 画面項目
        public int Id { get; set; }

        [Required(ErrorMessage = "作業開始日を入力してください")]
        [DataType(DataType.Date)]
        [Display(Name = "作業開始日")]
        public DateTime SagyoKaishiBi { get; set; }

        [Required(ErrorMessage = "作業開始時間を入力してください")]
        [DataType(DataType.Time)]
        [Display(Name = "作業開始時間")]
        public DateTime SagyoKaishiJikan { get; set; }

        [Required(ErrorMessage = "作業終了日を入力してください")]
        [DataType(DataType.Date)]
        [Display(Name = "作業終了日")]
        public DateTime SagyoShuryoBi { get; set; }

        [Required(ErrorMessage = "作業終了時間を入力してください")]
        [DataType(DataType.Time)]
        [Display(Name = "作業終了時間")]
        public DateTime SagyoShuryoJikan { get; set; }

        [Required(ErrorMessage = "系統を入力してください")]
        [Display(Name = "系統")]
        public int Keito { get; set; }

        [Required(ErrorMessage = "管轄を入力してください")]
        [Display(Name = "管轄")]
        public int Kankatsu { get; set; }

        [Required(ErrorMessage = "作業種別を入力してください")]
        [Display(Name = "作業種別")]
        public int SagyoShubetsu { get; set; }

        [Required(ErrorMessage = "作業場所を入力してください")]
        [Display(Name = "作業場所")]
        public int SagyoBasho { get; set; }

        [Display(Name = "作業番号")]
        public int? SagyoBango { get; set; }

        [Required(ErrorMessage = "作業内容を入力してください")]
        [MaxLength(90)]
        [Display(Name = "作業内容")]
        public string SagyoNaiyo { get; set; }

        [MaxLength(20)]
        [Display(Name = "自社責任者名")]
        public string? JishaSekininshaMei { get; set; }

        [Range(0, 999)]
        [Display(Name = "自社作業員数")]
        public int? JishaSagyoinSu { get; set; }

        [MaxLength(20)]
        [Display(Name = "協力会社責任者名")]
        public string? KyoryokuGaishaSekininshaMei { get; set; }

        [Range(0, 999)]
        [Display(Name = "協力会社作業員数")]
        public int? KyoryokuGaishaSagyoinSu { get; set; }
    }
}
