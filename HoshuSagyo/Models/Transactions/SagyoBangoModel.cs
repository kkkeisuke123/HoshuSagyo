using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Transactions
{
    public class SagyoBangoModel : EntityBase
    {
        // 作業開始日
        [Required]
        public DateTime? SagyoKaishiBi { get; set; }

        // 系統
        [Required]
        public int Keito { get; set; }

        // 管轄
        [Required]
        public int Kankatsu { get; set; }

        // 最終番号
        [Required]
        public int SaishuBango { get; set; }
    }
}
