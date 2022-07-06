using System.ComponentModel.DataAnnotations;

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
    }
}
