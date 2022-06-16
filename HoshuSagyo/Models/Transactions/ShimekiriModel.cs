using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Transactions
{
    public class ShimekiriModel : EntityBase
    {
        // 締切済日
        [Required]
        public DateTime? ShimekiriZumiBi { get; set; }

        // 管轄
        [Required]
        public int Kankatsu { get; set; }

        // 系統
        [Required]
        public int Keito { get; set; }
    }
}
