using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Master
{
    public class UserInfoModel : EntityBase
    {
        // ユーザーID
        [Key]
        public string UserId { get; set; }

        // 系統
        [Required]
        public string Keito { get; set; }

        // 管轄
        [Required]
        public string Kankatsu { get; set; }
    }
}
