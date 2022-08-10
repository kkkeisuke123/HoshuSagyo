
$(document).ready(function () {

    // 進捗リンククリック時の処理
    $(".open-modal-link").each(function (i, element) {
        $(element).on("click", function () {
            getSagyoJisseki($(element).attr("id"));
        });
    });

    // 作業計画IDに紐づく作業実績情報を取得する
    function getSagyoJisseki(sagyoKeikakuId) {
        $.ajax({
            type: "Post",
            url: "/Utility/GetSagyoJisseki",
            data: { "SagyoKeikakuId": sagyoKeikakuId },
            dataType: "json"
        }).done(function (response) {
            $("#SagyoKeikakuId").val(response["sagyoKeikakuId"]);
            $("#SagyoChakushuNichiji").val(response["sagyoChakushuNichiji"]);
            $("#SagyoChakushuSekininshaMei").val(response["sagyoChakushuSekininshaMei"]);
            $("#SagyoKanryoNichiji").val(response["sagyoKanryoNichiji"]);
            $("#SagyoKanryoSekininshaMei").val(response["sagyoKanryoSekininshaMei"]);
        });
    }

    // 閉じるボタン押下時の処理
    $("#btn-close").click(function () {
        // エラーメッセージを全てクリア
        clearAllErrorMassage();
    });

    // 「×」ボタン押下時の処理
    $(".btn-close").click(function () {
        // エラーメッセージを全てクリア
        clearAllErrorMassage();
    });

    // 入力チェックエラー時のメッセージをクリアする
    function clearAllErrorMassage() {
        $("#SagyoChakushuNichiji-error").text("");
        $("#SagyoChakushuSekininshaMei-error").text("");
    }
}); 