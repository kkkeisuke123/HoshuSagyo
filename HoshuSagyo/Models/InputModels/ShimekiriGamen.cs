using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.InputModels
{
    public class ShimekiriGamen
    {
        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "現在の締切済日")]
        public DateTime OldShimekiriZumiBi { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "新しい締切済日")]
        public DateTime NewShimekiriZumiBi { get; set; }
    }
}
