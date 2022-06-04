using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Master
{
    public class KeitoModel : EntityBase
    {
        // 系統
        [Key]
        public int Keito { get; set; }

        // 系統名
        [Required]
        public string KeitoName { get; set; }
    }
}
