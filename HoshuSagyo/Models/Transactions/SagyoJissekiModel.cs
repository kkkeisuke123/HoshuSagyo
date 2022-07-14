using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoshuSagyo.Models.Transactions
{
    public class SagyoJissekiModel : EntityBase
    {
        // 作業計画ID
        [Key]
        public int SagyoKeikakuId { get; set; }

        // 進捗
        [Required]
        public int Shinchoku { get; set; }

        // 作業着手日時
        public DateTime? SagyoChakushuNichiji { get; set; }

        // 作業完了日時
        public DateTime? SagyoKanryoNichiji { get; set; }

        // 作業着手責任者名
        public string SagyoChakushuSekininshaMei { get; set; }

        // 作業完了責任者名
        public string SagyoKanryoSekininshaMei { get; set; }
    }
}
