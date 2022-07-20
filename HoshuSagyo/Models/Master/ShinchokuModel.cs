using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Master
{
    public class ShinchokuModel : EntityBase
    {
        // 進捗
        [Key]
        public int Shinchoku { get; set; }

        // 進捗名
        [Required]
        public string ShinchokuName { get; set; }

        // 進捗を表す色(16進数)
        [Required]
        public string ShinchokuColor { get; set; }
    }
}
