using HoshuSagyo.Models.Components;
using HoshuSagyo.Models.DisplayModels;
using System.ComponentModel.DataAnnotations;

namespace HoshuSagyo.Models.InputModels
{
    public class SagyoIchiranGamen
    {
        // 一覧表示する項目の内容
        public List<SagyoIchiranDisplayContent> SagyoIchiranDisplayContents;
    }
}
