using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Master
{
    public class SagyoBashoModel : EntityBase
    {
        // 作業場所
        [Key]
        public int SagyoBasho { get; set; }

        // 作業場所名
        [Required]
        public string SagyoBashoName { get; set; }
    }
}
