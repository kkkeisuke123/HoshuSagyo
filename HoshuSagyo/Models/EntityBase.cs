using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models
{
    /// <summary>
    /// テーブルの共通カラムを定義する抽象クラス
    /// </summary>
    public  abstract class EntityBase
    {
        public EntityBase()
        {
            RegisterDateTime = UpdateDateTime = DateTime.Now;
        }

        // 登録日時
        [Required]
        public DateTime? RegisterDateTime { get; set; }

        // 更新日時
        [Required]
        public DateTime? UpdateDateTime { get; set; }
    }
}
