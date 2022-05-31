using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Transactions
{
    public class ShimekiriModel : EntityBase
    {
        public ShimekiriModel()
        {
            ShimekiriZumiBi = DateTime.Now;
            Kankatsu = 0;
            Keito = 0;
        }

        // 締切済日
        [Key]
        public DateTime? ShimekiriZumiBi { get; set; }

        // 管轄
        [Required]
        public int Kankatsu { get; set; }

        // 系統
        [Required]
        public int Keito { get; set; }
    }
}
