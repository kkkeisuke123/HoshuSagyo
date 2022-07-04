using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.InputModels
{
    public class SagyoBangoGamen
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "作業日（ここから）")]
        public DateTime SagyoBiFrom { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "作業日（ここまで）")]
        public DateTime SagyoBiTo { get; set; }
    }
}
