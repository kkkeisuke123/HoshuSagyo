using HoshuSagyo.Models.Components;
using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.DisplayModels
{
    public class OnseiOtoDisplayContent
    {
        // ドロップダウンリスト
        public List<Itemlist> OnseiOtoList;
        public List<Itemlist> OnseiOtoShosaiList;

        // 画面項目
        [Display(Name = "音声応答種別")]
        public int SagyoKaishiOnseiOtoShubetsu { get; set; }

        [Display(Name = "音声応答メッセージ")]
        public int SagyoKaishiOnseiOtoShosaiId { get; set; }

        [Display(Name = "音声応答種別")]
        public int SagyoShuryoOnseiOtoShubetsu { get; set; }

        [Display(Name = "音声応答メッセージ")]
        public int SagyoShuryoOnseiOtoShosaiId { get; set; }
    }
}
