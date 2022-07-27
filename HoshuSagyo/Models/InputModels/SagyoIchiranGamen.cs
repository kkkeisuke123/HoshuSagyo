using HoshuSagyo.Models.Components;
using HoshuSagyo.Models.DisplayModels;
using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.InputModels
{
    public class SagyoIchiranGamen
    {
        // 一覧表示する項目の内容
        public List<SagyoIchiranDisplayContent> SagyoIchiranDisplayContents;

        // ドロップダウンリスト
        public List<Itemlist> KeitoList;
        public List<Itemlist> KankatsuList;
        public List<Itemlist> SagyoShubetsuList;
        public List<Itemlist> SagyoBashoList;

        // 作業実績画面のパーツ
        public SagyoJissekiDisplayContent SagyoJissekiDisplayContent;

        // 検索条件
        [Display(Name = "系統")]
        public int? Keito { get; set; }

        [Display(Name = "管轄")]
        public int? Kankatsu { get; set; }

        [Display(Name = "作業種別")]
        public int? SagyoShubetsu { get; set; }

        [Display(Name = "作業場所")]
        public int? SagyoBasho { get; set; }

        [Display(Name = "作業内容")]
        public string? SagyoNaiyo { get; set; }
    }
}
