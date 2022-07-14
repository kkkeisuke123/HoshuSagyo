
// 作業実績画面が開かれたとき、
// 対象の作業実績データをAjaxで取得し、画面に反映します
$(document).ready(function () {

    // 作業一覧画面の「開く」ボタン全てに対して、イベントを設定する
    $("td button").each(function (i, element) {
        $(element).on("click", function () {
            getSagyoJisseki($(element).attr("id"));
        });
    });

    // 作業実績情報を取得し、作業実績画面に反映させる
    function getSagyoJisseki(sagyoKeikakuId) {
        $.ajax({
            type: "Post",
            url: "/AjaxUtility/GetSagyoJisseki",
            data: { "SagyoKeikakuId": sagyoKeikakuId },
            dataType: "json"
        }).done(function (result) {
            $("#SagyoChakushuNichiji").val(result["sagyoChakushuNichiji"]);
            $("#SagyoChakushuSekininshaMei").val(result["sagyoChakushuSekininshaMei"]);
            $("#SagyoKanryoNichiji").val(result["sagyoKanryoNichiji"]);
            $("#SagyoKanryoSekininshaMei").val(result["sagyoKanryoSekininshaMei"]);
        });
    }
}); 