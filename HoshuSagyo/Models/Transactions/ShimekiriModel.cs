using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Transactions
{
    public class ShimekiriModel : EntityBase
    {
        // 締切済日
        [Required]
        public DateTime ShimekiriZumiBi { get; set; }

        // 管轄
        [Key]
        public int Kankatsu { get; set; }
    }
}
