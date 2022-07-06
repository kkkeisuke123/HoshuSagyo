using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Master
{
    public class OnseiOtoModel : EntityBase
    {
        // 応答種別
        [Key]
        public int OtoShubetsu { get; set; }

        // 応答種別内容
        [Required]
        public string OtoShubetsuNaiyo { get; set; }
    }
}
