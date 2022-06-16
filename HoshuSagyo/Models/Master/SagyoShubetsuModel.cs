using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Master
{
    public class SagyoShubetsuModel : EntityBase
    {
        // 作業種別
        [Key]
        public int SagyoShubetsu { get; set; }

        // 作業種別名
        [Required]
        public string SagyoShubetsuName { get; set; }
    }
}
