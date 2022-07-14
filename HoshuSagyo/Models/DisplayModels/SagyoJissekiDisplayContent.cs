using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.DisplayModels
{
    public class SagyoJissekiDisplayContent
    {
        // 画面項目
        [DataType(DataType.DateTime)]
        [Display(Name = "作業着手日時")]
        public DateTime? SagyoChakushuNichiji { get; set; }

        [MaxLength(20)]
        [Display(Name = "作業着手責任者名")]
        public string SagyoChakushuSekininshaMei { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "作業完了日時")]
        public DateTime? SagyoKanryoNichiji { get; set; }

        [MaxLength(20)]
        [Display(Name = "作業完了責任者名")]
        public string SagyoKanryoSekininshaMei { get; set; }
    }
}
