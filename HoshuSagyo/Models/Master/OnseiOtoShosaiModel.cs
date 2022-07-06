using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Master
{
    public class OnseiOtoShosaiModel : EntityBase
    {
        // ID
        [Key]
        public int Id { get; set; }

        // 応答種別
        [Required]
        public int OtoShubetsu { get; set; }

        // メッセージ
        [Required]
        public string Message { get; set; }
    }
}
