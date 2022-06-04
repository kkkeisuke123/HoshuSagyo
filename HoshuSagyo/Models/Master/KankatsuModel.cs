using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.Master
{
    public class KankatsuModel : EntityBase
    {
        // 管轄
        [Key]
        public int Kankatsu { get; set; }

        // 管轄名
        [Required]
        public string KankatsuName { get; set; }
    }
}
