using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Transactions
{
    public class SagyoBangoModel : EntityBase
    {
        // 年月
        [Required]
        public string Nengetsu { get; set; }

        // 管轄
        [Required]
        public int Kankatsu { get; set; }

        // 最終番号
        [Required]
        public int SaishuBango { get; set; }
    }
}
